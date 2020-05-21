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
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ken\Desktop\Com_sci\SWE20001\DHD\InventoryManagementSystem\InventorySystem\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand vc = new SqlCommand("INSERT INTO Products (Product_Name, Price_per_Product) VALUES('" + AddProductTextBox.Text + "'," + AddPriceTextBox.Text + ");", conn);
            int n = vc.ExecuteNonQuery();
            MessageBox.Show(n + " Product Detail has been added");
            conn.Close();
            this.Close();
        }
    }
}
