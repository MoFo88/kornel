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
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.Job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQueue1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDevice1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDevice2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDevice3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQueue2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDevice5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDevice4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQueue3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDevice7 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDevice6 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQueue4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatsDevice = new System.Windows.Forms.DataGridView();
            this.dgvStatsQueue = new System.Windows.Forms.DataGridView();
            this.devId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Krok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(12, 41);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(389, 148);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvJobs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.ColumnHeadersVisible = false;
            this.dgvJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Job});
            this.dgvJobs.Location = new System.Drawing.Point(12, 195);
            this.dgvJobs.MultiSelect = false;
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.ReadOnly = true;
            this.dgvJobs.RowHeadersVisible = false;
            this.dgvJobs.ShowEditingIcon = false;
            this.dgvJobs.Size = new System.Drawing.Size(75, 375);
            this.dgvJobs.TabIndex = 3;
            // 
            // Job
            // 
            this.Job.HeaderText = "Job";
            this.Job.Name = "Job";
            this.Job.ReadOnly = true;
            // 
            // dgvQueue1
            // 
            this.dgvQueue1.AllowUserToAddRows = false;
            this.dgvQueue1.AllowUserToDeleteRows = false;
            this.dgvQueue1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvQueue1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue1.ColumnHeadersVisible = false;
            this.dgvQueue1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvQueue1.Location = new System.Drawing.Point(173, 195);
            this.dgvQueue1.MultiSelect = false;
            this.dgvQueue1.Name = "dgvQueue1";
            this.dgvQueue1.ReadOnly = true;
            this.dgvQueue1.RowHeadersVisible = false;
            this.dgvQueue1.ShowEditingIcon = false;
            this.dgvQueue1.Size = new System.Drawing.Size(75, 145);
            this.dgvQueue1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Job";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgvDevice1
            // 
            this.dgvDevice1.AllowUserToAddRows = false;
            this.dgvDevice1.AllowUserToDeleteRows = false;
            this.dgvDevice1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDevice1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice1.ColumnHeadersVisible = false;
            this.dgvDevice1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgvDevice1.Location = new System.Drawing.Point(254, 215);
            this.dgvDevice1.MultiSelect = false;
            this.dgvDevice1.Name = "dgvDevice1";
            this.dgvDevice1.ReadOnly = true;
            this.dgvDevice1.RowHeadersVisible = false;
            this.dgvDevice1.ShowEditingIcon = false;
            this.dgvDevice1.Size = new System.Drawing.Size(75, 50);
            this.dgvDevice1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Job";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dgvDevice2
            // 
            this.dgvDevice2.AllowUserToAddRows = false;
            this.dgvDevice2.AllowUserToDeleteRows = false;
            this.dgvDevice2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDevice2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice2.ColumnHeadersVisible = false;
            this.dgvDevice2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.dgvDevice2.Location = new System.Drawing.Point(254, 290);
            this.dgvDevice2.MultiSelect = false;
            this.dgvDevice2.Name = "dgvDevice2";
            this.dgvDevice2.ReadOnly = true;
            this.dgvDevice2.RowHeadersVisible = false;
            this.dgvDevice2.ShowEditingIcon = false;
            this.dgvDevice2.Size = new System.Drawing.Size(75, 50);
            this.dgvDevice2.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Job";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dgvDevice3
            // 
            this.dgvDevice3.AllowUserToAddRows = false;
            this.dgvDevice3.AllowUserToDeleteRows = false;
            this.dgvDevice3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDevice3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice3.ColumnHeadersVisible = false;
            this.dgvDevice3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5});
            this.dgvDevice3.Location = new System.Drawing.Point(496, 215);
            this.dgvDevice3.MultiSelect = false;
            this.dgvDevice3.Name = "dgvDevice3";
            this.dgvDevice3.ReadOnly = true;
            this.dgvDevice3.RowHeadersVisible = false;
            this.dgvDevice3.ShowEditingIcon = false;
            this.dgvDevice3.Size = new System.Drawing.Size(75, 50);
            this.dgvDevice3.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Job";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dgvQueue2
            // 
            this.dgvQueue2.AllowUserToAddRows = false;
            this.dgvQueue2.AllowUserToDeleteRows = false;
            this.dgvQueue2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvQueue2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue2.ColumnHeadersVisible = false;
            this.dgvQueue2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6});
            this.dgvQueue2.Location = new System.Drawing.Point(405, 195);
            this.dgvQueue2.MultiSelect = false;
            this.dgvQueue2.Name = "dgvQueue2";
            this.dgvQueue2.ReadOnly = true;
            this.dgvQueue2.RowHeadersVisible = false;
            this.dgvQueue2.ShowEditingIcon = false;
            this.dgvQueue2.Size = new System.Drawing.Size(75, 145);
            this.dgvQueue2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Job";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // dgvDevice5
            // 
            this.dgvDevice5.AllowUserToAddRows = false;
            this.dgvDevice5.AllowUserToDeleteRows = false;
            this.dgvDevice5.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDevice5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice5.ColumnHeadersVisible = false;
            this.dgvDevice5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.dgvDevice5.Location = new System.Drawing.Point(486, 480);
            this.dgvDevice5.MultiSelect = false;
            this.dgvDevice5.Name = "dgvDevice5";
            this.dgvDevice5.ReadOnly = true;
            this.dgvDevice5.RowHeadersVisible = false;
            this.dgvDevice5.ShowEditingIcon = false;
            this.dgvDevice5.Size = new System.Drawing.Size(75, 50);
            this.dgvDevice5.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Job";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dgvDevice4
            // 
            this.dgvDevice4.AllowUserToAddRows = false;
            this.dgvDevice4.AllowUserToDeleteRows = false;
            this.dgvDevice4.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDevice4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice4.ColumnHeadersVisible = false;
            this.dgvDevice4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7});
            this.dgvDevice4.Location = new System.Drawing.Point(486, 405);
            this.dgvDevice4.MultiSelect = false;
            this.dgvDevice4.Name = "dgvDevice4";
            this.dgvDevice4.ReadOnly = true;
            this.dgvDevice4.RowHeadersVisible = false;
            this.dgvDevice4.ShowEditingIcon = false;
            this.dgvDevice4.Size = new System.Drawing.Size(75, 50);
            this.dgvDevice4.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Job";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dgvQueue3
            // 
            this.dgvQueue3.AllowUserToAddRows = false;
            this.dgvQueue3.AllowUserToDeleteRows = false;
            this.dgvQueue3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvQueue3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue3.ColumnHeadersVisible = false;
            this.dgvQueue3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8});
            this.dgvQueue3.Location = new System.Drawing.Point(405, 385);
            this.dgvQueue3.MultiSelect = false;
            this.dgvQueue3.Name = "dgvQueue3";
            this.dgvQueue3.ReadOnly = true;
            this.dgvQueue3.RowHeadersVisible = false;
            this.dgvQueue3.ShowEditingIcon = false;
            this.dgvQueue3.Size = new System.Drawing.Size(75, 145);
            this.dgvQueue3.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Job";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(791, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(791, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "label6";
            // 
            // dgvDevice7
            // 
            this.dgvDevice7.AllowUserToAddRows = false;
            this.dgvDevice7.AllowUserToDeleteRows = false;
            this.dgvDevice7.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDevice7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice7.ColumnHeadersVisible = false;
            this.dgvDevice7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9});
            this.dgvDevice7.Location = new System.Drawing.Point(772, 385);
            this.dgvDevice7.MultiSelect = false;
            this.dgvDevice7.Name = "dgvDevice7";
            this.dgvDevice7.ReadOnly = true;
            this.dgvDevice7.RowHeadersVisible = false;
            this.dgvDevice7.ShowEditingIcon = false;
            this.dgvDevice7.Size = new System.Drawing.Size(75, 50);
            this.dgvDevice7.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Job";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dgvDevice6
            // 
            this.dgvDevice6.AllowUserToAddRows = false;
            this.dgvDevice6.AllowUserToDeleteRows = false;
            this.dgvDevice6.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDevice6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice6.ColumnHeadersVisible = false;
            this.dgvDevice6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10});
            this.dgvDevice6.Location = new System.Drawing.Point(772, 310);
            this.dgvDevice6.MultiSelect = false;
            this.dgvDevice6.Name = "dgvDevice6";
            this.dgvDevice6.ReadOnly = true;
            this.dgvDevice6.RowHeadersVisible = false;
            this.dgvDevice6.ShowEditingIcon = false;
            this.dgvDevice6.Size = new System.Drawing.Size(75, 50);
            this.dgvDevice6.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Job";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dgvQueue4
            // 
            this.dgvQueue4.AllowUserToAddRows = false;
            this.dgvQueue4.AllowUserToDeleteRows = false;
            this.dgvQueue4.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvQueue4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue4.ColumnHeadersVisible = false;
            this.dgvQueue4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11});
            this.dgvQueue4.Location = new System.Drawing.Point(691, 290);
            this.dgvQueue4.MultiSelect = false;
            this.dgvQueue4.Name = "dgvQueue4";
            this.dgvQueue4.ReadOnly = true;
            this.dgvQueue4.RowHeadersVisible = false;
            this.dgvQueue4.ShowEditingIcon = false;
            this.dgvQueue4.Size = new System.Drawing.Size(75, 145);
            this.dgvQueue4.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Job";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dgvStatsDevice
            // 
            this.dgvStatsDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatsDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatsDevice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvStatsDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.devId,
            this.allW,
            this.allB,
            this.avgW,
            this.avgB});
            this.dgvStatsDevice.Location = new System.Drawing.Point(416, 41);
            this.dgvStatsDevice.Name = "dgvStatsDevice";
            this.dgvStatsDevice.RowHeadersVisible = false;
            this.dgvStatsDevice.Size = new System.Drawing.Size(269, 148);
            this.dgvStatsDevice.TabIndex = 22;
            // 
            // dgvStatsQueue
            // 
            this.dgvStatsQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatsQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuId,
            this.AvgTime});
            this.dgvStatsQueue.Location = new System.Drawing.Point(691, 41);
            this.dgvStatsQueue.Name = "dgvStatsQueue";
            this.dgvStatsQueue.Size = new System.Drawing.Size(325, 148);
            this.dgvStatsQueue.TabIndex = 23;
            // 
            // devId
            // 
            this.devId.HeaderText = "dev id";
            this.devId.MaxInputLength = 5;
            this.devId.Name = "devId";
            this.devId.ReadOnly = true;
            // 
            // allW
            // 
            this.allW.HeaderText = "allW";
            this.allW.MaxInputLength = 5;
            this.allW.Name = "allW";
            // 
            // allB
            // 
            this.allB.HeaderText = "allB";
            this.allB.MaxInputLength = 5;
            this.allB.Name = "allB";
            // 
            // avgW
            // 
            this.avgW.HeaderText = "avgW";
            this.avgW.MaxInputLength = 5;
            this.avgW.Name = "avgW";
            // 
            // avgB
            // 
            this.avgB.HeaderText = "avgB";
            this.avgB.MaxInputLength = 5;
            this.avgB.Name = "avgB";
            // 
            // QuId
            // 
            this.QuId.HeaderText = "Qu Id";
            this.QuId.Name = "QuId";
            // 
            // AvgTime
            // 
            this.AvgTime.HeaderText = "avg t";
            this.AvgTime.Name = "AvgTime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 582);
            this.Controls.Add(this.dgvStatsQueue);
            this.Controls.Add(this.dgvStatsDevice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDevice7);
            this.Controls.Add(this.dgvDevice6);
            this.Controls.Add(this.dgvQueue4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDevice5);
            this.Controls.Add(this.dgvDevice4);
            this.Controls.Add(this.dgvQueue3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDevice3);
            this.Controls.Add(this.dgvQueue2);
            this.Controls.Add(this.dgvDevice2);
            this.Controls.Add(this.dgvDevice1);
            this.Controls.Add(this.dgvQueue1);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job;
        private System.Windows.Forms.DataGridView dgvQueue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvDevice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvDevice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgvDevice3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dgvQueue2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDevice5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvDevice4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dgvQueue3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDevice7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView dgvDevice6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridView dgvQueue4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridView dgvStatsDevice;
        private System.Windows.Forms.DataGridView dgvStatsQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn devId;
        private System.Windows.Forms.DataGridViewTextBoxColumn allW;
        private System.Windows.Forms.DataGridViewTextBoxColumn allB;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgW;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgB;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgTime;
    }
}

