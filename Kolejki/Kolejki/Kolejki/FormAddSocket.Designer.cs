namespace Kolejki
{
    partial class FormAddSocket
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQueueName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxQueueType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQueueSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNrOfDev = new System.Windows.Forms.TextBox();
            this.buttonAddSocket = new System.Windows.Forms.Button();
            this.checkBoxIsFirst = new System.Windows.Forms.CheckBox();
            this.textBoxRow = new System.Windows.Forms.TextBox();
            this.textBoxColl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(114, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(173, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Queue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Queue name:";
            // 
            // textBoxQueueName
            // 
            this.textBoxQueueName.Location = new System.Drawing.Point(114, 103);
            this.textBoxQueueName.Name = "textBoxQueueName";
            this.textBoxQueueName.Size = new System.Drawing.Size(173, 20);
            this.textBoxQueueName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Queue type:";
            // 
            // comboBoxQueueType
            // 
            this.comboBoxQueueType.FormattingEnabled = true;
            this.comboBoxQueueType.Location = new System.Drawing.Point(114, 138);
            this.comboBoxQueueType.Name = "comboBoxQueueType";
            this.comboBoxQueueType.Size = new System.Drawing.Size(173, 21);
            this.comboBoxQueueType.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Queue size:";
            // 
            // textBoxQueueSize
            // 
            this.textBoxQueueSize.Location = new System.Drawing.Point(114, 176);
            this.textBoxQueueSize.Name = "textBoxQueueSize";
            this.textBoxQueueSize.Size = new System.Drawing.Size(173, 20);
            this.textBoxQueueSize.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nr of devies:";
            // 
            // textBoxNrOfDev
            // 
            this.textBoxNrOfDev.Location = new System.Drawing.Point(114, 234);
            this.textBoxNrOfDev.Name = "textBoxNrOfDev";
            this.textBoxNrOfDev.Size = new System.Drawing.Size(173, 20);
            this.textBoxNrOfDev.TabIndex = 10;
            // 
            // buttonAddSocket
            // 
            this.buttonAddSocket.Location = new System.Drawing.Point(212, 313);
            this.buttonAddSocket.Name = "buttonAddSocket";
            this.buttonAddSocket.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSocket.TabIndex = 11;
            this.buttonAddSocket.Text = "Add";
            this.buttonAddSocket.UseVisualStyleBackColor = true;
            this.buttonAddSocket.Click += new System.EventHandler(this.buttonAddSocket_Click);
            // 
            // checkBoxIsFirst
            // 
            this.checkBoxIsFirst.AutoSize = true;
            this.checkBoxIsFirst.Location = new System.Drawing.Point(18, 278);
            this.checkBoxIsFirst.Name = "checkBoxIsFirst";
            this.checkBoxIsFirst.Size = new System.Drawing.Size(53, 17);
            this.checkBoxIsFirst.TabIndex = 12;
            this.checkBoxIsFirst.Text = "Is first";
            this.checkBoxIsFirst.UseVisualStyleBackColor = true;
            // 
            // textBoxRow
            // 
            this.textBoxRow.Location = new System.Drawing.Point(75, 315);
            this.textBoxRow.Name = "textBoxRow";
            this.textBoxRow.Size = new System.Drawing.Size(57, 20);
            this.textBoxRow.TabIndex = 13;
            // 
            // textBoxColl
            // 
            this.textBoxColl.Location = new System.Drawing.Point(18, 315);
            this.textBoxColl.Name = "textBoxColl";
            this.textBoxColl.Size = new System.Drawing.Size(51, 20);
            this.textBoxColl.TabIndex = 14;
            // 
            // FormAddSocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 358);
            this.Controls.Add(this.textBoxColl);
            this.Controls.Add(this.textBoxRow);
            this.Controls.Add(this.checkBoxIsFirst);
            this.Controls.Add(this.buttonAddSocket);
            this.Controls.Add(this.textBoxNrOfDev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxQueueSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxQueueType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQueueName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddSocket";
            this.Text = "FormAddSocket";
            this.Load += new System.EventHandler(this.FormAddSocket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQueueName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxQueueType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQueueSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNrOfDev;
        private System.Windows.Forms.Button buttonAddSocket;
        private System.Windows.Forms.CheckBox checkBoxIsFirst;
        private System.Windows.Forms.TextBox textBoxRow;
        private System.Windows.Forms.TextBox textBoxColl;
    }
}