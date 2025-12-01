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
    public partial class ReportAdmin : Form
    {
        public ReportAdmin()
        {
            InitializeComponent();
        }

        private void btnGetRecords_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            
            string selectedTable = comboBoxTableSelect.SelectedItem.ToString();

            
            string query = "";
            if (selectedTable == "Purchase")
            {
                query = @"
                SELECT 
                    p.PurchaseID, p.PurchaseDate, p.GrandTotal, s.SName
                FROM purchasetbl p
                INNER JOIN suppliertbl s ON p.SupplierID = s.Id
                WHERE p.PurchaseDate BETWEEN @StartDate AND @EndDate;";
            }
            else if (selectedTable == "Sales")
            {
                query = @"
                SELECT 
                    i.InvoiceId, i.InvoiceDate, i.Grand_Total, i.Cust_Name
                FROM Invoice_Master i
                WHERE i.InvoiceDate BETWEEN @StartDate AND @EndDate;";
            }

            
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\CanteenManagement\CanteenManagement\CanteenDB.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    
                    adapter.Fill(dataTable);

                    
                    dataGridViewRecords.DataSource = dataTable;

                    
                    decimal grandTotal = 0;
                    if (selectedTable == "Purchase")
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            grandTotal += Convert.ToDecimal(row["GrandTotal"]);
                        }
                    }
                    else if (selectedTable == "Sales")
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            grandTotal += Convert.ToDecimal(row["Grand_Total"]);
                        }
                    }

                    lblGrandTotal.Text = "Grand Total: " + grandTotal.ToString("C2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
