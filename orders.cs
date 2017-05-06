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
using System.Data.Sql;

namespace HotelMGMT
{
    public partial class orders : Form
    {
        
        public orders()
        {
            InitializeComponent();
        }

        private void orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelMGMTDataSet2.menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.hotelMGMTDataSet2.menu);
            // TODO: This line of code loads data into the 'hotelMGMTDataSet1.temp_orders' table. You can move, or remove it, as needed.
            this.temp_ordersTableAdapter.Fill(this.hotelMGMTDataSet1.temp_orders);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total bill amout is:");
            MessageBoxButtons.YesNo.Equals(4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.Hide();
            //dataGridView1.Show();
            dataGridView1.Refresh();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
