namespace Kolejki
{
    partial class FormInitialize
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
            this.buttonAddSocket = new System.Windows.Forms.Button();
            this.buttonMakeConn = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonFastInitialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddSocket
            // 
            this.buttonAddSocket.Location = new System.Drawing.Point(35, 36);
            this.buttonAddSocket.Name = "buttonAddSocket";
            this.buttonAddSocket.Size = new System.Drawing.Size(207, 23);
            this.buttonAddSocket.TabIndex = 0;
            this.buttonAddSocket.Text = "Add socket";
            this.buttonAddSocket.UseVisualStyleBackColor = true;
            this.buttonAddSocket.Click += new System.EventHandler(this.buttonAddSocket_Click);
            // 
            // buttonMakeConn
            // 
            this.buttonMakeConn.Location = new System.Drawing.Point(35, 65);
            this.buttonMakeConn.Name = "buttonMakeConn";
            this.buttonMakeConn.Size = new System.Drawing.Size(207, 23);
            this.buttonMakeConn.TabIndex = 1;
            this.buttonMakeConn.Text = "Make connections between sockets";
            this.buttonMakeConn.UseVisualStyleBackColor = true;
            this.buttonMakeConn.Click += new System.EventHandler(this.buttonMakeConn_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(35, 94);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(207, 23);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonFastInitialize
            // 
            this.buttonFastInitialize.Location = new System.Drawing.Point(275, 36);
            this.buttonFastInitialize.Name = "buttonFastInitialize";
            this.buttonFastInitialize.Size = new System.Drawing.Size(171, 23);
            this.buttonFastInitialize.TabIndex = 3;
            this.buttonFastInitialize.Text = "fast initialize";
            this.buttonFastInitialize.UseVisualStyleBackColor = true;
            this.buttonFastInitialize.Click += new System.EventHandler(this.buttonFastInitialize_Click);
            // 
            // FormInitialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 149);
            this.Controls.Add(this.buttonFastInitialize);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonMakeConn);
            this.Controls.Add(this.buttonAddSocket);
            this.Name = "FormInitialize";
            this.Text = "FormInitialize";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddSocket;
        private System.Windows.Forms.Button buttonMakeConn;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonFastInitialize;
    }
}