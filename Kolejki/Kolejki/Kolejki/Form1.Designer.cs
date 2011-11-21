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
            this.QuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgQCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSockets = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxTimeInterval = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wartość = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
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
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(287, 675);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1085, 75);
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
            this.dgvStatsDevice.Location = new System.Drawing.Point(8, 334);
            this.dgvStatsDevice.Name = "dgvStatsDevice";
            this.dgvStatsDevice.RowHeadersVisible = false;
            this.dgvStatsDevice.Size = new System.Drawing.Size(273, 205);
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
            this.dgvStatsQueue.Location = new System.Drawing.Point(8, 545);
            this.dgvStatsQueue.Name = "dgvStatsQueue";
            this.dgvStatsQueue.RowHeadersVisible = false;
            this.dgvStatsQueue.Size = new System.Drawing.Size(273, 205);
            this.dgvStatsQueue.TabIndex = 23;
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
            // panelSockets
            // 
            this.panelSockets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSockets.AutoScroll = true;
            this.panelSockets.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSockets.Location = new System.Drawing.Point(287, 12);
            this.panelSockets.Name = "panelSockets";
            this.panelSockets.Size = new System.Drawing.Size(1085, 657);
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
            // textBoxTimeInterval
            // 
            this.textBoxTimeInterval.Location = new System.Drawing.Point(12, 52);
            this.textBoxTimeInterval.Name = "textBoxTimeInterval";
            this.textBoxTimeInterval.Size = new System.Drawing.Size(118, 20);
            this.textBoxTimeInterval.TabIndex = 37;
            this.textBoxTimeInterval.Text = "1000\r\n";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "Aktualizuj odstęp czasu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvStats
            // 
            this.dgvStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.Wartość});
            this.dgvStats.Location = new System.Drawing.Point(8, 78);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.RowHeadersVisible = false;
            this.dgvStats.Size = new System.Drawing.Size(273, 250);
            this.dgvStats.TabIndex = 39;
            // 
            // Nazwa
            // 
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // Wartość
            // 
            this.Wartość.HeaderText = "Wartość";
            this.Wartość.Name = "Wartość";
            this.Wartość.ReadOnly = true;
            // 
            // devId
            // 
            this.devId.HeaderText = "ID maszyny";
            this.devId.MaxInputLength = 100;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 762);
            this.Controls.Add(this.dgvStats);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBoxTimeInterval);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelSockets);
            this.Controls.Add(this.dgvStatsQueue);
            this.Controls.Add(this.dgvStatsDevice);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Formularz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxTimeInterval;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgQCount;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wartość;
        private System.Windows.Forms.DataGridViewTextBoxColumn devId;
        private System.Windows.Forms.DataGridViewTextBoxColumn allW;
        private System.Windows.Forms.DataGridViewTextBoxColumn allB;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgW;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgB;
    }
}

