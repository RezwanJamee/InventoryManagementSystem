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
    public partial class ProductsAdd : Form
    {
        public ProductsAdd()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand vc = new SqlCommand("INSERT INTO Products (Product_Name, Price_per_Product) VALUES('" + AddProductTextBox.Text + "'," + AddPriceTextBox.Text + ");", conn);
            if (String.IsNullOrEmpty(AddProductTextBox.Text) | String.IsNullOrEmpty(AddPriceTextBox.Text))
            {
                MessageBox.Show("Please check that you have inserted the information correctly");
            }
            else
            {
                int n = vc.ExecuteNonQuery();
                MessageBox.Show(n + " Product Detail has been added");
                conn.Close();
                this.Close();
            }
        }

        private void ProductsAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
