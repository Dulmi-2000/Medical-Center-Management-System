namespace hospitalDbConnect.userC
{
    partial class adminlogin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminlogin1));
            this.adpass = new System.Windows.Forms.TextBox();
            this.aduser = new System.Windows.Forms.TextBox();
            this.adlogclear = new System.Windows.Forms.Button();
            this.ADMINsubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adpass
            // 
            this.adpass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adpass.Location = new System.Drawing.Point(294, 294);
            this.adpass.Margin = new System.Windows.Forms.Padding(2);
            this.adpass.Name = "adpass";
            this.adpass.Size = new System.Drawing.Size(217, 26);
            this.adpass.TabIndex = 64;
            this.adpass.UseSystemPasswordChar = true;
            // 
            // aduser
            // 
            this.aduser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aduser.Location = new System.Drawing.Point(294, 234);
            this.aduser.Margin = new System.Windows.Forms.Padding(2);
            this.aduser.Name = "aduser";
            this.aduser.Size = new System.Drawing.Size(217, 26);
            this.aduser.TabIndex = 63;
            // 
            // adlogclear
            // 
            this.adlogclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adlogclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adlogclear.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.adlogclear.Location = new System.Drawing.Point(411, 391);
            this.adlogclear.Margin = new System.Windows.Forms.Padding(2);
            this.adlogclear.Name = "adlogclear";
            this.adlogclear.Padding = new System.Windows.Forms.Padding(3);
            this.adlogclear.Size = new System.Drawing.Size(100, 42);
            this.adlogclear.TabIndex = 62;
            this.adlogclear.Text = "Clear";
            this.adlogclear.UseVisualStyleBackColor = true;
            this.adlogclear.Click += new System.EventHandler(this.adlogclear_Click);
            // 
            // ADMINsubmit
            // 
            this.ADMINsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADMINsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADMINsubmit.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.ADMINsubmit.Location = new System.Drawing.Point(250, 391);
            this.ADMINsubmit.Margin = new System.Windows.Forms.Padding(2);
            this.ADMINsubmit.Name = "ADMINsubmit";
            this.ADMINsubmit.Padding = new System.Windows.Forms.Padding(3);
            this.ADMINsubmit.Size = new System.Drawing.Size(100, 42);
            this.ADMINsubmit.TabIndex = 61;
            this.ADMINsubmit.Text = "Login";
            this.ADMINsubmit.UseVisualStyleBackColor = true;
            this.ADMINsubmit.Click += new System.EventHandler(this.Appsubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(116, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 60;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(116, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "User Name";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.adpass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.aduser);
            this.panel1.Controls.Add(this.ADMINsubmit);
            this.panel1.Controls.Add(this.adlogclear);
            this.panel1.Location = new System.Drawing.Point(-1, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 565);
            this.panel1.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 65;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminlogin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "adminlogin1";
            this.Size = new System.Drawing.Size(824, 472);
            this.Load += new System.EventHandler(this.adminlogin1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox adpass;
        private System.Windows.Forms.TextBox aduser;
        private System.Windows.Forms.Button adlogclear;
        private System.Windows.Forms.Button ADMINsubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}
