using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Graphs : Form
    {
        public Graphs()
        {
            InitializeComponent();
        }

        public Form RefToLogin { get; set; }
        private void Graphs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productsTable.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.productsTable.Products);
            // TODO: This line of code loads data into the 'customerTable.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter2.Fill(this.customerTable.Customers);
            // TODO: This line of code loads data into the 'test_DatabaseDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.test_DatabaseDataSet1.Customers);
            // TODO: This line of code loads data into the 'vendorsUpdated.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter1.Fill(this.vendorsUpdated.Vendors);
            // TODO: This line of code loads data into the 'productsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productsDataSet.Products);
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);
            // TODO: This line of code loads data into the 'vendorsDataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.vendorsDataSet.Vendors);
            // TODO: This line of code loads data into the 'stockDataBaseFixed.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.stockDataBaseFixed.Stocks);

        }

        private void SideBtn_Dashboard_Click(object sender, EventArgs e)
        {
            DashBoard DB = new DashBoard();
            DB.Show();
            DB.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginPage LP = new LoginPage();
            LP.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products ProductsLink = new Products();
            ProductsLink.Show();
            ProductsLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stocks StockLink = new Stocks();
            StockLink.Show();
            StockLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vendors VendorLink = new Vendors();
            VendorLink.Show();
            VendorLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Customers ct = new Customers();
            ct.RefToLogin = this.RefToLogin;
            ct.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Graphs GraphLink = new Graphs();
            GraphLink.Show();
            this.Close();*/
        }
    }
}
