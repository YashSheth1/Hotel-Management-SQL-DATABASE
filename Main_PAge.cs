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
    public partial class Main_Page : Form
    {
        //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Main_Page()
        {
            InitializeComponent();
          //  player.SoundLocation = "horn.wav";
            //player.Play();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_Page cmain = new Main_Page();
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            kitchen k = new kitchen();
            this.Hide();
            k.Show();

        }
    }
}
