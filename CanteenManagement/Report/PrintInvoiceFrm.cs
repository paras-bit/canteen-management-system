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
using Microsoft.Reporting.WinForms;

namespace CanteenManagement.Report
{
    public partial class PrintInvoiceFrm : Form
    {
        int invoiceId;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\CanteenManagement\CanteenManagement\CanteenDB.mdf;Integrated Security=True;Connect Timeout=30");
        public PrintInvoiceFrm(int id)
        {
            invoiceId = id;
            InitializeComponent();
        }

        private void PrintInvoiceFrm_Load(object sender, EventArgs e)
        {
            print();
            this.reportViewer1.RefreshReport();
        }

        private void print()
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vw_InvoiceDetails WHERE InvoiceId = @InvoiceId", con);
                da.SelectCommand.Parameters.AddWithValue("@InvoiceId", invoiceId);

                DataSet1 ds = new DataSet1();
                da.Fill(ds, "DataTable_Invoice");


                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
