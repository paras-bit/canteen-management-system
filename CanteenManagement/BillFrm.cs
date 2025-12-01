using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;


namespace CanteenManagement
{
    public partial class BillFrm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\CanteenManagement\CanteenManagement\CanteenDB.mdf;Integrated Security=True;Connect Timeout=30");
        private DataTable originalDataTable;
        
        
        public BillFrm()
        {
            InitializeComponent();
            
            
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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM itemtbl", con))
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
        

        private void BillFrm_Load(object sender, EventArgs e)
        {
            BindItemList();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                txtName.Text = selectedRow.Cells["Item"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
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
                                row.Field<string>("Item").ToLower().Contains(searchText.ToLower())
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

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            {
                string searchText = txtCustomerSearch.Text.Trim();
                if (!string.IsNullOrEmpty(searchText))
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM customertbl WHERE Name LIKE @SearchText OR Contact LIKE @SearchText", con))
                        {
                            cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                            con.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtCustomer.Text = reader["Name"].ToString();
                                    txtContact.Text = reader["Contact"].ToString();
                                    
                                }
                                else
                                {
                                    txtCustomer.Clear();
                                    txtContact.Clear();
                                   
                                }
                            }
                            con.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                }
                else
                {
                    txtCustomer.Clear();
                    txtContact.Clear();
                    
                }
            }
        }

        private void btnAddtoBill_Click(object sender, EventArgs e)
        {
            try
            {
                int availableQuantity = int.Parse(txtQuantity.Text);
                int desiredQuantity = int.Parse(txtRequiredQty.Text);

                if (desiredQuantity <= availableQuantity)
                {
                    bool itemExists = false;
                    foreach (DataGridViewRow row in dataGridBill.Rows)
                    {
                        var cellValue = row.Cells["ItemName"].Value;
                        if (cellValue != null && cellValue.ToString() == txtName.Text)
                        {
                            itemExists = true;
                            MessageBox.Show("item already exist in bill");
                            break;
                        }
                    }

                    if (!itemExists)
                    {
                        
                        decimal price = decimal.Parse(txtPrice.Text);
                        decimal total = price * desiredQuantity;

                        dataGridBill.Rows.Add(txtName.Text, price, desiredQuantity, total);
                        
                        CalculateGrandTotal();
                        ClearTextFields();
                    }
                }
                else
                {
                    MessageBox.Show("Desired quantity exceeds available quantity. Please enter a valid quantity.", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtCustomer.Text;
                string grandTotalText = lblGrandTotal.Text.Replace("$", "").Trim();
                decimal grandtotal = Decimal.Parse(grandTotalText, NumberStyles.Currency);
                DateTime transactionDate = dateTimePicker1.Value; 
                string contact = txtContact.Text;


                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                      
                      int invoiceId = InsertTransactionData(name, grandtotal, transactionDate, transaction);

                        foreach (DataGridViewRow row in dataGridBill.Rows)
                        {
                            if (row.IsNewRow) continue;
                            string itemName = Convert.ToString(row.Cells["ItemName"].Value);
                            decimal price = Convert.ToDecimal(row.Cells["PriceBill"].Value);
                            int quantity = Convert.ToInt32(row.Cells["Qty"].Value);
                            decimal total = Convert.ToDecimal(row.Cells["Total"].Value);

                            int itemId = GetIDFromItemName(itemName, transaction);
                            InsertItemData(invoiceId, itemName, price, quantity, total, transaction);
                            UpdateItemQuantity(itemId, quantity, transaction);
                        }

                        transaction.Commit();
                        MessageBox.Show("Bill printed and transaction recorded successfully! with invoice id"+invoiceId);
                        dataGridBill.Rows.Clear();
                        lblGrandTotal.Text = "0";

                        new Report.PrintInvoiceFrm(invoiceId).Show();

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message);
            }
        }      

        private int InsertTransactionData(string name, decimal grandtotal, DateTime transactionDate, SqlTransaction transaction)
        {
            int invoiceId = -1;
            string insertQuery = "INSERT INTO Invoice_Master (Cust_Name, Grand_Total, InvoiceDate) OUTPUT INSERTED.InvoiceId VALUES (@Cust_Name, @Grand_Total, @InvoiceDate)";

            using (SqlCommand command = new SqlCommand(insertQuery, con, transaction))
            {
                command.Parameters.AddWithValue("@Cust_Name", name);
                command.Parameters.AddWithValue("@Grand_Total", grandtotal);
                command.Parameters.AddWithValue("@InvoiceDate", transactionDate);

               
                invoiceId = (int)command.ExecuteScalar();
            }

            return invoiceId;
        }

        private void InsertItemData(int invoiceId,string item, decimal price, int quantity, decimal total, SqlTransaction transaction)
        {
            string insertQuery = "INSERT INTO Invoice_Detail (MasterID,ItemName, ItemPrice, ItemQuantity, ItemTotal) VALUES (@MasterID,@ItemName, @ItemPrice, @ItemQuantity, @ItemTotal)";

            using (SqlCommand command = new SqlCommand(insertQuery, con, transaction))
            {
                command.Parameters.AddWithValue("@MasterID", invoiceId);
                command.Parameters.AddWithValue("@ItemName", item);
                command.Parameters.AddWithValue("@ItemPrice", price);
                command.Parameters.AddWithValue("@ItemQuantity", quantity);
                command.Parameters.AddWithValue("@ItemTotal", total);
                
                command.ExecuteNonQuery();
            }
        }
        private int GetIDFromItemName(string itemName, SqlTransaction transaction)
        {
            int id = -1;
            string query = "SELECT ItemId FROM itemtbl WHERE Item = @ItemName";

            using (SqlCommand command = new SqlCommand(query, con, transaction))
            {
                command.Parameters.AddWithValue("@ItemName", itemName);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["ItemId"]);
                }
                reader.Close();
            }
            return id;
        }
        private void UpdateItemQuantity(int itemId, int soldQuantity, SqlTransaction transaction)
        {
            string updateQuery = "UPDATE itemtbl SET Quantity = Quantity - @SoldQuantity WHERE ItemId = @ItemId";

            using (SqlCommand command = new SqlCommand(updateQuery, con, transaction))
            {
                command.Parameters.AddWithValue("@SoldQuantity", soldQuantity);
                command.Parameters.AddWithValue("@ItemId", itemId);

                command.ExecuteNonQuery();
            }
        }          
    }
}
