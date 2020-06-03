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

namespace InventorySystem
{
    public partial class StocksAdd : Form
    {
        public StocksAdd()
        {
            InitializeComponent();
        }
        
        private void SubmitButton_Click(object sender, EventArgs e)
        {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand vc = new SqlCommand("INSERT INTO Stocks (Vendor_Name, Product_Name, Stock) VALUES('" + AddVendorNameTextBox.Text + "','" + AddProductTextBox.Text + "'," + AddStocksTextBox.Text + ");", conn);
            if (String.IsNullOrEmpty(AddVendorNameTextBox.Text) | String.IsNullOrEmpty(AddProductTextBox.Text) | String.IsNullOrEmpty(AddStocksTextBox.Text))
            {
                MessageBox.Show("Please check that you have inserted the information correctly");
            }
            else
            {
                int n = vc.ExecuteNonQuery();
                MessageBox.Show(n + " Stocks's Detail has been added");
                conn.Close();
                this.Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddProductTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStocksLabel_Click(object sender, EventArgs e)
        {

        }

        private void StocksLabel_Click(object sender, EventArgs e)
        {

        }

        private void VendorNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddStocksTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddVendorNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StocksAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
