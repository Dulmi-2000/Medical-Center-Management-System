namespace hospitalDbConnect.userC
{
    partial class sms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sms));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnum = new System.Windows.Forms.TextBox();
            this.smscancel = new System.Windows.Forms.Button();
            this.Appsubmit = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(76, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 70);
            this.panel2.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(392, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Message Sending";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pnum);
            this.panel1.Controls.Add(this.smscancel);
            this.panel1.Controls.Add(this.Appsubmit);
            this.panel1.Controls.Add(this.message);
            this.panel1.Location = new System.Drawing.Point(76, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 525);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(149, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(149, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Message";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pnum
            // 
            this.pnum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnum.Location = new System.Drawing.Point(373, 49);
            this.pnum.Margin = new System.Windows.Forms.Padding(2);
            this.pnum.Name = "pnum";
            this.pnum.Size = new System.Drawing.Size(530, 26);
            this.pnum.TabIndex = 32;
            // 
            // smscancel
            // 
            this.smscancel.BackColor = System.Drawing.Color.AliceBlue;
            this.smscancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smscancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.smscancel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.smscancel.Location = new System.Drawing.Point(794, 445);
            this.smscancel.Margin = new System.Windows.Forms.Padding(2);
            this.smscancel.Name = "smscancel";
            this.smscancel.Padding = new System.Windows.Forms.Padding(3);
            this.smscancel.Size = new System.Drawing.Size(116, 42);
            this.smscancel.TabIndex = 41;
            this.smscancel.Text = "Clear";
            this.smscancel.UseVisualStyleBackColor = false;
            this.smscancel.Click += new System.EventHandler(this.smscancel_Click);
            // 
            // Appsubmit
            // 
            this.Appsubmit.BackColor = System.Drawing.Color.AliceBlue;
            this.Appsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Appsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Appsubmit.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.Appsubmit.Location = new System.Drawing.Point(585, 445);
            this.Appsubmit.Margin = new System.Windows.Forms.Padding(2);
            this.Appsubmit.Name = "Appsubmit";
            this.Appsubmit.Padding = new System.Windows.Forms.Padding(3);
            this.Appsubmit.Size = new System.Drawing.Size(116, 42);
            this.Appsubmit.TabIndex = 40;
            this.Appsubmit.Text = "Send";
            this.Appsubmit.UseVisualStyleBackColor = false;
            this.Appsubmit.Click += new System.EventHandler(this.Appsubmit_Click);
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(153, 144);
            this.message.Margin = new System.Windows.Forms.Padding(2);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(750, 236);
            this.message.TabIndex = 30;
            // 
            // sms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "sms";
            this.Size = new System.Drawing.Size(1244, 678);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pnum;
        private System.Windows.Forms.Button smscancel;
        private System.Windows.Forms.Button Appsubmit;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label label1;
    }
}
