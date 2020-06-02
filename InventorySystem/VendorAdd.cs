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
    public partial class VendorAdd : Form
    {
        public VendorAdd()
        {
            InitializeComponent();
        }
        public Form RefToLogin { get; set; }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand vc = new SqlCommand("INSERT INTO Vendors VALUES('" + AddVendorNameTextBox.Text + "','" + Stocks.Text + "','" + AddEmailTextBox.Text + "'," + AddPhoneNumberTextBox.Text + " ,'" + AddAddressTextBox.Text + "');", conn);
            if (String.IsNullOrEmpty(AddVendorNameTextBox.Text) | String.IsNullOrEmpty(Stocks.Text) | String.IsNullOrEmpty(AddEmailTextBox.Text) | String.IsNullOrEmpty(AddPhoneNumberTextBox.Text) | String.IsNullOrEmpty(AddAddressTextBox.Text))
            {
                MessageBox.Show("Please check that you have inserted the information correctly");
            }
            else
            {
                int n = vc.ExecuteNonQuery();
                MessageBox.Show(n + " Vendor's Detail has been added");
                conn.Close();
                this.Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddVendorLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VendorNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddVendorNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VendorAdd_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Stocks_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
