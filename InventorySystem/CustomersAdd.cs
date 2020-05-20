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
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ken\Desktop\Com_sci\SWE20001\DHD\InventoryManagementSystem\InventorySystem\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO Customers VALUES('" + AddFirstNameTextBox.Text + "','" + AddSurnameTextBox.Text + "' ," + AddPhoneNumberTextBox.Text + " ,'" + AddEmailTextBox.Text + "','" + AddAddressTextBox.Text + "');", conn);
            int n = sc.ExecuteNonQuery();
            MessageBox.Show(n + " Customer's Detail has been added");
            conn.Close();
            Customers ct = new Customers();
            ct.RefToLogin = this.RefToLogin;
            ct.Show();
            this.Close();
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
    }
}
