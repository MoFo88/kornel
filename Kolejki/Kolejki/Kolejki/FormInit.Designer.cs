namespace Kolejki
{
    partial class FormInit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQSize = new System.Windows.Forms.TextBox();
            this.buttonAddSocket = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNrOfDevices = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxQType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.checkBoxIsFirst = new System.Windows.Forms.CheckBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonmakeConnection = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxProbability = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNormGenProb = new System.Windows.Forms.TextBox();
            this.textBoxUnifGenProb = new System.Windows.Forms.TextBox();
            this.textBoxNormMean = new System.Windows.Forms.TextBox();
            this.textBoxNormStd = new System.Windows.Forms.TextBox();
            this.textBoxUnifMin = new System.Windows.Forms.TextBox();
            this.textBoxUnifMax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.szybkaInicjalizacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kolejka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rozmiar:";
            // 
            // textBoxQSize
            // 
            this.textBoxQSize.Location = new System.Drawing.Point(104, 82);
            this.textBoxQSize.Name = "textBoxQSize";
            this.textBoxQSize.Size = new System.Drawing.Size(151, 20);
            this.textBoxQSize.TabIndex = 3;
            // 
            // buttonAddSocket
            // 
            this.buttonAddSocket.Location = new System.Drawing.Point(158, 247);
            this.buttonAddSocket.Name = "buttonAddSocket";
            this.buttonAddSocket.Size = new System.Drawing.Size(96, 23);
            this.buttonAddSocket.TabIndex = 4;
            this.buttonAddSocket.Text = "Dodaj gniazdo";
            this.buttonAddSocket.UseVisualStyleBackColor = true;
            this.buttonAddSocket.Click += new System.EventHandler(this.buttonAddSocket_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Liczba maszyn:";
            // 
            // textBoxNrOfDevices
            // 
            this.textBoxNrOfDevices.Location = new System.Drawing.Point(103, 111);
            this.textBoxNrOfDevices.Name = "textBoxNrOfDevices";
            this.textBoxNrOfDevices.Size = new System.Drawing.Size(151, 20);
            this.textBoxNrOfDevices.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Typ kolejki:";
            // 
            // comboBoxQType
            // 
            this.comboBoxQType.FormattingEnabled = true;
            this.comboBoxQType.Location = new System.Drawing.Point(103, 141);
            this.comboBoxQType.Name = "comboBoxQType";
            this.comboBoxQType.Size = new System.Drawing.Size(152, 21);
            this.comboBoxQType.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Y;";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(103, 189);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(151, 20);
            this.textBoxX.TabIndex = 11;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(103, 215);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(151, 20);
            this.textBoxY.TabIndex = 12;
            // 
            // checkBoxIsFirst
            // 
            this.checkBoxIsFirst.AutoSize = true;
            this.checkBoxIsFirst.Location = new System.Drawing.Point(187, 34);
            this.checkBoxIsFirst.Name = "checkBoxIsFirst";
            this.checkBoxIsFirst.Size = new System.Drawing.Size(68, 17);
            this.checkBoxIsFirst.TabIndex = 13;
            this.checkBoxIsFirst.Text = "Pierwsze";
            this.checkBoxIsFirst.UseVisualStyleBackColor = true;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(133, 327);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFrom.TabIndex = 14;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(133, 357);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Do:";
            // 
            // buttonmakeConnection
            // 
            this.buttonmakeConnection.Location = new System.Drawing.Point(133, 414);
            this.buttonmakeConnection.Name = "buttonmakeConnection";
            this.buttonmakeConnection.Size = new System.Drawing.Size(121, 23);
            this.buttonmakeConnection.TabIndex = 15;
            this.buttonmakeConnection.Text = "Stwórz połączenie";
            this.buttonmakeConnection.UseVisualStyleBackColor = true;
            this.buttonmakeConnection.Click += new System.EventHandler(this.buttonmakeConnection_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Pokaż formularz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxProbability
            // 
            this.textBoxProbability.Location = new System.Drawing.Point(133, 388);
            this.textBoxProbability.Name = "textBoxProbability";
            this.textBoxProbability.Size = new System.Drawing.Size(121, 20);
            this.textBoxProbability.TabIndex = 18;
            this.textBoxProbability.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Prawdopodobieństwo\r\nprzejścia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Parametry:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Gniazdo:";
            // 
            // textBoxNormGenProb
            // 
            this.textBoxNormGenProb.Location = new System.Drawing.Point(518, 75);
            this.textBoxNormGenProb.Name = "textBoxNormGenProb";
            this.textBoxNormGenProb.Size = new System.Drawing.Size(121, 20);
            this.textBoxNormGenProb.TabIndex = 22;
            this.textBoxNormGenProb.Text = "60";
            // 
            // textBoxUnifGenProb
            // 
            this.textBoxUnifGenProb.Location = new System.Drawing.Point(518, 104);
            this.textBoxUnifGenProb.Name = "textBoxUnifGenProb";
            this.textBoxUnifGenProb.Size = new System.Drawing.Size(121, 20);
            this.textBoxUnifGenProb.TabIndex = 23;
            this.textBoxUnifGenProb.Text = "60";
            // 
            // textBoxNormMean
            // 
            this.textBoxNormMean.Location = new System.Drawing.Point(507, 163);
            this.textBoxNormMean.Name = "textBoxNormMean";
            this.textBoxNormMean.Size = new System.Drawing.Size(132, 20);
            this.textBoxNormMean.TabIndex = 24;
            this.textBoxNormMean.Text = "10";
            // 
            // textBoxNormStd
            // 
            this.textBoxNormStd.Location = new System.Drawing.Point(507, 189);
            this.textBoxNormStd.Name = "textBoxNormStd";
            this.textBoxNormStd.Size = new System.Drawing.Size(132, 20);
            this.textBoxNormStd.TabIndex = 25;
            this.textBoxNormStd.Text = "5";
            // 
            // textBoxUnifMin
            // 
            this.textBoxUnifMin.Location = new System.Drawing.Point(507, 250);
            this.textBoxUnifMin.Name = "textBoxUnifMin";
            this.textBoxUnifMin.Size = new System.Drawing.Size(132, 20);
            this.textBoxUnifMin.TabIndex = 26;
            this.textBoxUnifMin.Text = "8";
            // 
            // textBoxUnifMax
            // 
            this.textBoxUnifMax.Location = new System.Drawing.Point(507, 276);
            this.textBoxUnifMax.Multiline = true;
            this.textBoxUnifMax.Name = "textBoxUnifMax";
            this.textBoxUnifMax.Size = new System.Drawing.Size(132, 20);
            this.textBoxUnifMax.TabIndex = 27;
            this.textBoxUnifMax.Text = "12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(395, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Prawd. generacji norm.:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(395, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Prawd. generacji jedno.:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(395, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Wartość oczekiwana:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(395, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Odchylenie std.:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(395, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Minimum:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(395, 279);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Maksimum:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Wyczyść formularz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(518, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 21);
            this.button4.TabIndex = 35;
            this.button4.Text = "Aktualizuj parametry";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Położenie:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 304);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Połączenie:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(395, 141);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "Rozkład normalny:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(395, 226);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 13);
            this.label21.TabIndex = 38;
            this.label21.Text = "Rozkład jednostajny:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szybkaInicjalizacjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // szybkaInicjalizacjaToolStripMenuItem
            // 
            this.szybkaInicjalizacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.szybkaInicjalizacjaToolStripMenuItem.Name = "szybkaInicjalizacjaToolStripMenuItem";
            this.szybkaInicjalizacjaToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.szybkaInicjalizacjaToolStripMenuItem.Text = "Szybka inicjalizacja";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // FormInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 466);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxUnifMax);
            this.Controls.Add(this.textBoxUnifMin);
            this.Controls.Add(this.textBoxNormStd);
            this.Controls.Add(this.textBoxNormMean);
            this.Controls.Add(this.textBoxUnifGenProb);
            this.Controls.Add(this.textBoxNormGenProb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxProbability);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonmakeConnection);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.checkBoxIsFirst);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxQType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNrOfDevices);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAddSocket);
            this.Controls.Add(this.textBoxQSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInit";
            this.Text = "Inicjalizacja";
            this.Load += new System.EventHandler(this.FormInit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQSize;
        private System.Windows.Forms.Button buttonAddSocket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNrOfDevices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxQType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.CheckBox checkBoxIsFirst;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonmakeConnection;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxProbability;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNormGenProb;
        private System.Windows.Forms.TextBox textBoxUnifGenProb;
        private System.Windows.Forms.TextBox textBoxNormMean;
        private System.Windows.Forms.TextBox textBoxNormStd;
        private System.Windows.Forms.TextBox textBoxUnifMin;
        private System.Windows.Forms.TextBox textBoxUnifMax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szybkaInicjalizacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}