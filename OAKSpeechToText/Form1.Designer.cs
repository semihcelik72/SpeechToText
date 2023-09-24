namespace OAKSpeechToText
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpeech = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnConvertToWav = new System.Windows.Forms.Button();
            this.btnExportToWord = new System.Windows.Forms.Button();
            this.btnMicrosoft = new System.Windows.Forms.Button();
            this.btnPhyton5min = new System.Windows.Forms.Button();
            this.btnPhyton50 = new System.Windows.Forms.Button();
            this.btnPhyton10 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTurkish = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnConvertToWav);
            this.panel1.Controls.Add(this.btnExportToWord);
            this.panel1.Controls.Add(this.btnMicrosoft);
            this.panel1.Controls.Add(this.btnPhyton5min);
            this.panel1.Controls.Add(this.btnPhyton50);
            this.panel1.Controls.Add(this.btnPhyton10);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 626);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.txtTime);
            this.groupBox3.Controls.Add(this.btnSplit);
            this.groupBox3.Location = new System.Drawing.Point(9, 428);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 133);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Split";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Split Time";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sec",
            "min"});
            this.comboBox1.Location = new System.Drawing.Point(108, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(2, 46);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 23);
            this.txtTime.TabIndex = 6;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(0, 75);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(200, 42);
            this.btnSplit.TabIndex = 5;
            this.btnSplit.Text = "Split to wav pieces";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 611);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSpeech);
            this.groupBox2.Controls.Add(this.btnRecord);
            this.groupBox2.Location = new System.Drawing.Point(6, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Speech to Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "00:00:00";
            // 
            // btnSpeech
            // 
            this.btnSpeech.Location = new System.Drawing.Point(0, 70);
            this.btnSpeech.Name = "btnSpeech";
            this.btnSpeech.Size = new System.Drawing.Size(200, 42);
            this.btnSpeech.TabIndex = 1;
            this.btnSpeech.Text = "    Save and Convert To Text";
            this.btnSpeech.UseVisualStyleBackColor = true;
            this.btnSpeech.Click += new System.EventHandler(this.btnSpeech_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(0, 22);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(105, 42);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnConvertToWav
            // 
            this.btnConvertToWav.Location = new System.Drawing.Point(6, 380);
            this.btnConvertToWav.Name = "btnConvertToWav";
            this.btnConvertToWav.Size = new System.Drawing.Size(200, 42);
            this.btnConvertToWav.TabIndex = 1;
            this.btnConvertToWav.Text = "Convert to Wav";
            this.btnConvertToWav.UseVisualStyleBackColor = true;
            this.btnConvertToWav.Click += new System.EventHandler(this.btnConvertToWav_Click);
            // 
            // btnExportToWord
            // 
            this.btnExportToWord.Location = new System.Drawing.Point(9, 567);
            this.btnExportToWord.Name = "btnExportToWord";
            this.btnExportToWord.Size = new System.Drawing.Size(200, 42);
            this.btnExportToWord.TabIndex = 1;
            this.btnExportToWord.Text = " Export to Word";
            this.btnExportToWord.UseVisualStyleBackColor = true;
            this.btnExportToWord.Click += new System.EventHandler(this.btnExportToWord_Click);
            // 
            // btnMicrosoft
            // 
            this.btnMicrosoft.Location = new System.Drawing.Point(6, 205);
            this.btnMicrosoft.Name = "btnMicrosoft";
            this.btnMicrosoft.Size = new System.Drawing.Size(200, 42);
            this.btnMicrosoft.TabIndex = 1;
            this.btnMicrosoft.Text = "   Convert to Text        With Microsoft";
            this.btnMicrosoft.UseVisualStyleBackColor = true;
            this.btnMicrosoft.Click += new System.EventHandler(this.btnMicrosoft_Click);
            // 
            // btnPhyton5min
            // 
            this.btnPhyton5min.Location = new System.Drawing.Point(6, 157);
            this.btnPhyton5min.Name = "btnPhyton5min";
            this.btnPhyton5min.Size = new System.Drawing.Size(200, 42);
            this.btnPhyton5min.TabIndex = 1;
            this.btnPhyton5min.Text = "   Convert to Text        With Phyton 5 min";
            this.btnPhyton5min.UseVisualStyleBackColor = true;
            this.btnPhyton5min.Click += new System.EventHandler(this.btnPhyton5min_Click);
            // 
            // btnPhyton50
            // 
            this.btnPhyton50.Location = new System.Drawing.Point(6, 109);
            this.btnPhyton50.Name = "btnPhyton50";
            this.btnPhyton50.Size = new System.Drawing.Size(200, 42);
            this.btnPhyton50.TabIndex = 1;
            this.btnPhyton50.Text = "   Convert to Text        With Phyton 50 sec";
            this.btnPhyton50.UseVisualStyleBackColor = true;
            this.btnPhyton50.Click += new System.EventHandler(this.btnPhyton50_Click);
            // 
            // btnPhyton10
            // 
            this.btnPhyton10.Location = new System.Drawing.Point(6, 61);
            this.btnPhyton10.Name = "btnPhyton10";
            this.btnPhyton10.Size = new System.Drawing.Size(200, 42);
            this.btnPhyton10.TabIndex = 1;
            this.btnPhyton10.Text = "   Convert to Text        With Phyton 10 sec";
            this.btnPhyton10.UseVisualStyleBackColor = true;
            this.btnPhyton10.Click += new System.EventHandler(this.btnPhyton10_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTurkish);
            this.groupBox1.Controls.Add(this.rbEnglish);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Language";
            // 
            // rbTurkish
            // 
            this.rbTurkish.AutoSize = true;
            this.rbTurkish.Checked = true;
            this.rbTurkish.Location = new System.Drawing.Point(9, 22);
            this.rbTurkish.Name = "rbTurkish";
            this.rbTurkish.Size = new System.Drawing.Size(80, 21);
            this.rbTurkish.TabIndex = 1;
            this.rbTurkish.TabStop = true;
            this.rbTurkish.Text = "Turkish";
            this.rbTurkish.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(95, 22);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(79, 21);
            this.rbEnglish.TabIndex = 0;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 626);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(853, 626);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OAK Speech to Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTurkish;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpeech;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnConvertToWav;
        private System.Windows.Forms.Button btnExportToWord;
        private System.Windows.Forms.Button btnMicrosoft;
        private System.Windows.Forms.Button btnPhyton5min;
        private System.Windows.Forms.Button btnPhyton50;
        private System.Windows.Forms.Button btnPhyton10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnSplit;
    }
}

