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
    public partial class AboutSpeechToTextForm : Form
    {
        SpeechSynthesizer read1 = new SpeechSynthesizer();
        public AboutSpeechToTextForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }
       
        private void Form6_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = "Speech-to-text software is a type of software that effectively takes audio content and transcribes it into written words in a word processor or other display destination. This type of speech recognition software is extremely valuable to anyone who needs to generate a lot of written content without a lot of manual typing. It is also useful for people with disabilities that make it difficult for them to use a keyboard.Speech-to-text software may also be known as voice recognition software.";
            textBox2.Text = "Although speech-to-text software is commonly sold as a standalone application,it has also been built into newer operating systems for some devices.Most speech-to-text software programs aimed at assisting with transcription focus on recognizing a wide range of vocabulary from a single user or a limited set of users,rather than recognizing a smaller range of vocabulary from a larger user base.In terms of technical function,many speech-to-text software programs break spoken-word audio down into short samples and associate those samples with simple phonemes or units of pronunciation.Then,complex algorithms sort the results to try to predict the word or phrase that was said.";
       
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }
       
       
        //READ TEXTBOX 1
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button4.Enabled = true;
            read1.SpeakAsync(textBox1.Text);
            
        }
        //STOP READ TEXTBOX 1 
        private void button4_Click_1(object sender, EventArgs e)
        {
            read1.SpeakAsyncCancelAll();
            button1.Enabled = true;
            button4.Enabled = false;
        }
        //READ TEXTBOX 2

        private void button2_Click_1(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button2.Enabled = false;
            read1.SpeakAsync(textBox2.Text);
        }

        
        //STOP READ TEXTBOX 2
        private void button3_Click_1(object sender, EventArgs e)
        {
            read1.SpeakAsyncCancelAll();
            button3.Enabled = false;
            button2.Enabled = true;

        }
        //HOME STRIP
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            read1.SpeakAsyncCancelAll();
            this.Hide();
            HomeForm f1 = new HomeForm();
            f1.ShowDialog();
        }
        //BACK STRIP
        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpeechToTextForm F3 = new SpeechToTextForm();
            F3.ShowDialog();
        }
        //EXIT STRIP
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            read1.SpeakAsyncCancelAll();
            SystemSounds.Asterisk.Play();
            DialogResult dr = MessageBox.Show("Are you sure to exit ?", "Message", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}
