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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        public Form RefToLogin { get; set; }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddNewCustomer_Click(object sender, EventArgs e)
        {
            CustomersAdd cta = new CustomersAdd();
            cta.RefToCustomers = this;
            cta.Show();
        }
        public void RefreshGrid()
        {
            
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            RefToLogin.Show();
        }
        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            DashBoard DashBoardLink = new DashBoard();
            DashBoardLink.Show();
            DashBoardLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void StocksButton_Click(object sender, EventArgs e)
        {
            Stocks StockLink = new Stocks();
            StockLink.Show();
            StockLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void VendorsButton_Click(object sender, EventArgs e)
        {
            Vendors VendorLink = new Vendors();
            VendorLink.Show();
            VendorLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.customersDataSet.Customers);



        }

        private void CustomersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchForCustomerButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ken\Desktop\Com_sci\SWE20001\DHD\InventoryManagementSystem\InventorySystem\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand vc = new SqlCommand("Select Count(*) From Customers where First_Name ='" + CustomerSearchTextBox.Text + "' or Surname = '" + CustomerSearchTextBox.Text + "' or Address ='" + CustomerSearchTextBox.Text + "'", conn);
            int n = vc.ExecuteNonQuery();
            MessageBox.Show(n + " Customer has been searched");
            conn.Close();
        }
    }
}
