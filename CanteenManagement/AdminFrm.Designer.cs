namespace CanteenManagement
{
    partial class AdminFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFrm));
            this.label2 = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHome = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinimze = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eats and Treats";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.White;
            this.panelDesktopPane.Controls.Add(this.label2);
            this.panelDesktopPane.Controls.Add(this.label1);
            this.panelDesktopPane.Controls.Add(this.pictureBox1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(200, 55);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(854, 452);
            this.panelDesktopPane.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CanteenManagement.Properties.Resources.main;
            this.pictureBox1.Location = new System.Drawing.Point(271, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelHome
            // 
            this.labelHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.labelHome.Location = new System.Drawing.Point(373, 13);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(66, 25);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Home";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.panelTitle.Controls.Add(this.btnMinimze);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.btnCloseChildForm);
            this.panelTitle.Controls.Add(this.labelHome);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(854, 55);
            this.panelTitle.TabIndex = 4;
            // 
            // btnMinimze
            // 
            this.btnMinimze.BackgroundImage = global::CanteenManagement.Properties.Resources.minimize;
            this.btnMinimze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimze.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.btnMinimze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimze.Location = new System.Drawing.Point(785, 3);
            this.btnMinimze.Name = "btnMinimze";
            this.btnMinimze.Size = new System.Drawing.Size(30, 30);
            this.btnMinimze.TabIndex = 3;
            this.btnMinimze.UseVisualStyleBackColor = true;
            this.btnMinimze.Click += new System.EventHandler(this.btnMinimze_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::CanteenManagement.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(816, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackgroundImage = global::CanteenManagement.Properties.Resources.back;
            this.btnCloseChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseChildForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Location = new System.Drawing.Point(6, 12);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(45, 30);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eats and Treats";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 55);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Controls.Add(this.btnSupplier);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 507);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 457);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = " Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.btnReport.Image = global::CanteenManagement.Properties.Resources.report;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 255);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(200, 50);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "   Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnBill
            // 
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.btnBill.Image = global::CanteenManagement.Properties.Resources.bill;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(0, 205);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBill.Size = new System.Drawing.Size(200, 50);
            this.btnBill.TabIndex = 4;
            this.btnBill.Text = "   Purchase Bill";
            this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.btnSupplier.Image = global::CanteenManagement.Properties.Resources.supplier;
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(0, 155);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSupplier.Size = new System.Drawing.Size(200, 50);
            this.btnSupplier.TabIndex = 3;
            this.btnSupplier.Text = "   Supplier";
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnStock
            // 
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.btnStock.Image = global::CanteenManagement.Properties.Resources.items;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 105);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(200, 50);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "   Stock";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            this.btnStaff.Image = global::CanteenManagement.Properties.Resources.customer;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 55);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(200, 50);
            this.btnStaff.TabIndex = 1;
            this.btnStaff.Text = "   Staff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // AdminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 507);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminFrm";
            this.Load += new System.EventHandler(this.AdminFrm_Load);
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimze;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStaff;
    }
}