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
using Microsoft.SqlServer.Server;

namespace InventorySystem
{
    public partial class Edit_Credentials : Form
    {
        public Edit_Credentials()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//save button
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diljo\OneDrive - Swinburne University\Sem03\Tools and Practices\Distinction project\Resorces code\InventorySystem\Password_Username_Test_V02.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Login SET Password = '" + Password_textfield.Text + "' Where Username = '" + Username_textfield.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Password successfully updated");

            DashBoard Updated_DB = new DashBoard();
            this.Close();
            Updated_DB.Show();


            // Counts how many matches
            //SqlDataAdapter sda = new SqlDataAdapter("Update {Login} SET {Password} = " + Password_textfield.Text + " Where {Username} =" + Username_textfield.Text + "", con);


            //SqlDataAdapter sdachk = new SqlDataAdapter("Select * from Login where Username = '" + Username_textfield.Text + "' and Password = '" + Password_textfield.Text + "'", con);


            /*  DataTable dt = new DataTable();
              sdachk.Fill(dt);


             if (dt.Rows[0][0].ToString() == "1")
              {
                  MessageBox.Show("Password successfully updated");

                  this.Hide();
                  DashBoard db = new DashBoard();
                  db.Show();
              }
              else
              {
                  MessageBox.Show("There might be someproblem updating your password! please check your username and try again");
              }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//username textfield
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//password field
        {

        }

        private void Edit_Credentials_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'password_Username_Test_V02DataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.password_Username_Test_V02DataSet.Login);

        }
    }
}
