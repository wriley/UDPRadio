namespace UDPRadio
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.tbCOM1Active = new System.Windows.Forms.TextBox();
            this.lblCOM1 = new System.Windows.Forms.Label();
            this.tbCOM1Standby = new System.Windows.Forms.TextBox();
            this.tbCOM2Standby = new System.Windows.Forms.TextBox();
            this.lblCOM2 = new System.Windows.Forms.Label();
            this.tbCOM2Active = new System.Windows.Forms.TextBox();
            this.tbSetCOM1Active = new System.Windows.Forms.TextBox();
            this.btnSetCOM1Active = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 114);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1044, 332);
            this.textBox1.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(15, 85);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(96, 85);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // tbCOM1Active
            // 
            this.tbCOM1Active.Location = new System.Drawing.Point(55, 9);
            this.tbCOM1Active.Name = "tbCOM1Active";
            this.tbCOM1Active.ReadOnly = true;
            this.tbCOM1Active.Size = new System.Drawing.Size(60, 20);
            this.tbCOM1Active.TabIndex = 3;
            // 
            // lblCOM1
            // 
            this.lblCOM1.AutoSize = true;
            this.lblCOM1.Location = new System.Drawing.Point(12, 12);
            this.lblCOM1.Name = "lblCOM1";
            this.lblCOM1.Size = new System.Drawing.Size(37, 13);
            this.lblCOM1.TabIndex = 4;
            this.lblCOM1.Text = "COM1";
            // 
            // tbCOM1Standby
            // 
            this.tbCOM1Standby.Location = new System.Drawing.Point(121, 9);
            this.tbCOM1Standby.Name = "tbCOM1Standby";
            this.tbCOM1Standby.ReadOnly = true;
            this.tbCOM1Standby.Size = new System.Drawing.Size(60, 20);
            this.tbCOM1Standby.TabIndex = 5;
            // 
            // tbCOM2Standby
            // 
            this.tbCOM2Standby.Location = new System.Drawing.Point(121, 42);
            this.tbCOM2Standby.Name = "tbCOM2Standby";
            this.tbCOM2Standby.ReadOnly = true;
            this.tbCOM2Standby.Size = new System.Drawing.Size(60, 20);
            this.tbCOM2Standby.TabIndex = 8;
            // 
            // lblCOM2
            // 
            this.lblCOM2.AutoSize = true;
            this.lblCOM2.Location = new System.Drawing.Point(12, 45);
            this.lblCOM2.Name = "lblCOM2";
            this.lblCOM2.Size = new System.Drawing.Size(37, 13);
            this.lblCOM2.TabIndex = 7;
            this.lblCOM2.Text = "COM2";
            // 
            // tbCOM2Active
            // 
            this.tbCOM2Active.Location = new System.Drawing.Point(55, 42);
            this.tbCOM2Active.Name = "tbCOM2Active";
            this.tbCOM2Active.ReadOnly = true;
            this.tbCOM2Active.Size = new System.Drawing.Size(60, 20);
            this.tbCOM2Active.TabIndex = 6;
            // 
            // tbSetCOM1Active
            // 
            this.tbSetCOM1Active.Location = new System.Drawing.Point(352, 12);
            this.tbSetCOM1Active.Name = "tbSetCOM1Active";
            this.tbSetCOM1Active.Size = new System.Drawing.Size(100, 20);
            this.tbSetCOM1Active.TabIndex = 9;
            this.tbSetCOM1Active.Text = "12280";
            // 
            // btnSetCOM1Active
            // 
            this.btnSetCOM1Active.Location = new System.Drawing.Point(458, 10);
            this.btnSetCOM1Active.Name = "btnSetCOM1Active";
            this.btnSetCOM1Active.Size = new System.Drawing.Size(75, 23);
            this.btnSetCOM1Active.TabIndex = 10;
            this.btnSetCOM1Active.Text = "SET COM1";
            this.btnSetCOM1Active.UseVisualStyleBackColor = true;
            this.btnSetCOM1Active.Click += new System.EventHandler(this.btnSetCOM1Active_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 458);
            this.Controls.Add(this.btnSetCOM1Active);
            this.Controls.Add(this.tbSetCOM1Active);
            this.Controls.Add(this.tbCOM2Standby);
            this.Controls.Add(this.lblCOM2);
            this.Controls.Add(this.tbCOM2Active);
            this.Controls.Add(this.tbCOM1Standby);
            this.Controls.Add(this.lblCOM1);
            this.Controls.Add(this.tbCOM1Active);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox tbCOM1Active;
        private System.Windows.Forms.Label lblCOM1;
        private System.Windows.Forms.TextBox tbCOM1Standby;
        private System.Windows.Forms.TextBox tbCOM2Standby;
        private System.Windows.Forms.Label lblCOM2;
        private System.Windows.Forms.TextBox tbCOM2Active;
        private System.Windows.Forms.TextBox tbSetCOM1Active;
        private System.Windows.Forms.Button btnSetCOM1Active;
    }
}

