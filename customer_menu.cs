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
    public partial class customer_menu : Form
    {
        public customer_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orders o = new orders();
            o.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Show();
        }

        private void customer_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
