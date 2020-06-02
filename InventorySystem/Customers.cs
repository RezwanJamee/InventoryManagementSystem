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
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");
        public Form RefToLogin { get; set; }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddNewCustomer_Click(object sender, EventArgs e)
        {
            CustomersAdd cta = new CustomersAdd();
            cta.RefToLogin = this.RefToLogin;
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
            // TODO: This line of code loads data into the 'customerTable.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customerTable.Customers);
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.customersDataSet.Customers);



        }

        private void CustomersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchForCustomerButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand vc = new SqlCommand("Select Count(*) From Customers where First_Name ='" + CustomerSearchTextBox.Text + "' or Surname = '" + CustomerSearchTextBox.Text + "' or Address ='" + CustomerSearchTextBox.Text + "'", conn);
            int n = vc.ExecuteNonQuery();
            MessageBox.Show(n + " Customer has been searched");
            conn.Close();
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "SELECT * FROM Customers";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            CustomersGridView.DataSource = dt;
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphs GraphLink = new Graphs();
            GraphLink.RefToLogin = this.RefToLogin;
            GraphLink.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Edit_Credentials Change_Pass = new Edit_Credentials();
            Change_Pass.Show();
            this.Close();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
