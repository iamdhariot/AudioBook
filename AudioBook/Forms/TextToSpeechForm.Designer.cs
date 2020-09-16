namespace audiobook
{
    partial class TextToSpeechForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextToSpeechForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.speak = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.replay = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Lavender;
            this.richTextBox1.Location = new System.Drawing.Point(47, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(684, 197);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // speak
            // 
            this.speak.BackColor = System.Drawing.Color.LightBlue;
            this.speak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.speak.Location = new System.Drawing.Point(47, 353);
            this.speak.Name = "speak";
            this.speak.Size = new System.Drawing.Size(85, 26);
            this.speak.TabIndex = 2;
            this.speak.Text = "SPEAK";
            this.speak.UseVisualStyleBackColor = false;
            this.speak.Click += new System.EventHandler(this.speak_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.LightBlue;
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pause.Location = new System.Drawing.Point(230, 353);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(85, 26);
            this.pause.TabIndex = 3;
            this.pause.Text = "PAUSE";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // resume
            // 
            this.resume.BackColor = System.Drawing.Color.LightBlue;
            this.resume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resume.Location = new System.Drawing.Point(400, 353);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(85, 26);
            this.resume.TabIndex = 4;
            this.resume.Text = "RESUME";
            this.resume.UseVisualStyleBackColor = false;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // replay
            // 
            this.replay.BackColor = System.Drawing.Color.LightBlue;
            this.replay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.replay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.replay.Location = new System.Drawing.Point(570, 353);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(85, 26);
            this.replay.TabIndex = 5;
            this.replay.Text = "REPLAY";
            this.replay.UseVisualStyleBackColor = false;
            this.replay.Click += new System.EventHandler(this.replay_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.LightBlue;
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stop.Location = new System.Drawing.Point(725, 353);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(85, 26);
            this.stop.TabIndex = 6;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(43, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "SYNTHESIZER  STATUS  : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.Lavender;
            this.load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.ForeColor = System.Drawing.Color.Black;
            this.load.Location = new System.Drawing.Point(737, 126);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(73, 197);
            this.load.TabIndex = 11;
            this.load.Text = "Browse Text File";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "IDLE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Text To Speech ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.aBOUTToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            this.aBOUTToolStripMenuItem.Click += new System.EventHandler(this.aBOUTToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.load);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.replay);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.speak);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form2";
            this.Text = "Audiobook";
            this.Load += new System.EventHandler(this.form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button speak;
       
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Button replay;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}