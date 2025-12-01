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
    public partial class CategoryFrm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\CanteenManagement\CanteenManagement\CanteenDB.mdf;Integrated Security=True;Connect Timeout=30");
        private DataTable originalDataTable;
        public CategoryFrm()
        {
            InitializeComponent();
        }

        private void BindCategoryList()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM categorytbl", con))
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
            txtDescription.Clear();
            txtSearch.Clear();
            btnAdd.Enabled = true;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter category name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
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
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO categorytbl (Category, Description) VALUES (@name, @description)", con))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                      
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextFields();
                            BindCategoryList();
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

        private void CategoryFrm_Load(object sender, EventArgs e)
        {
            BindCategoryList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                txtName.Text = selectedRow.Cells["Category"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString();
                btnAdd.Enabled = false;
            }
            else
            {

                ClearTextFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int categoryId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    if (ValidateInputs())
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE categorytbl SET Category = @name, Description = @description WHERE CatId = @id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", categoryId);
                            cmd.Parameters.AddWithValue("@name", txtName.Text);
                            cmd.Parameters.AddWithValue("@description", txtDescription.Text);

                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            con.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Category Updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearTextFields();
                                BindCategoryList();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a category to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    int categoryId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CatId"].Value);

                    if (ValidateInputs())
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {

                            using (SqlCommand cmd = new SqlCommand("DELETE FROM categorytbl WHERE CatId = @id", con))
                            {
                                cmd.Parameters.AddWithValue("@id", categoryId);

                                con.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();
                                con.Close();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Category Deleted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    BindCategoryList();
                                    ClearTextFields();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a category to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
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
                                row.Field<string>("Category").ToLower().Contains(searchText.ToLower())
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
    }
}
