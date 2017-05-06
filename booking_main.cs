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
    public partial class booking_main : Form
    {
        public static int children;
        public static int adult;
        public static int room;
        public static int opt_cat;
        public static int opt_type;


        public booking_main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\Users\MAHE\Downloads\6.gif");
            Bitmap f = new Bitmap(pictureBox1.Image,pictureBox1.Width,pictureBox1.Height);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.Image = f;
            pictureBox1.Show();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Enabled==true)
            {
                radioButton2.Enabled = false;
                radioButton1.Enabled = false;
                opt_type = 3;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            adult = Int32.Parse(comboBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            children = Int32.Parse(comboBox2.Text);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            room = Int32.Parse(comboBox3.Text);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            switch (opt_type)
            {
                case 0:
                    room = Int32.Parse(comboBox1.Text);
                    break;
                case 1:
                    room =Int32.Parse(comboBox1.Text) / 2 + Int32.Parse(comboBox1.Text) % 2;
                    break;
                case 2:
                    if (children <= 2*adult)
                    {
                        room = Int32.Parse(comboBox1.Text) / 2 + Int32.Parse(comboBox1.Text) % 2;
                    }
                    else
                    {
                            room = Int32.Parse(comboBox1.Text) / 2 + Int32.Parse(comboBox1.Text) % 2 + Int32.Parse(comboBox2.Text)/(2*adult)+Int32.Parse(comboBox2.Text)%(2*adult);
                    }
                    break;
               
            }
            if(Int32.Parse(comboBox3.Text)>=room)
            {
                MessageBox.Show("Booking Info Valid [ Moving Forward to Payment ]");
                
                //add payment form link here
            }
            else
            {
                MessageBox.Show("Invalid Values Entered");
                radioButton1.Enabled=true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;

            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Enabled == true)
            {
                radioButton3.Enabled = false;
                radioButton1.Enabled = false;
                opt_type = 2;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled == true)
            {
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                opt_type = 1;

            }
        }
   
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Enabled==true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                opt_cat= 1;

            }

            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Enabled == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                opt_cat = 2;

            }
     
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Enabled == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                opt_cat = 3;
            }
  
        }
    }
}
