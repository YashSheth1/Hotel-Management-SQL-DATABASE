using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMGMT
{
    public partial class kitchen : Form
    {
        public kitchen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kitchen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelMGMTDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.hotelMGMTDataSet.orders);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
