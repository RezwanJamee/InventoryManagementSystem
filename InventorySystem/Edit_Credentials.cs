using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Edit_Credentials : Form
    {
        public Edit_Credentials()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Test_Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {

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
        }

        private void Edit_Credentials_Load(object sender, EventArgs e)
        {

        }

        private void Password_textfield_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
