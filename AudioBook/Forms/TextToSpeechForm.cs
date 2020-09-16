using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;
using System.Media;
namespace audiobook
{
    public partial class TextToSpeechForm : Form
    {
        SpeechSynthesizer read;
        public TextToSpeechForm()
        {
            InitializeComponent();
        }

        private void form2_Load(object sender, EventArgs e)
        {
           read = new SpeechSynthesizer();
           read.Rate = -1;
           read.Volume = 100;
           read.SpeakAsync("Here!! You can write text in the textbox! or browse text file! then! i read the text for you!");

           pause.Enabled = false;
           resume.Enabled = false;
           replay.Enabled = false;
           stop.Enabled = false;
          
        }
     
        //LOAD TEXT FILE  
        private void load_Click(object sender, EventArgs e)
        {
            
         
            OpenFileDialog openFile1 = new OpenFileDialog();
           openFile1.Filter = "Text Files|*.txt";
            

            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               
               

                richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
               
                if (richTextBox1.Text != "")
                {
                  
                    read.SpeakAsync(richTextBox1.Text);
                    label2.Text = "SPEAKING";
                    stop.Enabled = true;
                    pause.Enabled = true;
                  
                }
            
            }
            
            
        }
     
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //box
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //speak
        private void speak_Click(object sender, EventArgs e)
        {
            read.Dispose();
            if (richTextBox1.Text != "")
            {
                read = new SpeechSynthesizer();
                
                read.SpeakAsync(richTextBox1.Text);
                label2.Text = "SPEAKING";
                stop.Enabled = true;
                pause.Enabled = true;
                replay.Enabled = true;
                read.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(read_SpeakCompleted);
                
                    

            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Please..! Enter some text in the textbox","Message",MessageBoxButtons.OK);
               
            }
        }
        void read_SpeakCompleted(object sender,SpeakCompletedEventArgs e)
        {
            if (label2.Text == "SPEAKING")
            {
                label2.Text = "IDLE";
            }
            else
            { 
                label2.Text = "SPEAKING";
            }
        }
        //pause
        private void pause_Click(object sender, EventArgs e)
        {
            if (read != null)
            {
                if (read.State==SynthesizerState.Speaking)
                {
                    read.Pause();
                    label2.Text = "PAUSE";
                    resume.Enabled = true;
                    stop.Enabled = true;
                    pause.Enabled = false;
                    speak.Enabled = true;
                    replay.Enabled = true;
                    

                }
            }
          
          

        }
        //resume
        private void resume_Click(object sender, EventArgs e)
        {
            if (read != null)
            {
                if(read.State==SynthesizerState.Paused)
                {
                    read.Resume();
                    label2.Text = "SPEAKING";
                }
                pause.Enabled = true;
                resume.Enabled = false;
                replay.Enabled = true;
                stop.Enabled = true;
                speak.Enabled = true;
            }

        }
        //replay
        private void replay_Click(object sender, EventArgs e)
        {
            
           
            if (read !=null)
            {
           
               
                read.SpeakAsync(richTextBox1.Text);
               
                replay.Enabled = true;
                stop.Enabled = true;
                pause.Enabled = true;
                
                resume.Enabled = false;
                speak.Enabled = true;
                
                
               
            }
            label2.Text = "SPEAKING";
               
            

        }
        //stop 
        private void stop_Click(object sender, EventArgs e)
        {
            if(read !=null)
            {
                read.Dispose();
                label2.Text = "IDLE";
                speak.Enabled = true;
                pause.Enabled = false;
                replay.Enabled = false;
                resume.Enabled = false;
                richTextBox1.Clear();
            }
        }
        //status
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        //HOME STRIP
        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            read.Dispose();
            this.Hide();
            HomeForm f1 = new HomeForm();
            f1.ShowDialog();

        }
        //ABOUT STRIP
        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            read.Dispose();
            this.Hide();
            AboutTextToSpeechForm f5 = new AboutTextToSpeechForm();
            f5.Show();
            

        }
        //EXIT STRIP
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {

            read.Dispose();
            SystemSounds.Asterisk.Play();
            DialogResult dr = MessageBox.Show("Are you sure to exit?", "Message", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();

            }

        }
           
        
    }
}
