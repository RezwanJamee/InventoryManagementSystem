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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diljo\OneDrive - Swinburne University\Sem03\Tools and Practices\Distinction project\Resorces code\InventorySystem\Password_Username_Test_V02.mdf; Integrated Security = True; Connect Timeout = 30");
            
            // Counts how many matches
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username ='" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //if it doesn't match then it won't log in.
            if (dt.Rows[0][0].ToString() == "1")
            {
                textBox2.Text = String.Empty;
                this.Hide();
                DashBoard db = new DashBoard();
               // db.RefToLogin = this;
               // this.Visible = false;
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Check your Username and Password!");
            }

          
        }
    }
}
