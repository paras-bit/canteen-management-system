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
    public partial class dashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\CanteenManagement\CanteenManagement\CanteenDB.mdf;Integrated Security=True;Connect Timeout=30");
        public dashboard()
        {
            InitializeComponent();
            CountCustomers();
            CountItems();
            CountSales();
        }
        private void CountCustomers()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*)from customertbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cust_count.Text = dt.Rows[0][0].ToString();
            con.Close();

        }
        private void CountItems()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*)from itemtbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            item_count.Text = dt.Rows[0][0].ToString();
            con.Close();

        }

        private void CountSales()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(Grand_Total)from Invoice_Master", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sales_count.Text = "Rs " + dt.Rows[0][0].ToString();
            con.Close();

        }

        private void panel_Customer_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase("customertbl");
        }

        private void LoadDataFromDatabase(string tableName)
        {
            try
            {
                con.Open();

                // Query to fetch table data based on the table name passed
                string query = "SELECT * FROM " + tableName;

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                da.Fill(dt);  // Fill the DataTable with data from the database

                // Bind the DataTable to DataGridView
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();  // Ensure connection is closed after operation
            }
        }

        private void panel_Item_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase("itemtbl");

        }

        private void panel_Sales_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase("Invoice_Master");
        }
    }
}