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

        public Form RefToCustomers { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomersAdd_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ken\Desktop\Com_sci\SWE20001\DHD\InventorySystem\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO Customers VALUES('" + AddFirstNameTextBox.Text + "','" + AddSurnameTextBox.Text + "' ," + AddPhoneNumberTextBox.Text + " ,'" + AddAddressTextBox.Text + "');",conn);
            int n = sc.ExecuteNonQuery();
            MessageBox.Show(n + " Customer's Detail has been added");
            conn.Close();
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
