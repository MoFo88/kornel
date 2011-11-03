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
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue2)).BeginInit();
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
            this.richTextBox.Location = new System.Drawing.Point(12, 41);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1108, 127);
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
            this.dgvJobs.Size = new System.Drawing.Size(75, 434);
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
            this.dgvQueue1.Size = new System.Drawing.Size(75, 186);
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
            this.dgvDevice1.Location = new System.Drawing.Point(254, 195);
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
            this.dgvDevice2.Location = new System.Drawing.Point(254, 250);
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
            this.dgvDevice3.Location = new System.Drawing.Point(496, 195);
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
            this.dgvQueue2.Size = new System.Drawing.Size(75, 186);
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
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 641);
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
            this.ResumeLayout(false);

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
    }
}

