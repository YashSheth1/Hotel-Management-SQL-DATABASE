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
    public partial class customer_main : Form
    {
        //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public customer_main()
        {
            InitializeComponent();
          //  player.SoundLocation = "horn.wav";
            //player.Play();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer_main cmain = new customer_main();
            
            Guest_login glogin = new Guest_login();

            glogin.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customer_main_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
