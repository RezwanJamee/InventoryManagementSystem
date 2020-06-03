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
    public partial class Vendors : Form
    {
        public Vendors()
        {
            InitializeComponent();
        }

        private void Vendors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendorsUpdated.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter2.Fill(this.vendorsUpdated.Vendors);
            // TODO: This line of code loads data into the 'test_DatabaseDataSet1.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.test_DatabaseDataSet1.Vendors);
            // TODO: This line of code loads data into the 'vendorsDataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter1.Fill(this.vendorsDataSet.Vendors);

        }


        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");
        private void button4_Click(object sender, EventArgs e)
        {

        }




        private void StockButton_Click(object sender, EventArgs e)
        {
            Stocks StockLink = new Stocks();
            StockLink.Show();
            StockLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            Products ProductsLink = new Products();
            ProductsLink.Show();
            ProductsLink.RefToLogin = this.RefToLogin;
            this.Close();
        }
        public Form RefToLogin { get; set; }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginPage LP = new LoginPage();
            LP.Show();
            this.Close();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Customers ct = new Customers();
            ct.RefToLogin= this.RefToLogin;
            ct.Show();
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            DashBoard DashBoardLink = new DashBoard();
            DashBoardLink.Show();
            DashBoardLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void AddNewVendor_Click(object sender, EventArgs e)
        {
            VendorAdd av = new VendorAdd();
            av.Show();
            av.RefToLogin = this.RefToLogin;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            VendorsGridView.Update();
        }

        private void Refreshbutton_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            String query = "SELECT * FROM Vendors";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            VendorsGridView.DataSource = dt;
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphs GraphLink = new Graphs();
            GraphLink.Show();
            GraphLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Edit_Credentials Change_Pass = new Edit_Credentials();
            Change_Pass.Show();
            this.Close();
        }
    }
}
