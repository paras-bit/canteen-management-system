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
using System.Text.RegularExpressions;

namespace CanteenManagement
{
    public partial class SupplierFrm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\CanteenManagement\CanteenManagement\CanteenDB.mdf;Integrated Security=True;Connect Timeout=30");
        private DataTable originalDataTable;
        public SupplierFrm()
        {
            InitializeComponent();
        }
        private void BindSupplierList()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM suppliertbl", con))
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
            txtContact.Clear();
            txtAddress.Clear();
            textBox1.Clear();
            btnAdd.Enabled = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs())
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO suppliertbl (SName, Contact, Address) VALUES (@name, @contact, @address)", con))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Supplier Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextFields();
                            BindSupplierList();
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
        private bool ValidateInputs()
        {
            
            Regex contactRegex = new Regex(@"^[0-9]{10}$");

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please enter contact", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact.Focus();
                return false;
            }

            if (!contactRegex.IsMatch(txtContact.Text))
            {
                MessageBox.Show("Please enter valid contact", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact.Focus();
                return false;
            }

            

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return false;
            }

            return true;
        }

        private void SupplierFrm_Load(object sender, EventArgs e)
        {
            BindSupplierList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int supplierId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    if (ValidateInputs())
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE suppliertbl SET SName = @name, Contact = @contact, Address = @address WHERE Id = @id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", supplierId);
                            cmd.Parameters.AddWithValue("@name", txtName.Text);
                            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                            cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            con.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Supplier Updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearTextFields();
                                BindSupplierList();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a supplier to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                txtName.Text = selectedRow.Cells["SName"].Value.ToString();
                txtContact.Text = selectedRow.Cells["Contact"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                btnAdd.Enabled = false;
            }
            else
            {

                ClearTextFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int supplierId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    if (ValidateInputs())
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {

                            using (SqlCommand cmd = new SqlCommand("DELETE FROM suppliertbl WHERE Id = @id", con))
                            {
                                cmd.Parameters.AddWithValue("@id", supplierId);

                                con.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();
                                con.Close();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Supplier Deleted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    BindSupplierList();
                                    ClearTextFields();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a supplier to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = textBox1.Text.Trim();

                if (originalDataTable != null)
                {
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        DataTable filteredData = originalDataTable.AsEnumerable()
                            .Where(row =>
                                row.Field<string>("SName").ToLower().Contains(searchText.ToLower())
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

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }
    }
}
