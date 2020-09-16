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
    public partial class AboutTextToSpeechForm : Form
    {
        SpeechSynthesizer read1 = new SpeechSynthesizer();
        public AboutTextToSpeechForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }
       

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text ="TTS stands for Text-to-Speech (also written as Text to Speech) – a form of speech synthesis that converts text into voice output. Text-To-Speech software basically takes the text you write and turns it into speech files that you can use. From text to speech – nice and simple.Text to speech, abbreviated as TTS, is a form of speech synthesis that converts text into spoken voice output. Text to speech systems were first developed to aid the visually impaired by offering a computer-generated spoken voice that would read text to the user.";
           textBox2.Text = "A speech synthesizer takes text as input and produces an audio stream as output.Speech synthesis is also referred to as text-to-speech (TTS).A synthesizer must perform substantial analysis and processing to accurately convert a string of characters into an audio stream that sounds just as the words would be spoken.The easiest way to imagine how this works is to picture the front end and back end of a two-part system.\n\n Text Analysis :- \n\nThe front end specializes in the analysis of text using natural language rules.It analyzes a string of characters to determine where the words are (which is easy to do in English, but not as easy in languages such as Chinese and Japanese). This front end also figures out grammatical details like functions and parts of speech.Sound Generation:-The back end has quite a different task. It takes the analysis done by the front end and, through some non-trivial analysis of its own, generates the appropriate sounds for the input text.Older synthesizers generate the individual sounds algorithmically, resulting in a very robotic sound.";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }
        //READ TEXTBOX 1
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button4.Enabled = true;
            read1.SpeakAsync(textBox1.Text);
            
        }
        //STOP READ TEXTBOX 1 
        private void button4_Click(object sender, EventArgs e)
        {
            read1.SpeakAsyncCancelAll();
            button1.Enabled = true;
            button4.Enabled = false;
        }
        //READ TEXTBOX 2
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = true;
            read1.SpeakAsync(textBox2.Text);
        }
        //STOP READ TEXTBOX 2
        private void button2_Click(object sender, EventArgs e)
        {
            read1.SpeakAsyncCancelAll();
            button3.Enabled = true;
            button2.Enabled = false;

        }
        //HOME STRIP
        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
             read1.SpeakAsyncCancelAll();
            this.Hide();
            HomeForm f1 = new HomeForm();
            f1.ShowDialog();
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
        //BACK STRIP
        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextToSpeechForm F2 = new TextToSpeechForm();
            F2.ShowDialog();
        }
     }
}
 

