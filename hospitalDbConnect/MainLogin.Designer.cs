namespace hospitalDbConnect
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.loginpanel = new System.Windows.Forms.Panel();
            this.Appsubmit = new System.Windows.Forms.Button();
            this.receptbutt = new System.Windows.Forms.Button();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.AliceBlue;
            this.loginpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginpanel.BackgroundImage")));
            this.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginpanel.Controls.Add(this.Appsubmit);
            this.loginpanel.Controls.Add(this.receptbutt);
            this.loginpanel.Location = new System.Drawing.Point(18, 11);
            this.loginpanel.Margin = new System.Windows.Forms.Padding(2);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(896, 493);
            this.loginpanel.TabIndex = 2;
            // 
            // Appsubmit
            // 
            this.Appsubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Appsubmit.BackColor = System.Drawing.Color.AliceBlue;
            this.Appsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Appsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Appsubmit.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.Appsubmit.Location = new System.Drawing.Point(79, 375);
            this.Appsubmit.Margin = new System.Windows.Forms.Padding(2);
            this.Appsubmit.Name = "Appsubmit";
            this.Appsubmit.Padding = new System.Windows.Forms.Padding(3);
            this.Appsubmit.Size = new System.Drawing.Size(148, 42);
            this.Appsubmit.TabIndex = 41;
            this.Appsubmit.Text = "Admin";
            this.Appsubmit.UseVisualStyleBackColor = false;
            this.Appsubmit.Click += new System.EventHandler(this.Appsubmit_Click);
            // 
            // receptbutt
            // 
            this.receptbutt.BackColor = System.Drawing.Color.AliceBlue;
            this.receptbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receptbutt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.receptbutt.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.receptbutt.Location = new System.Drawing.Point(79, 295);
            this.receptbutt.Margin = new System.Windows.Forms.Padding(2);
            this.receptbutt.Name = "receptbutt";
            this.receptbutt.Padding = new System.Windows.Forms.Padding(3);
            this.receptbutt.Size = new System.Drawing.Size(148, 42);
            this.receptbutt.TabIndex = 42;
            this.receptbutt.Text = "Receptionist ";
            this.receptbutt.UseVisualStyleBackColor = false;
            this.receptbutt.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 529);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.loginpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Button receptbutt;
        private System.Windows.Forms.Button Appsubmit;
    }
}