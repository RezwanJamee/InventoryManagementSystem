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
    public partial class Stocks : Form
    {
        public Stocks()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");
        private void Stocks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataBaseFixed.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter1.Fill(this.stockDataBaseFixed.Stocks);
            // TODO: This line of code loads data into the 'stocksDataSet.Stocks' table. You can move, or remove it, as needed.
            /*this.stocksTableAdapter.Fill(this.stocksDataSet.Stocks);
            // TODO: This line of code loads data into the 'stocksDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.stocksDataSet.Stocks);
            // TODO: This line of code loads data into the 'testDevPDataSet1.Stocks' table. You can move, or remove it, as needed.
            // this.stocksTableAdapter.Fill(this.testDevPDataSet1.Stocks);*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Stock BUtton
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            DashBoard DashBoardLink = new DashBoard();
            DashBoardLink.Show();
        }

        public Form RefToLogin { get; set; }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.RefToLogin.Show();
            this.Close();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            Products ProductsLink = new Products();
            ProductsLink.Show();
            ProductsLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void VendorsButton_Click(object sender, EventArgs e)
        {
            Vendors VendorLink = new Vendors();
            VendorLink.Show();
            VendorLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Customers ct = new Customers();
            ct.RefToLogin = this.RefToLogin;
            ct.Show();
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            DashBoard DashBoardLink = new DashBoard();
            DashBoardLink.Show();
            DashBoardLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void AddNewStocks_Click(object sender, EventArgs e)
        {
            StocksAdd sa = new StocksAdd();
            sa.Show();
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "SELECT * FROM Stocks";
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            StocksGridView.DataSource = dt;
            conn.Close();
        }

        private void StocksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
