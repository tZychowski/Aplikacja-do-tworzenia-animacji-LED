namespace LEDAplikacja
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vAnimWej = new System.Windows.Forms.ComboBox();
            this.effAnimWej = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.vAnimWyj = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.effAnimWyj = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.czasBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.invert = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.kolorAnim = new System.Windows.Forms.ComboBox();
            this.jasnoscAnim = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonWyjscie = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszAnimacjeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajAnimacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.dysk = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(147, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tekst do wyświetlenia na matrycy LED:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(152, 83);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(342, 20);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.vAnimWej);
            this.panel1.Controls.Add(this.effAnimWej);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(64, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 170);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // vAnimWej
            // 
            this.vAnimWej.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vAnimWej.FormattingEnabled = true;
            this.vAnimWej.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.vAnimWej.Location = new System.Drawing.Point(141, 98);
            this.vAnimWej.Name = "vAnimWej";
            this.vAnimWej.Size = new System.Drawing.Size(109, 21);
            this.vAnimWej.TabIndex = 8;
            // 
            // effAnimWej
            // 
            this.effAnimWej.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.effAnimWej.FormattingEnabled = true;
            this.effAnimWej.Items.AddRange(new object[] {
            "Kursor",
            "Linia",
            "Pojawianie"});
            this.effAnimWej.Location = new System.Drawing.Point(141, 55);
            this.effAnimWej.Name = "effAnimWej";
            this.effAnimWej.Size = new System.Drawing.Size(109, 21);
            this.effAnimWej.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(15, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prędkość animacji:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(28, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rodzaj animacji:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(36, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parametry animacji wejscia:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.vAnimWyj);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.effAnimWyj);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(333, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 170);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // vAnimWyj
            // 
            this.vAnimWyj.FormattingEnabled = true;
            this.vAnimWyj.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.vAnimWyj.Location = new System.Drawing.Point(135, 98);
            this.vAnimWyj.Name = "vAnimWyj";
            this.vAnimWyj.Size = new System.Drawing.Size(109, 21);
            this.vAnimWyj.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(30, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parametry animacji wyjscia:";
            // 
            // effAnimWyj
            // 
            this.effAnimWyj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.effAnimWyj.FormattingEnabled = true;
            this.effAnimWyj.Items.AddRange(new object[] {
            "Kursor prawo",
            "Kursor lewo",
            "Zanikanie"});
            this.effAnimWyj.Location = new System.Drawing.Point(135, 61);
            this.effAnimWyj.Name = "effAnimWyj";
            this.effAnimWyj.Size = new System.Drawing.Size(109, 21);
            this.effAnimWyj.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(9, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Prędkość animacji:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(22, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Rodzaj animacji:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Controls.Add(this.czasBox);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.invert);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.kolorAnim);
            this.panel5.Controls.Add(this.jasnoscAnim);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(64, 294);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(532, 115);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // czasBox
            // 
            this.czasBox.Location = new System.Drawing.Point(373, 40);
            this.czasBox.Name = "czasBox";
            this.czasBox.Size = new System.Drawing.Size(109, 20);
            this.czasBox.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(266, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(258, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Czasm między wejsciem a wyjsciem (ms)";
            // 
            // invert
            // 
            this.invert.FormattingEnabled = true;
            this.invert.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.invert.Location = new System.Drawing.Point(373, 76);
            this.invert.Name = "invert";
            this.invert.Size = new System.Drawing.Size(109, 21);
            this.invert.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(300, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Negatyw:";
            // 
            // kolorAnim
            // 
            this.kolorAnim.FormattingEnabled = true;
            this.kolorAnim.Items.AddRange(new object[] {
            "Czerwony",
            "Zielony"});
            this.kolorAnim.Location = new System.Drawing.Point(134, 79);
            this.kolorAnim.Name = "kolorAnim";
            this.kolorAnim.Size = new System.Drawing.Size(109, 21);
            this.kolorAnim.TabIndex = 12;
            // 
            // jasnoscAnim
            // 
            this.jasnoscAnim.FormattingEnabled = true;
            this.jasnoscAnim.Items.AddRange(new object[] {
            " 1",
            " 2",
            " 3",
            " 4",
            " 5",
            " 6",
            " 7",
            " 8",
            " 9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.jasnoscAnim.Location = new System.Drawing.Point(135, 40);
            this.jasnoscAnim.Name = "jasnoscAnim";
            this.jasnoscAnim.Size = new System.Drawing.Size(109, 21);
            this.jasnoscAnim.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(29, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Kolor animacji:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(16, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Jasność animacji:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(22, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pozostałe parametry:";
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(226, 443);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(136, 42);
            this.buttonZapisz.TabIndex = 6;
            this.buttonZapisz.Text = "Zapisz na SD";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonWyjscie
            // 
            this.buttonWyjscie.Location = new System.Drawing.Point(460, 443);
            this.buttonWyjscie.Name = "buttonWyjscie";
            this.buttonWyjscie.Size = new System.Drawing.Size(136, 42);
            this.buttonWyjscie.TabIndex = 7;
            this.buttonWyjscie.Text = "Wyjscie";
            this.buttonWyjscie.UseVisualStyleBackColor = true;
            this.buttonWyjscie.Click += new System.EventHandler(this.buttonWyjscie_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszAnimacjeToolStrip,
            this.wczytajAnimacjeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // zapiszAnimacjeToolStrip
            // 
            this.zapiszAnimacjeToolStrip.Name = "zapiszAnimacjeToolStrip";
            this.zapiszAnimacjeToolStrip.Size = new System.Drawing.Size(166, 22);
            this.zapiszAnimacjeToolStrip.Text = "Zapisz animacje";
            this.zapiszAnimacjeToolStrip.Click += new System.EventHandler(this.zapiszAnimacjeToolStrip_Click);
            // 
            // wczytajAnimacjeToolStripMenuItem
            // 
            this.wczytajAnimacjeToolStripMenuItem.Name = "wczytajAnimacjeToolStripMenuItem";
            this.wczytajAnimacjeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.wczytajAnimacjeToolStripMenuItem.Text = "Wczytaj animacje";
            this.wczytajAnimacjeToolStripMenuItem.Click += new System.EventHandler(this.wczytajAnimacjeToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 429);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Wybierz dysk:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // dysk
            // 
            this.dysk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dysk.FormattingEnabled = true;
            this.dysk.Items.AddRange(new object[] {
            "K",
            "J",
            "H",
            "I",
            "G",
            "F",
            "D",
            "E"});
            this.dysk.Location = new System.Drawing.Point(74, 455);
            this.dysk.Name = "dysk";
            this.dysk.Size = new System.Drawing.Size(70, 21);
            this.dysk.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 528);
            this.Controls.Add(this.dysk);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonWyjscie);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEDAplikacja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox vAnimWyj;
        private System.Windows.Forms.ComboBox effAnimWyj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox kolorAnim;
        private System.Windows.Forms.ComboBox jasnoscAnim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox vAnimWej;
        private System.Windows.Forms.ComboBox effAnimWej;
        private System.Windows.Forms.TextBox czasBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox invert;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonWyjscie;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszAnimacjeToolStrip;
        private System.Windows.Forms.ToolStripMenuItem wczytajAnimacjeToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox dysk;
    }
}

