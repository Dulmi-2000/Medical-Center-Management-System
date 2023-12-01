namespace hospitalDbConnect.userC
{
    partial class receptlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receptlogin));
            this.rece = new System.Windows.Forms.TextBox();
            this.adlogclear = new System.Windows.Forms.Button();
            this.repsub = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rece
            // 
            this.rece.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rece.Location = new System.Drawing.Point(212, 278);
            this.rece.Margin = new System.Windows.Forms.Padding(2);
            this.rece.Name = "rece";
            this.rece.Size = new System.Drawing.Size(233, 26);
            this.rece.TabIndex = 63;
            // 
            // adlogclear
            // 
            this.adlogclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adlogclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adlogclear.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.adlogclear.Location = new System.Drawing.Point(345, 448);
            this.adlogclear.Margin = new System.Windows.Forms.Padding(2);
            this.adlogclear.Name = "adlogclear";
            this.adlogclear.Padding = new System.Windows.Forms.Padding(3);
            this.adlogclear.Size = new System.Drawing.Size(100, 42);
            this.adlogclear.TabIndex = 62;
            this.adlogclear.Text = "Clear";
            this.adlogclear.UseVisualStyleBackColor = true;
            this.adlogclear.Click += new System.EventHandler(this.adlogclear_Click);
            // 
            // repsub
            // 
            this.repsub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repsub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.repsub.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.repsub.Location = new System.Drawing.Point(212, 448);
            this.repsub.Margin = new System.Windows.Forms.Padding(2);
            this.repsub.Name = "repsub";
            this.repsub.Padding = new System.Windows.Forms.Padding(3);
            this.repsub.Size = new System.Drawing.Size(100, 42);
            this.repsub.TabIndex = 61;
            this.repsub.Text = "Login";
            this.repsub.UseVisualStyleBackColor = true;
            this.repsub.Click += new System.EventHandler(this.repsub_Click);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(212, 355);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(233, 26);
            this.pass.TabIndex = 64;
            this.pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(56, 359);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 60;
            this.label3.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.repsub);
            this.panel2.Controls.Add(this.adlogclear);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pass);
            this.panel2.Controls.Add(this.rece);
            this.panel2.Location = new System.Drawing.Point(-9, -58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 592);
            this.panel2.TabIndex = 66;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(10, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 65;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // receptlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "receptlogin";
            this.Size = new System.Drawing.Size(847, 530);
            this.Load += new System.EventHandler(this.receptlogin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox rece;
        private System.Windows.Forms.Button adlogclear;
        private System.Windows.Forms.Button repsub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}
