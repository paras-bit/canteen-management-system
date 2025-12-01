using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CanteenManagement
{
    public partial class PurchaseFrm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\CanteenManagement\CanteenManagement\CanteenDB.mdf;Integrated Security=True;Connect Timeout=30");
        private DataTable originalDataTable;
        public PurchaseFrm()
        {
            InitializeComponent();
        }

        private void BindSupplierList()
        {
            try
            {
                con.Open();
                
                string sqlQuery = "SELECT Id, SName, Contact FROM suppliertbl";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                comboSupplier.DisplayMember = "SName";
                comboSupplier.ValueMember = "Id";  
                comboSupplier.DataSource = dt;

                sqlReader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void PurchaseFrm_Load(object sender, EventArgs e)
        {
            BindSupplierList();
            BindItemList();
        }

        private void ClearTextFields()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtRequiredQty.Clear();
        }

        private void BindItemList()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM stocktbl", con))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    originalDataTable = dt.Copy();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                txtName.Text = selectedRow.Cells["Stock"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();

            }
            else
            {

                ClearTextFields();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                if (originalDataTable != null)
                {
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        DataTable filteredData = originalDataTable.AsEnumerable()
                            .Where(row =>
                                row.Field<string>("Stock").ToLower().Contains(searchText.ToLower())
                            )
                            .CopyToDataTable();

                        dataGridView1.DataSource = filteredData;
                    }
                    else
                    {
                        dataGridView1.DataSource = originalDataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClearTextFields();
            }     
        }

        private void btnAddtoBill_Click(object sender, EventArgs e)
        {
            try
            {
                bool itemExists = false;
                foreach (DataGridViewRow row in dataGridBill.Rows)
                {
                    var cellValue = row.Cells["Stock"].Value;
                    if (cellValue != null && cellValue.ToString() == txtName.Text)
                    {
                        itemExists = true;
                        MessageBox.Show("Item already exists in the bill.");
                        break;
                    }
                }

                if (!itemExists)
                {
                    decimal price = decimal.Parse(txtPrice.Text);
                    int desiredQuantity = int.Parse(txtRequiredQty.Text);
                    decimal total = price * desiredQuantity;
                    dataGridBill.Rows.Add(txtName.Text, price, desiredQuantity, total);
                    BindItemList();
                    CalculateGrandTotal();
                    ClearTextFields();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric quantities.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void CalculateGrandTotal()
        {
            decimal grandTotal = 0;
            foreach (DataGridViewRow row in dataGridBill.Rows)
            {
                grandTotal += Convert.ToDecimal(row.Cells["Total"].Value);
            }
            lblGrandTotal.Text = grandTotal.ToString("C");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dataGridBill.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridBill.SelectedRows)
                {
                    dataGridBill.Rows.Remove(row);
                }


                CalculateGrandTotal();

                MessageBox.Show("Selected item(s) removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select item(s) to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SavePurchaseToDatabase(SqlTransaction transaction)
        {
            try
            {
                int supplierId = Convert.ToInt32(comboSupplier.SelectedValue);
                DateTime purchaseDate = DateTime.Now;
                decimal grandTotal = decimal.Parse(lblGrandTotal.Text, System.Globalization.NumberStyles.Currency);

                string insertQuery = "INSERT INTO purchasetbl (SupplierID, PurchaseDate, GrandTotal) VALUES (@SupplierID, @PurchaseDate, @GrandTotal)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                    cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                    cmd.Parameters.AddWithValue("@GrandTotal", grandTotal);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving purchase: " + ex.Message);
            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if (dataGridBill.Rows.Count > 0)
            {
                try
                {
                    con.Open();
                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        
                        SavePurchaseToDatabase(transaction);

                        foreach (DataGridViewRow row in dataGridBill.Rows)
                        {
                            string stockName = row.Cells["Stock"].Value.ToString();
                            int desiredQuantity = int.Parse(row.Cells["Qty"].Value.ToString());

                            IncreaseStock(stockName, desiredQuantity, transaction);
                        }

                        
                        transaction.Commit();
                        MessageBox.Show("Purchase and stock update completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridBill.Rows.Clear();
                        lblGrandTotal.Text = "0";
                        BindItemList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("No items in the bill to save.", "Empty Bill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void IncreaseStock(string stockName, int quantityPurchased, SqlTransaction transaction)
        {
            try
            {
                string updateQuery = "UPDATE stocktbl SET Quantity = Quantity + @QuantityPurchased WHERE Stock = @StockName";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con, transaction))
                {
                    cmd.Parameters.AddWithValue("@QuantityPurchased", quantityPurchased);
                    cmd.Parameters.AddWithValue("@StockName", stockName);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating stock: " + ex.Message);
            }
        }
    }
}
