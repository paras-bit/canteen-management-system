namespace CanteenManagement
{
    partial class ReportAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxTableSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetRecords = new System.Windows.Forms.Button();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTableSelect
            // 
            this.comboBoxTableSelect.FormattingEnabled = true;
            this.comboBoxTableSelect.Items.AddRange(new object[] {
            "Purchase",
            "Sales"});
            this.comboBoxTableSelect.Location = new System.Drawing.Point(22, 38);
            this.comboBoxTableSelect.Name = "comboBoxTableSelect";
            this.comboBoxTableSelect.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTableSelect.TabIndex = 217;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 216;
            this.label2.Text = "Select Bill Type";
            // 
            // btnGetRecords
            // 
            this.btnGetRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.btnGetRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRecords.ForeColor = System.Drawing.Color.White;
            this.btnGetRecords.Location = new System.Drawing.Point(516, 86);
            this.btnGetRecords.Name = "btnGetRecords";
            this.btnGetRecords.Size = new System.Drawing.Size(120, 30);
            this.btnGetRecords.TabIndex = 218;
            this.btnGetRecords.Text = "Get Records";
            this.btnGetRecords.UseVisualStyleBackColor = false;
            this.btnGetRecords.Click += new System.EventHandler(this.btnGetRecords_Click);
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToResizeRows = false;
            this.dataGridViewRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecords.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(239)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRecords.ColumnHeadersHeight = 25;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRecords.EnableHeadersVisualStyles = false;
            this.dataGridViewRecords.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(63)))));
            this.dataGridViewRecords.Location = new System.Drawing.Point(140, 162);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.dataGridViewRecords.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRecords.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRecords.RowTemplate.Height = 23;
            this.dataGridViewRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecords.Size = new System.Drawing.Size(595, 224);
            this.dataGridViewRecords.TabIndex = 219;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.lblGrandTotal.Location = new System.Drawing.Point(352, 418);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(23, 25);
            this.lblGrandTotal.TabIndex = 220;
            this.lblGrandTotal.Text = "0";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(22, 96);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 221;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(272, 96);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 222;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 223;
            this.label1.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 224;
            this.label3.Text = "End Date";
            // 
            // ReportAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 452);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.dataGridViewRecords);
            this.Controls.Add(this.btnGetRecords);
            this.Controls.Add(this.comboBoxTableSelect);
            this.Controls.Add(this.label2);
            this.Name = "ReportAdmin";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTableSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetRecords;
        private System.Windows.Forms.DataGridView dataGridViewRecords;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}