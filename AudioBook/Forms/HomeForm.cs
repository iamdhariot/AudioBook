using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;
using System.Speech.Synthesis;
using System.Media;

namespace audiobook
{
    public partial class HomeForm : Form
    {
        SpeechSynthesizer read2;
        public HomeForm()
        {
            InitializeComponent();
            

        }
        //text to speech 
        private void ENTER_Click(object sender, EventArgs e)
        {
            read2.SpeakAsyncCancelAll();
            ENTER.Enabled = false;
            this.Hide();
            TextToSpeechForm f2 = new TextToSpeechForm();
            f2.ShowDialog();
            
        }
        //speech to text
        private void button1_Click(object sender, EventArgs e)
        {
            read2.SpeakAsyncCancelAll();
         
            button1.Enabled = false;
            this.Hide();
            SpeechToTextForm F3 = new SpeechToTextForm();
            F3.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            ENTER.Enabled = true;
            read2 = new SpeechSynthesizer();
            read2.Rate = -1;
            read2.Volume = 100;

            read2.SpeakAsync("Welcome! to Audiobook!!i am a speech based software!.i can convert speech to text! and also text to speech!.you can use my function by using following Enter buttons! and  if you want to know about My group member!, then you can click about us button!!  ");
           
        

           
   

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

      
       

        private void AboutUs_Click(object sender, EventArgs e)
        {
            read2.SpeakAsyncCancelAll();
            this.Hide();
            AboutUsForm f4 = new AboutUsForm();
            f4.ShowDialog();
            

        }
        //EXIT
        private void Help_Click(object sender, EventArgs e)
        {

            read2.SpeakAsyncCancelAll();
            SystemSounds.Asterisk.Play();
            DialogResult dr = MessageBox.Show("Are you sure to exit ?", "Message", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

       
    }
}
