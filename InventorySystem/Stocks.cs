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
            // TODO: This line of code loads data into the 'stocksDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.stocksDataSet.Stocks);
            // TODO: This line of code loads data into the 'testDevPDataSet1.Stocks' table. You can move, or remove it, as needed.
            // this.stocksTableAdapter.Fill(this.testDevPDataSet1.Stocks);

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
            ////Products ProductsLink = new Products();
            //ProductsLink.Show();
            //ProductsLink.RefToLogin = this.RefToLogin;
            //this.Close();
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
    }
}
