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

       // public Form RefToLogin { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)// Sidebar Dashboard Button
        {
            this.Close();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            Stocks StockLink = new Stocks();
            StockLink.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

            LoginPage LoginLink = new LoginPage();
            LoginLink.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Products ProductLink = new Products();
            ProductLink.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            Vendors VendorLink  = new Vendors();
            VendorLink.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

            Customers CustomerLink = new Customers();
            CustomerLink.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

            Edit_Credentials EDC = new Edit_Credentials();
            EDC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Graph G = new Graph();
            G.Show();
        }
    }
}
