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
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Products ProductsD = new Products();
            ProductsD.Show();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'password_Username_Test_V02DataSet2.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.password_Username_Test_V02DataSet2.Products);
            this.Products_Graph.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            // TODO: This line of code loads data into the 'password_Username_Test_V02DataSet2.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.password_Username_Test_V02DataSet2.Customer);
            this.Customers_Graph.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            // TODO: This line of code loads data into the 'password_Username_Test_V02DataSet2.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.password_Username_Test_V02DataSet2.Vendors);
            this.Vendors_Graph.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            // TODO: This line of code loads data into the 'password_Username_Test_V02DataSet1.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.password_Username_Test_V02DataSet1.Stocks);
            this.Stocks_Graph.ChartAreas["ChartArea1"].AxisX.Interval = 1;
        }

        private void SideBtn_Dashboard_Click(object sender, EventArgs e)
        {
            this.Close();

            DashBoard db = new DashBoard();
            db.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            Vendors VendorD = new Vendors();
            VendorD.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

            Customers CustomerD = new Customers();
            CustomerD.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            Stocks StocksD = new Stocks();
            StocksD.Show();
        }
    }
}
