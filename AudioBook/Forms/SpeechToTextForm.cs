using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Media;
using System.IO;

namespace audiobook
{
    public partial class SpeechToTextForm : Form
    {
       
           SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-GB"));
        SpeechSynthesizer read1 = new SpeechSynthesizer();
        

           DictationGrammar defaultDictationGrammar = new DictationGrammar();
           DictationGrammar spellingDictationGrammar = new DictationGrammar("grammar:dictation#spelling");
           DictationGrammar customDictationGrammar = new DictationGrammar("grammar:dictation");
            
        public SpeechToTextForm()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
          
            read1.SelectVoiceByHints(VoiceGender.Male,VoiceAge.Teen);
            read1.SpeakAsync("Here! you can speak any kind of english word! or sentence! and then i will write the text for you in the textbox!!.  ");
       }
      
       //stop listening
        private void stop_Click(object sender, EventArgs e)
        {
           
            
            recognizer.UnloadAllGrammars();
            label2.Text = "STOP LISTENING";
            start.Enabled = true;
            read.Enabled = true;
            reset.Enabled = true;
            stop.Enabled = false;
           
           

        

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //start listening
        private void start_Click(object sender, EventArgs e)
        {
            Choices clist = new Choices();
            clist.Add("How are you ","what are you doing ","what can you do for me","help me","who are you ","what is it ","do you know me","computer science","today is wednesday","what do you want","why you are here","why i use you","you are so good","thank you","hello sir","hello ma'am","what are you doing","i am a king","it is a mango","may i help you","no thanks","god bless you","how old are you","tomarrow is ","i beg to say that","because","most respectifully","i am ill","i am a student of ss college of enginnering","my branch is computer science","myself dharmendra","i am dipesh","i am computer","how can i assist you","good morning","morning","good evening","evening","Good night","night","i am fine","two","how can i help you","man","woman","the sun","india","i am football player","i am a player","read","i am a software","hello","hi","hey","welcome","my","i am","zero","love","kill you","artificial intelligence","database","connection","my home","sunny","sum","add","book","i","ma'am ","and","i am a worker","i am a student");
            GrammarBuilder gb = new GrammarBuilder(clist);
            Grammar gr = new Grammar(gb);
            start.Enabled = false;
            stop.Enabled = true;
            reset.Enabled = true;
            read.Enabled = true;
            label2.Text = "LISTENING";
         // Create a default dictation grammar.
            defaultDictationGrammar.Name = "default dictation"; 
            defaultDictationGrammar.Enabled = true;
            
            // Create the spelling dictation grammar.
             spellingDictationGrammar.Name = "spelling dictation";
            spellingDictationGrammar.Enabled = true;

            // Create the question dictation grammar.
            customDictationGrammar.Name = "question dictation";
            customDictationGrammar.Enabled = true;
          
            // Create a SpeechRecognitionEngine object and add the grammars to it.
            try
            {
                         
                recognizer.LoadGrammar(defaultDictationGrammar);
                recognizer.LoadGrammar(spellingDictationGrammar);
                recognizer.LoadGrammar(customDictationGrammar);
                recognizer.LoadGrammar(gr);  
                //Add a context to customDictationGrammar.
                customDictationGrammar.SetDictationContext("hello", "how are you");
                customDictationGrammar.SetDictationContext("hi", "What are you doing");

                recognizer.SetInputToDefaultAudioDevice();
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }
           

            try
            {
                recognizer.SpeechRecognized += recognizer_SpeechRecognized;
             
            }
            catch (InvalidOperationException exception)
            {
                richTextBox1.Text = String.Format("Could not recognize input from default aduio device. Is a microphone or sound card available?\r\n{0} - {1}.", exception.Source, exception.Message);
            }

        }
        //load text box
        public void recognizer_SpeechRecognized(object sender,SpeechRecognizedEventArgs e)
        {
           
            if (richTextBox1.Lines.Length == 0 || richTextBox1.Lines.Length <50)
            {
                richTextBox1.Text += e.Result.Text.ToString() + "  ";
            } 
            else
            {
                richTextBox1.Text += e.Result.Text.ToString() + " " + Environment.NewLine;
            }
           
        } 
       public void recognizer_LoadGrammarCompleted(object sender,LoadGrammarCompletedEventArgs e)
       {
           
       }
       
        //reset
        private void reset_Click(object sender, EventArgs e)
        {
           
            label2.Text = "IDLE";
            richTextBox1.Clear();

            recognizer.UnloadAllGrammars();
        
            start.Enabled = true;
            stop.Enabled = false;
            read.Enabled = false;
            read1.SpeakAsyncCancelAll();
            
        }
        //read the text box contain
        private void read_Click(object sender, EventArgs e)
        {

          if(richTextBox1.Text !="")
            {
               read1.SpeakAsync(richTextBox1.Text);
            label2.Text = "READING";
            stop.Enabled = true;
            start.Enabled = true;
            reset.Enabled = true;
            read.Enabled = true;
            recognizer.UnloadAllGrammars();
            
             }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
        }
      
         

        public void form3(object sender, FormClosingEventArgs e)
        {
        
        }

        //HOME STRIP
      private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            read1.Dispose();
            recognizer.UnloadAllGrammars();
           
            this.Hide();
            HomeForm f1 = new HomeForm();
            f1.ShowDialog();
        }
        //ABOUT STRIP
      private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
      {
          read1.Dispose();
          this.Hide();
          AboutSpeechToTextForm f6 = new AboutSpeechToTextForm();
          f6.ShowDialog();
         

          recognizer.UnloadAllGrammars();
      }
        //EXIT STRIP
      private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
      {

          read1.Dispose();
          recognizer.UnloadAllGrammars();
          SystemSounds.Asterisk.Play();
          DialogResult dr = MessageBox.Show("Are you sure to exit ?", "Message", MessageBoxButtons.YesNo);
          if (dr == DialogResult.Yes)
          {

              Application.Exit();

          }
      }
    }

}
       


           
  



   
