namespace WindowsFormsApplication3
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
            this.girisPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDogruCevap = new System.Windows.Forms.Label();
            this.lblToplamSoru = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.testPanel = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ambiance_Label9 = new Ambiance.Ambiance_Label();
            this.ambiance_Label8 = new Ambiance.Ambiance_Label();
            this.ambiance_Label7 = new Ambiance.Ambiance_Label();
            this.ambiance_Label6 = new Ambiance.Ambiance_Label();
            this.sorubilgi = new Ambiance.Ambiance_RichTextBox();
            this.ambiance_Label5 = new Ambiance.Ambiance_Label();
            this.label2 = new Ambiance.Ambiance_Label();
            this.radioButton4 = new Ambiance.Ambiance_RadioButton();
            this.radioButton3 = new Ambiance.Ambiance_RadioButton();
            this.radioButton2 = new Ambiance.Ambiance_RadioButton();
            this.radioButton1 = new Ambiance.Ambiance_RadioButton();
            this.button1 = new EffectualButtonOrange();
            this.button5 = new EffectualButtonOrange();
            this.button3 = new EffectualButtonOrange();
            this.ambiance_Label4 = new Ambiance.Ambiance_Label();
            this.ambiance_Label3 = new Ambiance.Ambiance_Label();
            this.button9 = new EffectualButtonOrange();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.comboBox2 = new Ambiance.Ambiance_ComboBox();
            this.comboBox1 = new Ambiance.Ambiance_ComboBox();
            this.button4 = new EffectualButtonOrange();
            this.girisPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.testPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisPanel
            // 
            this.girisPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.girisPanel.Controls.Add(this.ambiance_Label2);
            this.girisPanel.Controls.Add(this.ambiance_Label1);
            this.girisPanel.Controls.Add(this.comboBox2);
            this.girisPanel.Controls.Add(this.comboBox1);
            this.girisPanel.Controls.Add(this.button4);
            this.girisPanel.Location = new System.Drawing.Point(270, 173);
            this.girisPanel.Name = "girisPanel";
            this.girisPanel.Size = new System.Drawing.Size(420, 225);
            this.girisPanel.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ambiance_Label4);
            this.panel1.Controls.Add(this.ambiance_Label3);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.lblDogruCevap);
            this.panel1.Controls.Add(this.lblToplamSoru);
            this.panel1.Location = new System.Drawing.Point(409, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 171);
            this.panel1.TabIndex = 25;
            // 
            // lblDogruCevap
            // 
            this.lblDogruCevap.AutoSize = true;
            this.lblDogruCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogruCevap.Location = new System.Drawing.Point(147, 67);
            this.lblDogruCevap.Name = "lblDogruCevap";
            this.lblDogruCevap.Size = new System.Drawing.Size(0, 20);
            this.lblDogruCevap.TabIndex = 9;
            // 
            // lblToplamSoru
            // 
            this.lblToplamSoru.AutoSize = true;
            this.lblToplamSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSoru.Location = new System.Drawing.Point(149, 30);
            this.lblToplamSoru.Name = "lblToplamSoru";
            this.lblToplamSoru.Size = new System.Drawing.Size(0, 20);
            this.lblToplamSoru.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // testPanel
            // 
            this.testPanel.Controls.Add(this.ambiance_Label9);
            this.testPanel.Controls.Add(this.ambiance_Label8);
            this.testPanel.Controls.Add(this.ambiance_Label7);
            this.testPanel.Controls.Add(this.ambiance_Label6);
            this.testPanel.Controls.Add(this.sorubilgi);
            this.testPanel.Controls.Add(this.ambiance_Label5);
            this.testPanel.Controls.Add(this.label2);
            this.testPanel.Controls.Add(this.radioButton4);
            this.testPanel.Controls.Add(this.radioButton3);
            this.testPanel.Controls.Add(this.radioButton2);
            this.testPanel.Controls.Add(this.radioButton1);
            this.testPanel.Controls.Add(this.button1);
            this.testPanel.Controls.Add(this.button5);
            this.testPanel.Controls.Add(this.button3);
            this.testPanel.Location = new System.Drawing.Point(301, 156);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(714, 512);
            this.testPanel.TabIndex = 10;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(728, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '+';
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 26;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(892, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(104, 23);
            this.button10.TabIndex = 27;
            this.button10.Text = "Yönetici Girişi";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources._2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(35, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 174);
            this.panel3.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources._1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(12, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 227);
            this.panel2.TabIndex = 28;
            // 
            // ambiance_Label9
            // 
            this.ambiance_Label9.AutoSize = true;
            this.ambiance_Label9.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label9.Location = new System.Drawing.Point(8, 361);
            this.ambiance_Label9.Name = "ambiance_Label9";
            this.ambiance_Label9.Size = new System.Drawing.Size(32, 21);
            this.ambiance_Label9.TabIndex = 33;
            this.ambiance_Label9.Text = "D-)";
            // 
            // ambiance_Label8
            // 
            this.ambiance_Label8.AutoSize = true;
            this.ambiance_Label8.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label8.Location = new System.Drawing.Point(10, 324);
            this.ambiance_Label8.Name = "ambiance_Label8";
            this.ambiance_Label8.Size = new System.Drawing.Size(31, 21);
            this.ambiance_Label8.TabIndex = 32;
            this.ambiance_Label8.Text = "C-)";
            // 
            // ambiance_Label7
            // 
            this.ambiance_Label7.AutoSize = true;
            this.ambiance_Label7.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label7.Location = new System.Drawing.Point(8, 288);
            this.ambiance_Label7.Name = "ambiance_Label7";
            this.ambiance_Label7.Size = new System.Drawing.Size(30, 21);
            this.ambiance_Label7.TabIndex = 31;
            this.ambiance_Label7.Text = "B-)";
            // 
            // ambiance_Label6
            // 
            this.ambiance_Label6.AutoSize = true;
            this.ambiance_Label6.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label6.Location = new System.Drawing.Point(8, 253);
            this.ambiance_Label6.Name = "ambiance_Label6";
            this.ambiance_Label6.Size = new System.Drawing.Size(31, 21);
            this.ambiance_Label6.TabIndex = 30;
            this.ambiance_Label6.Text = "A-)";
            // 
            // sorubilgi
            // 
            this.sorubilgi.AutoWordSelection = false;
            this.sorubilgi.BackColor = System.Drawing.Color.White;
            this.sorubilgi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.sorubilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.sorubilgi.Location = new System.Drawing.Point(9, 50);
            this.sorubilgi.Name = "sorubilgi";
            this.sorubilgi.ReadOnly = true;
            this.sorubilgi.Size = new System.Drawing.Size(685, 192);
            this.sorubilgi.TabIndex = 29;
            this.sorubilgi.WordWrap = true;
            // 
            // ambiance_Label5
            // 
            this.ambiance_Label5.AutoSize = true;
            this.ambiance_Label5.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label5.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ambiance_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label5.Location = new System.Drawing.Point(8, 4);
            this.ambiance_Label5.Name = "ambiance_Label5";
            this.ambiance_Label5.Size = new System.Drawing.Size(83, 32);
            this.ambiance_Label5.TabIndex = 28;
            this.ambiance_Label5.Text = "Soru : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(95, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "aa";
            // 
            // radioButton4
            // 
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.Checked = false;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButton4.Location = new System.Drawing.Point(41, 365);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(193, 15);
            this.radioButton4.TabIndex = 26;
            // 
            // radioButton3
            // 
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Checked = false;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButton3.Location = new System.Drawing.Point(41, 328);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(193, 15);
            this.radioButton3.TabIndex = 26;
            // 
            // radioButton2
            // 
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Checked = false;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButton2.Location = new System.Drawing.Point(41, 293);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(193, 15);
            this.radioButton2.TabIndex = 25;
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = false;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButton1.Location = new System.Drawing.Point(41, 258);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(193, 15);
            this.radioButton1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.button1.Location = new System.Drawing.Point(19, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 36);
            this.button1.TabIndex = 23;
            this.button1.Text = "Geri";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.button5.Location = new System.Drawing.Point(187, 424);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 36);
            this.button5.TabIndex = 22;
            this.button5.Text = "Bitir";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.button3.Location = new System.Drawing.Point(187, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 36);
            this.button3.TabIndex = 21;
            this.button3.Text = "İleri";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ambiance_Label4
            // 
            this.ambiance_Label4.AutoSize = true;
            this.ambiance_Label4.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ambiance_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label4.Location = new System.Drawing.Point(29, 66);
            this.ambiance_Label4.Name = "ambiance_Label4";
            this.ambiance_Label4.Size = new System.Drawing.Size(114, 20);
            this.ambiance_Label4.TabIndex = 22;
            this.ambiance_Label4.Text = "Doğru Cevap : ";
            // 
            // ambiance_Label3
            // 
            this.ambiance_Label3.AutoSize = true;
            this.ambiance_Label3.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ambiance_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label3.Location = new System.Drawing.Point(29, 30);
            this.ambiance_Label3.Name = "ambiance_Label3";
            this.ambiance_Label3.Size = new System.Drawing.Size(111, 20);
            this.ambiance_Label3.TabIndex = 21;
            this.ambiance_Label3.Text = "Toplam Soru : ";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.button9.Location = new System.Drawing.Point(38, 118);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 33);
            this.button9.TabIndex = 18;
            this.button9.Text = "Tekrar Et";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(73, 113);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(39, 20);
            this.ambiance_Label2.TabIndex = 21;
            this.ambiance_Label2.Text = "Ders";
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(74, 57);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(38, 20);
            this.ambiance_Label1.TabIndex = 20;
            this.ambiance_Label1.Text = "Sınıf";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2.DropDownHeight = 100;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.HoverSelectionColor = System.Drawing.Color.Empty;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.ItemHeight = 20;
            this.comboBox2.Location = new System.Drawing.Point(127, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(242, 26);
            this.comboBox2.StartIndex = 0;
            this.comboBox2.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownHeight = 100;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.HoverSelectionColor = System.Drawing.Color.Empty;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 20;
            this.comboBox1.Location = new System.Drawing.Point(127, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 26);
            this.comboBox1.StartIndex = 0;
            this.comboBox1.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.button4.Location = new System.Drawing.Point(171, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 52);
            this.button4.TabIndex = 17;
            this.button4.Text = "Başlat";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1047, 729);
            this.Controls.Add(this.testPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.girisPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox2);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.girisPanel.ResumeLayout(false);
            this.girisPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.testPanel.ResumeLayout(false);
            this.testPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel girisPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDogruCevap;
        private System.Windows.Forms.Label lblToplamSoru;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel testPanel;
        private EffectualButtonOrange button4;
        private Ambiance.Ambiance_ComboBox comboBox1;
        private Ambiance.Ambiance_ComboBox comboBox2;
        private Ambiance.Ambiance_Label ambiance_Label2;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private EffectualButtonOrange button9;
        private Ambiance.Ambiance_Label ambiance_Label4;
        private Ambiance.Ambiance_Label ambiance_Label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button10;
        private EffectualButtonOrange button3;
        private EffectualButtonOrange button5;
        private EffectualButtonOrange button1;
        private Ambiance.Ambiance_RadioButton radioButton4;
        private Ambiance.Ambiance_RadioButton radioButton3;
        private Ambiance.Ambiance_RadioButton radioButton2;
        private Ambiance.Ambiance_RadioButton radioButton1;
        private Ambiance.Ambiance_Label ambiance_Label5;
        private Ambiance.Ambiance_Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Ambiance.Ambiance_RichTextBox sorubilgi;
        private Ambiance.Ambiance_Label ambiance_Label9;
        private Ambiance.Ambiance_Label ambiance_Label8;
        private Ambiance.Ambiance_Label ambiance_Label7;
        private Ambiance.Ambiance_Label ambiance_Label6;


    }
}

