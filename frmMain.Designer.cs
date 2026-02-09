namespace TQMathphix
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(556, 256);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(510, 237);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(553, 227);
            button1.Name = "button1";
            button1.Size = new Size(176, 23);
            button1.TabIndex = 3;
            button1.Text = "Parse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(556, 499);
            button2.Name = "button2";
            button2.Size = new Size(176, 23);
            button2.TabIndex = 3;
            button2.Text = "Copy to ClipBoard";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 67);
            button3.Name = "button3";
            button3.Size = new Size(176, 23);
            button3.TabIndex = 3;
            button3.Text = "Paste From the ClipBoard";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(6, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 423);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(556, 102);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(510, 112);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(6, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 47);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Style";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(191, 19);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(102, 21);
            radioButton4.TabIndex = 0;
            radioButton4.Text = "User Defined";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(127, 19);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(58, 21);
            radioButton3.TabIndex = 0;
            radioButton3.Text = "Table";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(69, 19);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(52, 21);
            radioButton2.TabIndex = 0;
            radioButton2.Text = "OCR";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(7, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(56, 21);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Latex";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(556, 70);
            button4.Name = "button4";
            button4.Size = new Size(102, 23);
            button4.TabIndex = 8;
            button4.Text = "Open Prompts";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(964, 70);
            button5.Name = "button5";
            button5.Size = new Size(102, 23);
            button5.TabIndex = 9;
            button5.Text = "Clear Prompts";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(391, 70);
            button6.Name = "button6";
            button6.Size = new Size(125, 23);
            button6.TabIndex = 8;
            button6.Text = "Open From File...";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(912, 18);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(154, 17);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "mail:386393335@qq.com";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 538);
            Controls.Add(linkLabel1);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBox2);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "微风智能助手";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button4;
        private Button button5;
        private RadioButton radioButton3;
        private Button button6;
        private RadioButton radioButton4;
        private LinkLabel linkLabel1;
    }
}
