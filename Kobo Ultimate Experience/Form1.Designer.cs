namespace Kobo_Ultimate_Experience
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            kepubifyAddDummyTitle = new CheckBox();
            kepubifyFullScreenReadingFixes = new CheckBox();
            kepubifyForceHyphenation = new CheckBox();
            kepubifySmartPunctuation = new CheckBox();
            panel1 = new Panel();
            label2 = new Label();
            tabPage2 = new TabPage();
            button9 = new Button();
            label24 = new Label();
            label7 = new Label();
            label6 = new Label();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            tabPage3 = new TabPage();
            label28 = new Label();
            label27 = new Label();
            button8 = new Button();
            label23 = new Label();
            button7 = new Button();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            button6 = new Button();
            button5 = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            button4 = new Button();
            label11 = new Label();
            label10 = new Label();
            button3 = new Button();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            button2 = new Button();
            tabPage4 = new TabPage();
            label26 = new Label();
            label25 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 149);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1032, 519);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(kepubifyAddDummyTitle);
            tabPage1.Controls.Add(kepubifyFullScreenReadingFixes);
            tabPage1.Controls.Add(kepubifyForceHyphenation);
            tabPage1.Controls.Add(kepubifySmartPunctuation);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1024, 486);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kepubify";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // kepubifyAddDummyTitle
            // 
            kepubifyAddDummyTitle.AutoSize = true;
            kepubifyAddDummyTitle.Location = new Point(540, 449);
            kepubifyAddDummyTitle.Name = "kepubifyAddDummyTitle";
            kepubifyAddDummyTitle.Size = new Size(184, 24);
            kepubifyAddDummyTitle.TabIndex = 4;
            kepubifyAddDummyTitle.Text = "Add Dummy Title Page";
            kepubifyAddDummyTitle.UseVisualStyleBackColor = true;
            // 
            // kepubifyFullScreenReadingFixes
            // 
            kepubifyFullScreenReadingFixes.AutoSize = true;
            kepubifyFullScreenReadingFixes.Location = new Point(337, 449);
            kepubifyFullScreenReadingFixes.Name = "kepubifyFullScreenReadingFixes";
            kepubifyFullScreenReadingFixes.Size = new Size(197, 24);
            kepubifyFullScreenReadingFixes.TabIndex = 3;
            kepubifyFullScreenReadingFixes.Text = "Full Screen Reading Fixes";
            kepubifyFullScreenReadingFixes.UseVisualStyleBackColor = true;
            // 
            // kepubifyForceHyphenation
            // 
            kepubifyForceHyphenation.AutoSize = true;
            kepubifyForceHyphenation.Location = new Point(175, 449);
            kepubifyForceHyphenation.Name = "kepubifyForceHyphenation";
            kepubifyForceHyphenation.Size = new Size(156, 24);
            kepubifyForceHyphenation.TabIndex = 2;
            kepubifyForceHyphenation.Text = "Force Hyphenation";
            kepubifyForceHyphenation.UseVisualStyleBackColor = true;
            // 
            // kepubifySmartPunctuation
            // 
            kepubifySmartPunctuation.AutoSize = true;
            kepubifySmartPunctuation.Location = new Point(17, 449);
            kepubifySmartPunctuation.Name = "kepubifySmartPunctuation";
            kepubifySmartPunctuation.Size = new Size(152, 24);
            kepubifySmartPunctuation.TabIndex = 1;
            kepubifySmartPunctuation.Text = "Smart Punctuation";
            kepubifySmartPunctuation.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(19, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 413);
            panel1.TabIndex = 0;
            panel1.DragDrop += panel1_DragDrop;
            panel1.DragEnter += panel1_DragEnter;
            panel1.DragLeave += panel1_DragLeave;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Location = new Point(411, 177);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 0;
            label2.Text = "- Drop Epub Files Here -";
            label2.DragDrop += label2_DragDrop;
            label2.DragEnter += label2_DragEnter;
            label2.DragLeave += label2_DragLeave;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(label24);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(progressBar1);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(linkLabel1);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1024, 486);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Firmware Patcher";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(310, 244);
            button9.Name = "button9";
            button9.Size = new Size(174, 29);
            button9.TabIndex = 9;
            button9.Text = "Install";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(28, 241);
            label24.Name = "label24";
            label24.Size = new Size(263, 28);
            label24.TabIndex = 8;
            label24.Text = "Step 5: Install Alucard™ fonts";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(703, 421);
            label7.Name = "label7";
            label7.Size = new Size(297, 17);
            label7.TabIndex = 7;
            label7.Text = "We are using Noto Sans Thai Looped as system font";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 195);
            label6.Name = "label6";
            label6.Size = new Size(189, 28);
            label6.TabIndex = 6;
            label6.Text = "Step 4: Restart Kobo";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(28, 441);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(972, 29);
            progressBar1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(310, 87);
            button1.Name = "button1";
            button1.Size = new Size(174, 29);
            button1.TabIndex = 4;
            button1.Text = "Patch";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 141);
            label5.Name = "label5";
            label5.Size = new Size(412, 28);
            label5.TabIndex = 3;
            label5.Text = "Step 3: Copy KoboRoot.tgz to .kobo directory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 84);
            label4.Name = "label4";
            label4.Size = new Size(276, 28);
            label4.TabIndex = 2;
            label4.Text = "Step 2: Open Downloaded File";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(382, 25);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(102, 28);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Download";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 25);
            label3.Name = "label3";
            label3.Size = new Size(348, 28);
            label3.TabIndex = 0;
            label3.Text = "Step 1: Download Your Kobo Firmware";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label28);
            tabPage3.Controls.Add(label27);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(label23);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(button2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1024, 486);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Install KoReader";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label28.Location = new Point(526, 421);
            label28.Name = "label28";
            label28.Size = new Size(476, 28);
            label28.TabIndex = 20;
            label28.Text = "A simple plugin that automatic parse series metadata";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label27.Location = new Point(526, 348);
            label27.Name = "label27";
            label27.Size = new Size(410, 28);
            label27.TabIndex = 19;
            label27.Text = "A simple plugin that show clock while reading";
            // 
            // button8
            // 
            button8.Location = new Point(295, 423);
            button8.Name = "button8";
            button8.Size = new Size(225, 30);
            button8.TabIndex = 18;
            button8.Text = "Install";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(28, 397);
            label23.Name = "label23";
            label23.Size = new Size(237, 56);
            label23.TabIndex = 17;
            label23.Text = "(Optional)\r\nStep 7: Install NickelSeries";
            // 
            // button7
            // 
            button7.Location = new Point(295, 350);
            button7.Name = "button7";
            button7.Size = new Size(225, 30);
            button7.TabIndex = 16;
            button7.Text = "Install";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(28, 324);
            label17.Name = "label17";
            label17.Size = new Size(234, 56);
            label17.TabIndex = 15;
            label17.Text = "(Optional)\r\nStep 6: Install NickelClock";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(526, 277);
            label16.Name = "label16";
            label16.Size = new Size(101, 28);
            label16.TabIndex = 14;
            label16.Text = "Waiting...";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(526, 232);
            label15.Name = "label15";
            label15.Size = new Size(101, 28);
            label15.TabIndex = 13;
            label15.Text = "Waiting...";
            // 
            // button6
            // 
            button6.Location = new Point(295, 279);
            button6.Name = "button6";
            button6.Size = new Size(225, 30);
            button6.TabIndex = 12;
            button6.Text = "Install";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(295, 230);
            button5.Name = "button5";
            button5.Size = new Size(225, 30);
            button5.TabIndex = 11;
            button5.Text = "Config";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(28, 277);
            label14.Name = "label14";
            label14.Size = new Size(216, 28);
            label14.TabIndex = 10;
            label14.Text = "Step 5: Install KoReader";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(28, 228);
            label13.Name = "label13";
            label13.Size = new Size(248, 28);
            label13.TabIndex = 9;
            label13.Text = "Step 4: Config Nickel Menu";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(526, 129);
            label12.Name = "label12";
            label12.Size = new Size(402, 84);
            label12.TabIndex = 8;
            label12.Text = "After device restart, \r\nconnect your kobo to PC, press Refresh Drive\r\nand select the correct kobo drive again.";
            // 
            // button4
            // 
            button4.Location = new Point(295, 131);
            button4.Name = "button4";
            button4.Size = new Size(225, 30);
            button4.TabIndex = 7;
            button4.Text = "Install";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(28, 131);
            label11.Name = "label11";
            label11.Size = new Size(241, 28);
            label11.TabIndex = 6;
            label11.Text = "Step 3: Install Nickel Menu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(526, 78);
            label10.Name = "label10";
            label10.Size = new Size(101, 28);
            label10.TabIndex = 5;
            label10.Text = "Waiting...";
            // 
            // button3
            // 
            button3.Location = new Point(295, 78);
            button3.Name = "button3";
            button3.Size = new Size(225, 30);
            button3.TabIndex = 4;
            button3.Text = "Config";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 76);
            label9.Name = "label9";
            label9.Size = new Size(250, 28);
            label9.TabIndex = 3;
            label9.Text = "Step 2: Config Exclude Sync";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(295, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(406, 28);
            comboBox1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 25);
            label8.Name = "label8";
            label8.Size = new Size(232, 28);
            label8.TabIndex = 1;
            label8.Text = "Step 1: Select Kobo Drive";
            // 
            // button2
            // 
            button2.Location = new Point(719, 27);
            button2.Name = "button2";
            button2.Size = new Size(225, 30);
            button2.TabIndex = 0;
            button2.Text = "Refresh Drive";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label26);
            tabPage4.Controls.Add(label25);
            tabPage4.Controls.Add(label22);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(label18);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1024, 486);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "About";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label26.Location = new Point(359, 325);
            label26.Name = "label26";
            label26.Size = new Size(277, 28);
            label26.TabIndex = 10;
            label26.Text = "Font's Author (Mali, Js Jindara)";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label25.Location = new Point(279, 297);
            label25.Name = "label25";
            label25.Size = new Size(428, 28);
            label25.TabIndex = 9;
            label25.Text = "Google Fonts (Noto Sans Thai Looped, Sarabun)";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label22.Location = new Point(437, 269);
            label22.Name = "label22";
            label22.Size = new Size(96, 28);
            label22.TabIndex = 8;
            label22.Text = "KoReader";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label21.Location = new Point(390, 242);
            label21.Name = "label21";
            label21.Size = new Size(198, 28);
            label21.TabIndex = 7;
            label21.Text = "Shermp (NickelClock)";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label20.Location = new Point(263, 214);
            label20.Name = "label20";
            label20.Size = new Size(457, 28);
            label20.TabIndex = 6;
            label20.Text = "Patrick Gaskin (Kepubify, NickelMenu, NickelSeries)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(395, 181);
            label19.Name = "label19";
            label19.Size = new Size(193, 31);
            label19.TabIndex = 5;
            label19.Text = "Special Thanks To";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(267, 104);
            label18.Name = "label18";
            label18.Size = new Size(453, 54);
            label18.TabIndex = 4;
            label18.Text = "Made by Alucard Lucio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 17);
            label1.Name = "label1";
            label1.Size = new Size(1028, 129);
            label1.TabIndex = 1;
            label1.Text = "Kobo Ultimate Experience";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 684);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kobo Ultimate Experience [TH Edition]";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel1;
        private Label label2;
        private CheckBox kepubifySmartPunctuation;
        private CheckBox kepubifyAddDummyTitle;
        private CheckBox kepubifyFullScreenReadingFixes;
        private CheckBox kepubifyForceHyphenation;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label5;
        private Label label4;
        private Button button1;
        private ProgressBar progressBar1;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private Button button2;
        private Label label10;
        private Button button3;
        private Label label9;
        private Label label12;
        private Button button4;
        private Label label11;
        private Button button6;
        private Button button5;
        private Label label14;
        private Label label13;
        private Label label16;
        private Label label15;
        private Button button7;
        private Label label17;
        private Label label18;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Button button8;
        private Label label23;
        private Label label24;
        private Button button9;
        private Label label26;
        private Label label25;
        private Label label28;
        private Label label27;
    }
}
