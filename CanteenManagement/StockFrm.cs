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
    public partial class StockFrm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\CanteenManagement\CanteenManagement\CanteenDB.mdf;Integrated Security=True;Connect Timeout=30");
        private DataTable originalDataTable;
        public StockFrm()
        {
            InitializeComponent();
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

        private void ClearTextFields()
        {
            txtName.Clear();         
            txtQuantity.Clear();
            txtUnit.Clear();
            txtSearch.Clear();
            btnAdd.Enabled = true;
        }
        private bool ValidateInputs()
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Please enter price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnit.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs())
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO stocktbl (Stock, Quantity, Unit) VALUES (@stock, @quantity, @unit)", con))
                    {
                        cmd.Parameters.AddWithValue("@stock", txtName.Text);
                        
                        cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                        cmd.Parameters.AddWithValue("@unit", txtUnit.Text);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextFields();
                            BindItemList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StockFrm_Load(object sender, EventArgs e)
        {
            BindItemList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    if (ValidateInputs())
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE stocktbl SET Stock = @name, Quantity = @quantity, Unit = @unit WHERE Id = @id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", Id);
                            cmd.Parameters.AddWithValue("@name", txtName.Text);
                            cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                            cmd.Parameters.AddWithValue("@unit", txtUnit.Text);

                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            con.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item Updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearTextFields();
                                BindItemList();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a item to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int itemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    if (ValidateInputs())
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {

                            using (SqlCommand cmd = new SqlCommand("DELETE FROM stocktbl WHERE Id = @id", con))
                            {
                                cmd.Parameters.AddWithValue("@id", itemId);

                                con.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();
                                con.Close();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Item Deleted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    BindItemList();
                                    ClearTextFields();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                txtName.Text = selectedRow.Cells["Stock"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();
                txtUnit.Text = selectedRow.Cells["Unit"].Value.ToString();
                btnAdd.Enabled = false;
            }
            else
            {

                ClearTextFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }
    }
}
