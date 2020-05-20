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
    public partial class Vendors : Form
    {
        public Vendors()
        {
            InitializeComponent();
        }

        private void Vendors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDevPDataSet1.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.testDevPDataSet1.Vendors);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            DashBoard DashBoardLink = new DashBoard();
            DashBoardLink.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Products ProductLink = new Products();
            ProductLink.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Stocks StockLink = new Stocks();
            StockLink.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
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
    }
}
