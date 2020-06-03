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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        public Form RefToLogin { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginPage LP = new LoginPage();
            LP.Show();
            this.Close();

        }

        private void GoToCustomersButton_Click(object sender, EventArgs e)
        {
            Customers ct = new Customers();
            ct.RefToLogin = this.RefToLogin;
            ct.Show();
            this.Close();
        }

        private void StockButton_Click(object sender, EventArgs e)
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

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            Products ProductsLink = new Products();
            ProductsLink.Show();
            ProductsLink.RefToLogin = this.RefToLogin;
             this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Edit_Credentials Change_Pass = new Edit_Credentials();
            Change_Pass.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphs GraphLink = new Graphs();
            GraphLink.Show();
            GraphLink.RefToLogin = this.RefToLogin;
            this.Close();
        }

        private void CustomerNo2_Click(object sender, EventArgs e)
        {

        }
    }
}
