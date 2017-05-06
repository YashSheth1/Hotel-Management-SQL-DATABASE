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
    public partial class Guest_login : Form
    {
        public Guest_login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            booking_main bk = new booking_main();
            this.Hide();
            bk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //booking_main bk = new booking_main();
            customer_menu cm = new customer_menu();
            cm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
