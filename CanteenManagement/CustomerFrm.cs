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
    public partial class CustomerFrm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\CanteenManagement\CanteenManagement\CanteenDB.mdf;Integrated Security=True;Connect Timeout=30");
        private DataTable originalDataTable;

        public CustomerFrm()
        {
            InitializeComponent();
        }

        private void BindCustomerList()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM customertbl", con))
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
            txtEmail.Clear();
            comboGender.SelectedIndex = -1;
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
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO customertbl (name, contact, email, gender, address) VALUES (@name, @contact, @email, @gender, @address)", con))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@gender", comboGender.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextFields();
                            BindCustomerList();
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
            Regex emailRegex = new Regex(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$");
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

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            if (!emailRegex.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Please enter valid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboGender.Text))
            {
                MessageBox.Show("Please select gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboGender.Focus();
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

        private void CustomerFrm_Load(object sender, EventArgs e)
        {
            BindCustomerList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int customerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    if (ValidateInputs())
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE customertbl SET name = @name, contact = @contact, email = @email, gender = @gender, address = @address WHERE CustId = @id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", customerId);
                            cmd.Parameters.AddWithValue("@name", txtName.Text);
                            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@gender", comboGender.Text);
                            cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            con.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer Updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearTextFields();
                                BindCustomerList();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a customer to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtContact.Text = selectedRow.Cells["Contact"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                comboGender.Text = selectedRow.Cells["Gender"].Value.ToString();
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
                    int customerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CustId"].Value);

                    if (ValidateInputs())
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {

                            using (SqlCommand cmd = new SqlCommand("DELETE FROM customertbl WHERE CustId = @id", con))
                            {
                                cmd.Parameters.AddWithValue("@id", customerId);

                                con.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();
                                con.Close();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Customer Deleted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    BindCustomerList();
                                    ClearTextFields();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                row.Field<string>("Name").ToLower().Contains(searchText.ToLower())
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
