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
            this.button1 = new System.Windows.Forms.Button();
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
            this.textBoxTimeInterval = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Queue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size:";
            // 
            // textBoxQSize
            // 
            this.textBoxQSize.Location = new System.Drawing.Point(104, 86);
            this.textBoxQSize.Name = "textBoxQSize";
            this.textBoxQSize.Size = new System.Drawing.Size(151, 20);
            this.textBoxQSize.TabIndex = 3;
            // 
            // buttonAddSocket
            // 
            this.buttonAddSocket.Location = new System.Drawing.Point(179, 248);
            this.buttonAddSocket.Name = "buttonAddSocket";
            this.buttonAddSocket.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSocket.TabIndex = 4;
            this.buttonAddSocket.Text = "add socket";
            this.buttonAddSocket.UseVisualStyleBackColor = true;
            this.buttonAddSocket.Click += new System.EventHandler(this.buttonAddSocket_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nr of devices:";
            // 
            // textBoxNrOfDevices
            // 
            this.textBoxNrOfDevices.Location = new System.Drawing.Point(103, 115);
            this.textBoxNrOfDevices.Name = "textBoxNrOfDevices";
            this.textBoxNrOfDevices.Size = new System.Drawing.Size(151, 20);
            this.textBoxNrOfDevices.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Queue type:";
            // 
            // comboBoxQType
            // 
            this.comboBoxQType.FormattingEnabled = true;
            this.comboBoxQType.Location = new System.Drawing.Point(103, 145);
            this.comboBoxQType.Name = "comboBoxQType";
            this.comboBoxQType.Size = new System.Drawing.Size(152, 21);
            this.comboBoxQType.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Y;";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(103, 183);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(151, 20);
            this.textBoxX.TabIndex = 11;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(103, 211);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(151, 20);
            this.textBoxY.TabIndex = 12;
            // 
            // checkBoxIsFirst
            // 
            this.checkBoxIsFirst.AutoSize = true;
            this.checkBoxIsFirst.Location = new System.Drawing.Point(198, 34);
            this.checkBoxIsFirst.Name = "checkBoxIsFirst";
            this.checkBoxIsFirst.Size = new System.Drawing.Size(56, 17);
            this.checkBoxIsFirst.TabIndex = 13;
            this.checkBoxIsFirst.Text = "Is First";
            this.checkBoxIsFirst.UseVisualStyleBackColor = true;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(133, 315);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFrom.TabIndex = 14;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(133, 345);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "To:";
            // 
            // buttonmakeConnection
            // 
            this.buttonmakeConnection.Location = new System.Drawing.Point(133, 402);
            this.buttonmakeConnection.Name = "buttonmakeConnection";
            this.buttonmakeConnection.Size = new System.Drawing.Size(121, 23);
            this.buttonmakeConnection.TabIndex = 15;
            this.buttonmakeConnection.Text = "Make connection";
            this.buttonmakeConnection.UseVisualStyleBackColor = true;
            this.buttonmakeConnection.Click += new System.EventHandler(this.buttonmakeConnection_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Fast initialize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Show form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxProbability
            // 
            this.textBoxProbability.Location = new System.Drawing.Point(133, 376);
            this.textBoxProbability.Name = "textBoxProbability";
            this.textBoxProbability.Size = new System.Drawing.Size(121, 20);
            this.textBoxProbability.TabIndex = 18;
            this.textBoxProbability.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Probability:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Parameters:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Socket:";
            // 
            // textBoxNormGenProb
            // 
            this.textBoxNormGenProb.Location = new System.Drawing.Point(507, 82);
            this.textBoxNormGenProb.Name = "textBoxNormGenProb";
            this.textBoxNormGenProb.Size = new System.Drawing.Size(132, 20);
            this.textBoxNormGenProb.TabIndex = 22;
            this.textBoxNormGenProb.Text = "15";
            // 
            // textBoxUnifGenProb
            // 
            this.textBoxUnifGenProb.Location = new System.Drawing.Point(507, 115);
            this.textBoxUnifGenProb.Name = "textBoxUnifGenProb";
            this.textBoxUnifGenProb.Size = new System.Drawing.Size(132, 20);
            this.textBoxUnifGenProb.TabIndex = 23;
            this.textBoxUnifGenProb.Text = "25";
            // 
            // textBoxNormMean
            // 
            this.textBoxNormMean.Location = new System.Drawing.Point(507, 148);
            this.textBoxNormMean.Name = "textBoxNormMean";
            this.textBoxNormMean.Size = new System.Drawing.Size(132, 20);
            this.textBoxNormMean.TabIndex = 24;
            this.textBoxNormMean.Text = "6";
            // 
            // textBoxNormStd
            // 
            this.textBoxNormStd.Location = new System.Drawing.Point(507, 183);
            this.textBoxNormStd.Name = "textBoxNormStd";
            this.textBoxNormStd.Size = new System.Drawing.Size(132, 20);
            this.textBoxNormStd.TabIndex = 25;
            this.textBoxNormStd.Text = "10";
            // 
            // textBoxUnifMin
            // 
            this.textBoxUnifMin.Location = new System.Drawing.Point(507, 214);
            this.textBoxUnifMin.Name = "textBoxUnifMin";
            this.textBoxUnifMin.Size = new System.Drawing.Size(132, 20);
            this.textBoxUnifMin.TabIndex = 26;
            this.textBoxUnifMin.Text = "2";
            // 
            // textBoxUnifMax
            // 
            this.textBoxUnifMax.Location = new System.Drawing.Point(507, 248);
            this.textBoxUnifMax.Name = "textBoxUnifMax";
            this.textBoxUnifMax.Size = new System.Drawing.Size(132, 20);
            this.textBoxUnifMax.TabIndex = 27;
            this.textBoxUnifMax.Text = "7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(395, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Norm. generate prob:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(395, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Unif. generate prob:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(395, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Norm. mean: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(395, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Norm. std:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(395, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Unif. min:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(395, 251);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Unif. max:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Empty scheduler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(518, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 21);
            this.button4.TabIndex = 35;
            this.button4.Text = "Update parameters";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxTimeInterval
            // 
            this.textBoxTimeInterval.Location = new System.Drawing.Point(507, 282);
            this.textBoxTimeInterval.Name = "textBoxTimeInterval";
            this.textBoxTimeInterval.Size = new System.Drawing.Size(132, 20);
            this.textBoxTimeInterval.TabIndex = 36;
            this.textBoxTimeInterval.Text = "1000";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(395, 285);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Time interval:";
            // 
            // FormInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 448);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxTimeInterval);
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
            this.Controls.Add(this.button1);
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
            this.Name = "FormInit";
            this.Text = "FormInit";
            this.Load += new System.EventHandler(this.FormInit_Load);
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
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.TextBox textBoxTimeInterval;
        private System.Windows.Forms.Label label18;
    }
}