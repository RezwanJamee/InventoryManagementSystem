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
    public partial class CustomersAdd : Form
    {
        public CustomersAdd()
        {
            InitializeComponent();
        }


        public Form RefToLogin { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomersAdd_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO Customers VALUES('" + AddFirstNameTextBox.Text + "','" + AddSurnameTextBox.Text + "' ,'" + Addstocks_textbox.Text + "' ,'" + AddPhoneNumberTextBox.Text + "' ,'" + AddEmailTextBox.Text + "','" + AddAddressTextBox.Text + "');", conn);
            if (String.IsNullOrEmpty(AddFirstNameTextBox.Text) | String.IsNullOrEmpty(AddSurnameTextBox.Text) | String.IsNullOrEmpty(AddPhoneNumberTextBox.Text.ToString()) | String.IsNullOrEmpty(AddEmailTextBox.Text) | String.IsNullOrEmpty(AddAddressTextBox.Text))
            {
                MessageBox.Show("Please check that you have inserted the information correctly");
            }
            else
            {
                int n = sc.ExecuteNonQuery();// need to change the query so that i can accept the stock table as well
                MessageBox.Show(n + " Customer's Detail has been added");
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

        private void AddCustomerLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSurnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
