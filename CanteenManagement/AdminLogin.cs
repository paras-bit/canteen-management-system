using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenManagement
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_Staff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginFrm l = new LoginFrm();
            l.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
                {
                    AdminFrm a1 = new AdminFrm();
                    a1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password!!!");
                }
            }
        }
    }
}
