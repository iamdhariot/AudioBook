using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Media;

namespace audiobook
{
    public partial class AboutUsForm : Form
    {
        SpeechSynthesizer read = new SpeechSynthesizer();
        public AboutUsForm()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            read.Rate=-1;
            read.Volume = 100;
            read.SpeakAsync(" About Us!!,hello!! I am audiobook software!!Let's me introduce you my group members!! Dharmendra Gameti!!  Chirag Lohar!!  , Nafeesh Haider!! and the last one is Sharvan Sigdel!!, My group!,aim is to make dreams true!!!  You dream it , we make it. ");
        }

        private void ovalShape3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm f1 = new HomeForm();
            f1.Show();
            read.SpeakAsyncCancelAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            read.SpeakAsyncCancelAll();
            SystemSounds.Asterisk.Play();
            DialogResult dr = MessageBox.Show("Are you sure to exit?", "Message", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
