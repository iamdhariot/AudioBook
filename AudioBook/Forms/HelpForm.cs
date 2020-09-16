using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Speech.Synthesis;
using System.Speech;
namespace audiobook
{
    public partial class HelpForm : Form
    {
        SpeechSynthesizer read1 = new SpeechSynthesizer();
        public HelpForm()
        {
            InitializeComponent();
        }
        //exit
        private void exit_Click(object sender, EventArgs e)
        {
            read1.SpeakAsyncCancelAll();
            SystemSounds.Asterisk.Play();
            DialogResult dr = MessageBox.Show("Are you sure to exit ?", "Message", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void home_Click(object sender, EventArgs e)
        {

            read1.SpeakAsyncCancelAll();
            this.Hide();
            HomeForm f1 = new HomeForm();
            f1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }
    }
}
