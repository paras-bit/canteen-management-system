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
    public partial class LoginFrm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\CanteenManagement\CanteenManagement\CanteenDB.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }
                else if (txtPassword.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
                else 
                {
                    con.Open();
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    SqlCommand cmd = new SqlCommand("select username,password from stafftbl where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        splash mn = new splash();
                        mn.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void linkLabel_Staff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin a = new AdminLogin();
            a.Show();
            this.Hide();
        }
    }
}
