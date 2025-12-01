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
    public partial class AdminFrm : Form
    {
        private Form activeForm;
        public AdminFrm()
        {
            InitializeComponent();
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
        private void btnLogout_Click(object sender, EventArgs e)
        {
            AdminLogin l = new AdminLogin();
            l.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimze_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminFrm_Load(object sender, EventArgs e)
        {
            btnCloseChildForm.Visible = false;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
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

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StaffFrm(), sender);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StockFrm(), sender);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SupplierFrm(), sender);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PurchaseFrm(), sender);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportAdmin(), sender);
        }
    }
}
