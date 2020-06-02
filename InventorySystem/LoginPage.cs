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
using System.IO;
using System.Data.Entity;

namespace InventorySystem
{
    public partial class LoginPage : Form
    {
        int count = 0;

        public LoginPage()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");
            // Counts how many matches
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username ='" + UsernameInput.Text + "' and Password = '" + PasswordInput.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //if it doesn't match then it won't log in.
            if (dt.Rows[0][0].ToString() == "1" && count <= 5)
            {
                PasswordInput.Text = String.Empty;
                this.Hide();
                DashBoard db = new DashBoard();
                db.RefToLogin = this;
                this.Visible = false;
                db.Show();
            }
            else if (count <= 5)
            {
                MessageBox.Show("Please Check your Username and Password!");
                count += 1;
            }
            else
            {
                MessageBox.Show("You have been locked out, please contact admin");
            }
        }

        public char PasswordChar { get; set; }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            PasswordInput.PasswordChar = '*';
        }
    }
}
