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
    public partial class MainFrm : Form
    {
        private Form activeForm;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            btnCloseChildForm.Visible = false;

        }
        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelHome.Text = childForm.Text;
            btnCloseChildForm.Visible = true;
        
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerFrm(), sender);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ItemsFrm(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            labelHome.Text = "Home";
            btnCloseChildForm.Visible = false;
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryFrm(), sender);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BillFrm(), sender);
        }

        private void btnMinimze_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginFrm l = new LoginFrm();
            l.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new dashboard(), sender);
        }
        
    }
}
