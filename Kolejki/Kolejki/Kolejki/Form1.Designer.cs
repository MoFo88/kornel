namespace Kolejki
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvStatsDevice = new System.Windows.Forms.DataGridView();
            this.dgvStatsQueue = new System.Windows.Forms.DataGridView();
            this.panelSockets = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelJobsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKilledJobsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMaxTimeInSystem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAvgTimeInSystem = new System.Windows.Forms.Label();
            this.textBoxTimeInterval = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.devId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgQCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Krok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox.Location = new System.Drawing.Point(12, 41);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(269, 56);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvStatsDevice
            // 
            this.dgvStatsDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvStatsDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatsDevice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvStatsDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.devId,
            this.allW,
            this.allB,
            this.avgW,
            this.avgB});
            this.dgvStatsDevice.Location = new System.Drawing.Point(12, 103);
            this.dgvStatsDevice.Name = "dgvStatsDevice";
            this.dgvStatsDevice.RowHeadersVisible = false;
            this.dgvStatsDevice.Size = new System.Drawing.Size(269, 148);
            this.dgvStatsDevice.TabIndex = 22;
            // 
            // dgvStatsQueue
            // 
            this.dgvStatsQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvStatsQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatsQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuId,
            this.AvgTime,
            this.sumT,
            this.maxT,
            this.maxCount,
            this.avgQCount});
            this.dgvStatsQueue.Location = new System.Drawing.Point(12, 257);
            this.dgvStatsQueue.Name = "dgvStatsQueue";
            this.dgvStatsQueue.RowHeadersVisible = false;
            this.dgvStatsQueue.Size = new System.Drawing.Size(269, 148);
            this.dgvStatsQueue.TabIndex = 23;
            // 
            // panelSockets
            // 
            this.panelSockets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSockets.AutoScroll = true;
            this.panelSockets.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSockets.Location = new System.Drawing.Point(287, 12);
            this.panelSockets.Name = "panelSockets";
            this.panelSockets.Size = new System.Drawing.Size(729, 510);
            this.panelSockets.TabIndex = 24;
            this.panelSockets.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSockets_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Zdarzenie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(206, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Pauza";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Liczba zadań:";
            // 
            // labelJobsCount
            // 
            this.labelJobsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelJobsCount.AutoSize = true;
            this.labelJobsCount.Location = new System.Drawing.Point(81, 454);
            this.labelJobsCount.Name = "labelJobsCount";
            this.labelJobsCount.Size = new System.Drawing.Size(35, 13);
            this.labelJobsCount.TabIndex = 29;
            this.labelJobsCount.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Liczba zabitych zadań:";
            // 
            // labelKilledJobsCount
            // 
            this.labelKilledJobsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKilledJobsCount.AutoSize = true;
            this.labelKilledJobsCount.Location = new System.Drawing.Point(242, 454);
            this.labelKilledJobsCount.Name = "labelKilledJobsCount";
            this.labelKilledJobsCount.Size = new System.Drawing.Size(35, 13);
            this.labelKilledJobsCount.TabIndex = 31;
            this.labelKilledJobsCount.Text = "label4";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Maks. czas w systemie:";
            // 
            // labelMaxTimeInSystem
            // 
            this.labelMaxTimeInSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMaxTimeInSystem.AutoSize = true;
            this.labelMaxTimeInSystem.Location = new System.Drawing.Point(134, 483);
            this.labelMaxTimeInSystem.Name = "labelMaxTimeInSystem";
            this.labelMaxTimeInSystem.Size = new System.Drawing.Size(23, 13);
            this.labelMaxTimeInSystem.TabIndex = 34;
            this.labelMaxTimeInSystem.Text = "lbl5";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Średni czas w systemie:";
            // 
            // labelAvgTimeInSystem
            // 
            this.labelAvgTimeInSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAvgTimeInSystem.AutoSize = true;
            this.labelAvgTimeInSystem.Location = new System.Drawing.Point(134, 509);
            this.labelAvgTimeInSystem.Name = "labelAvgTimeInSystem";
            this.labelAvgTimeInSystem.Size = new System.Drawing.Size(114, 13);
            this.labelAvgTimeInSystem.TabIndex = 36;
            this.labelAvgTimeInSystem.Text = "labelAvgTimeInSystem";
            // 
            // textBoxTimeInterval
            // 
            this.textBoxTimeInterval.Location = new System.Drawing.Point(15, 420);
            this.textBoxTimeInterval.Name = "textBoxTimeInterval";
            this.textBoxTimeInterval.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimeInterval.TabIndex = 37;
            this.textBoxTimeInterval.Text = "1000\r\n";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(134, 418);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "Aktualizuj odstęp czasu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // devId
            // 
            this.devId.HeaderText = "ID maszyny";
            this.devId.MaxInputLength = 5;
            this.devId.Name = "devId";
            this.devId.ReadOnly = true;
            // 
            // allW
            // 
            this.allW.HeaderText = "Łączny czas pracy";
            this.allW.MaxInputLength = 5;
            this.allW.Name = "allW";
            // 
            // allB
            // 
            this.allB.HeaderText = "Łączny czas blok.";
            this.allB.MaxInputLength = 5;
            this.allB.Name = "allB";
            // 
            // avgW
            // 
            this.avgW.HeaderText = "Śr. czas pracy";
            this.avgW.MaxInputLength = 5;
            this.avgW.Name = "avgW";
            // 
            // avgB
            // 
            this.avgB.HeaderText = "Śr. czas blok.";
            this.avgB.MaxInputLength = 5;
            this.avgB.Name = "avgB";
            // 
            // QuId
            // 
            this.QuId.HeaderText = "ID Kolejki";
            this.QuId.Name = "QuId";
            // 
            // AvgTime
            // 
            this.AvgTime.HeaderText = "Śr. czas";
            this.AvgTime.Name = "AvgTime";
            // 
            // sumT
            // 
            this.sumT.HeaderText = "Łączny czas";
            this.sumT.Name = "sumT";
            this.sumT.ReadOnly = true;
            // 
            // maxT
            // 
            this.maxT.HeaderText = "Maks. czas";
            this.maxT.Name = "maxT";
            this.maxT.ReadOnly = true;
            // 
            // maxCount
            // 
            this.maxCount.HeaderText = "Maks. liczba zadań";
            this.maxCount.Name = "maxCount";
            // 
            // avgQCount
            // 
            this.avgQCount.HeaderText = "Śr. liczba zadań";
            this.avgQCount.Name = "avgQCount";
            this.avgQCount.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 534);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBoxTimeInterval);
            this.Controls.Add(this.labelAvgTimeInSystem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMaxTimeInSystem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelKilledJobsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelJobsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelSockets);
            this.Controls.Add(this.dgvStatsQueue);
            this.Controls.Add(this.dgvStatsDevice);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Formularz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvStatsDevice;
        private System.Windows.Forms.DataGridView dgvStatsQueue;
        private System.Windows.Forms.Panel panelSockets;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelJobsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelKilledJobsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMaxTimeInSystem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAvgTimeInSystem;
        private System.Windows.Forms.TextBox textBoxTimeInterval;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn devId;
        private System.Windows.Forms.DataGridViewTextBoxColumn allW;
        private System.Windows.Forms.DataGridViewTextBoxColumn allB;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgW;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgB;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgQCount;
    }
}

