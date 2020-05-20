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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDevPDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.testDevPDataSet1.Products);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            DashBoard DashBoardLink = new DashBoard();
            DashBoardLink.Show();
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
    }
}
