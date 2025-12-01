namespace CanteenManagement
{
    partial class PurchaseFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddtoBill = new System.Windows.Forms.Button();
            this.txtRequiredQty = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridBill = new System.Windows.Forms.DataGridView();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboSupplier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBill.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.White;
            this.btnPrintBill.Location = new System.Drawing.Point(585, 411);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(120, 30);
            this.btnPrintBill.TabIndex = 214;
            this.btnPrintBill.Text = "Save";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.lblGrandTotal.Location = new System.Drawing.Point(580, 383);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(23, 25);
            this.lblGrandTotal.TabIndex = 213;
            this.lblGrandTotal.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(724, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 30);
            this.btnClear.TabIndex = 212;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.panel1.Location = new System.Drawing.Point(11, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 1);
            this.panel1.TabIndex = 211;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 210;
            this.label5.Text = "Item Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 209;
            this.label4.Text = "Supplier Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 206;
            this.label2.Text = "Search";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(644, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 205;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(605, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 17);
            this.label14.TabIndex = 204;
            this.label14.Text = "Date";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(226, 272);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 25);
            this.txtSearch.TabIndex = 203;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(139, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 202;
            this.label9.Text = "Search Items";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(214, 229);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 30);
            this.btnReset.TabIndex = 201;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddtoBill
            // 
            this.btnAddtoBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.btnAddtoBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoBill.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoBill.ForeColor = System.Drawing.Color.White;
            this.btnAddtoBill.Location = new System.Drawing.Point(65, 229);
            this.btnAddtoBill.Name = "btnAddtoBill";
            this.btnAddtoBill.Size = new System.Drawing.Size(120, 30);
            this.btnAddtoBill.TabIndex = 200;
            this.btnAddtoBill.Text = "Add to Bill";
            this.btnAddtoBill.UseVisualStyleBackColor = false;
            this.btnAddtoBill.Click += new System.EventHandler(this.btnAddtoBill_Click);
            // 
            // txtRequiredQty
            // 
            this.txtRequiredQty.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequiredQty.Location = new System.Drawing.Point(217, 188);
            this.txtRequiredQty.Name = "txtRequiredQty";
            this.txtRequiredQty.Size = new System.Drawing.Size(160, 25);
            this.txtRequiredQty.TabIndex = 199;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(25, 188);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(160, 25);
            this.txtQuantity.TabIndex = 198;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(214, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 197;
            this.label11.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 196;
            this.label12.Text = "Available Quantity";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(217, 137);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(160, 25);
            this.txtPrice.TabIndex = 195;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(25, 137);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(160, 25);
            this.txtName.TabIndex = 194;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(214, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 193;
            this.label8.Text = "Price per Unit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 192;
            this.label10.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(592, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 191;
            this.label1.Text = "Customer Bill";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.dataGridView1.Location = new System.Drawing.Point(14, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(372, 138);
            this.dataGridView1.TabIndex = 190;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridBill
            // 
            this.dataGridBill.AllowUserToAddRows = false;
            this.dataGridBill.AllowUserToDeleteRows = false;
            this.dataGridBill.AllowUserToResizeColumns = false;
            this.dataGridBill.AllowUserToResizeRows = false;
            this.dataGridBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBill.BackgroundColor = System.Drawing.Color.White;
            this.dataGridBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridBill.ColumnHeadersHeight = 25;
            this.dataGridBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stock,
            this.PriceBill,
            this.Qty,
            this.Total});
            this.dataGridBill.EnableHeadersVisualStyles = false;
            this.dataGridBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.dataGridBill.Location = new System.Drawing.Point(404, 92);
            this.dataGridBill.Name = "dataGridBill";
            this.dataGridBill.RowHeadersVisible = false;
            this.dataGridBill.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridBill.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridBill.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.dataGridBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBill.Size = new System.Drawing.Size(440, 276);
            this.dataGridBill.TabIndex = 189;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // PriceBill
            // 
            this.PriceBill.HeaderText = "Price";
            this.PriceBill.Name = "PriceBill";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // comboSupplier
            // 
            this.comboSupplier.FormattingEnabled = true;
            this.comboSupplier.Location = new System.Drawing.Point(25, 53);
            this.comboSupplier.Name = "comboSupplier";
            this.comboSupplier.Size = new System.Drawing.Size(160, 21);
            this.comboSupplier.TabIndex = 215;
            // 
            // PurchaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 452);
            this.Controls.Add(this.comboSupplier);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddtoBill);
            this.Controls.Add(this.txtRequiredQty);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridBill);
            this.Name = "PurchaseFrm";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.PurchaseFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddtoBill;
        private System.Windows.Forms.TextBox txtRequiredQty;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridBill;
        private System.Windows.Forms.ComboBox comboSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}