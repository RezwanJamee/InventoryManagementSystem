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
            // this.vendorsTableAdapter.Fill(this.testDevPDataSet1.Vendors);

        }



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
            //Products ProductsLink = new Products();
            //ProductsLink.Show();
            //ProductsLink.RefToLogin = this.RefToLogin;
            //this.Close();
        }
        public Form RefToLogin { get; set; }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.RefToLogin.Show();
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
    }
}
