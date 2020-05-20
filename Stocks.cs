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
    public partial class Stocks : Form
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDevPDataSet1.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.testDevPDataSet1.Stocks);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Products ProductsLink = new Products();
            ProductsLink.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            DashBoard DashBoardLink = new DashBoard();
            DashBoardLink.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Vendors VendorLink = new Vendors();
            VendorLink.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Customers CustomerLink = new Customers();
            CustomerLink.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginPage LoginLink = new LoginPage();
            LoginLink.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
