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
    public partial class Diljot_s_Stocks : Form
    {
        public Diljot_s_Stocks()
        {
            InitializeComponent();
        }

        private void Diljot_s_Stocks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDevPDataSet1.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.testDevPDataSet1.Stocks);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
