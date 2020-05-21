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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        public Form RefToLogin { get; set; }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ken\Desktop\Com_sci\SWE20001\DHD\InventoryManagementSystem\InventorySystem\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");
        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productsDataSet.Products);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Stocks StockLink = new Stocks();
            StockLink.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Vendors VendorLink = new Vendors();
            VendorLink.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Customers CustomerLink = new Customers();
            CustomerLink.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            LoginPage LoginLink = new LoginPage();
            LoginLink.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            DashBoard DashBoardLink = new DashBoard();
            DashBoardLink.Show();
            DashBoardLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void VendorsButton_Click(object sender, EventArgs e)
        {
            Vendors VendorLink = new Vendors();
            VendorLink.Show();
            VendorLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void CustomersButton(object sender, EventArgs e)
        {
            this.Close();
            Customers ct = new Customers();
            ct.RefToLogin = this.RefToLogin;
            ct.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.RefToLogin.Show();
            this.Close();
        }

        private void StockButton_Click(object sender, EventArgs e)
        {
            Stocks StockLink = new Stocks();
            StockLink.Show();
            StockLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            ProductsAdd PA = new ProductsAdd();
            PA.Show();
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "SELECT * FROM Products";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            ProductsGridView.DataSource = dt;
            conn.Close();
        }
    }
}
