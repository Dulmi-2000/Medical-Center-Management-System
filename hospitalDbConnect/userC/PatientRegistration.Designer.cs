namespace hospitalDbConnect.userC
{
    partial class Patientregform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patientregform));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.TextBox();
            this.PDate = new System.Windows.Forms.DateTimePicker();
            this.prcancel = new System.Windows.Forms.Button();
            this.Appsubmit = new System.Windows.Forms.Button();
            this.PContact = new System.Windows.Forms.TextBox();
            this.PAge = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(55, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 70);
            this.panel2.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(383, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Patient Registration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.PGender);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PName);
            this.panel1.Controls.Add(this.PDate);
            this.panel1.Controls.Add(this.prcancel);
            this.panel1.Controls.Add(this.Appsubmit);
            this.panel1.Controls.Add(this.PContact);
            this.panel1.Controls.Add(this.PAge);
            this.panel1.Location = new System.Drawing.Point(55, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 525);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PGender
            // 
            this.PGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PGender.FormattingEnabled = true;
            this.PGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PGender.Location = new System.Drawing.Point(384, 317);
            this.PGender.Margin = new System.Windows.Forms.Padding(2);
            this.PGender.Name = "PGender";
            this.PGender.Size = new System.Drawing.Size(218, 26);
            this.PGender.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(185, 249);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 22);
            this.label10.TabIndex = 60;
            this.label10.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 53;
            this.label5.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "Date";
            // 
            // PName
            // 
            this.PName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName.Location = new System.Drawing.Point(384, 41);
            this.PName.Margin = new System.Windows.Forms.Padding(2);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(525, 26);
            this.PName.TabIndex = 32;
            // 
            // PDate
            // 
            this.PDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PDate.Location = new System.Drawing.Point(384, 179);
            this.PDate.Margin = new System.Windows.Forms.Padding(2);
            this.PDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.PDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.PDate.Name = "PDate";
            this.PDate.Size = new System.Drawing.Size(218, 26);
            this.PDate.TabIndex = 42;
            // 
            // prcancel
            // 
            this.prcancel.BackColor = System.Drawing.Color.AliceBlue;
            this.prcancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.prcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prcancel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.prcancel.Location = new System.Drawing.Point(797, 439);
            this.prcancel.Margin = new System.Windows.Forms.Padding(2);
            this.prcancel.Name = "prcancel";
            this.prcancel.Padding = new System.Windows.Forms.Padding(3);
            this.prcancel.Size = new System.Drawing.Size(112, 42);
            this.prcancel.TabIndex = 41;
            this.prcancel.Text = "Clear";
            this.prcancel.UseVisualStyleBackColor = false;
            this.prcancel.Click += new System.EventHandler(this.prcancel_Click);
            // 
            // Appsubmit
            // 
            this.Appsubmit.BackColor = System.Drawing.Color.AliceBlue;
            this.Appsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Appsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Appsubmit.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.Appsubmit.Location = new System.Drawing.Point(579, 439);
            this.Appsubmit.Margin = new System.Windows.Forms.Padding(2);
            this.Appsubmit.Name = "Appsubmit";
            this.Appsubmit.Padding = new System.Windows.Forms.Padding(3);
            this.Appsubmit.Size = new System.Drawing.Size(124, 42);
            this.Appsubmit.TabIndex = 40;
            this.Appsubmit.Text = "Register";
            this.Appsubmit.UseVisualStyleBackColor = false;
            this.Appsubmit.Click += new System.EventHandler(this.Appsubmit_Click);
            // 
            // PContact
            // 
            this.PContact.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PContact.Location = new System.Drawing.Point(384, 249);
            this.PContact.Margin = new System.Windows.Forms.Padding(2);
            this.PContact.Name = "PContact";
            this.PContact.Size = new System.Drawing.Size(525, 26);
            this.PContact.TabIndex = 33;
            // 
            // PAge
            // 
            this.PAge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAge.Location = new System.Drawing.Point(384, 110);
            this.PAge.Margin = new System.Windows.Forms.Padding(2);
            this.PAge.Name = "PAge";
            this.PAge.Size = new System.Drawing.Size(525, 26);
            this.PAge.TabIndex = 30;
            // 
            // Patientregform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Patientregform";
            this.Size = new System.Drawing.Size(1245, 679);
            this.Load += new System.EventHandler(this.Patientregform_Load);
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
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.DateTimePicker PDate;
        private System.Windows.Forms.Button prcancel;
        private System.Windows.Forms.Button Appsubmit;
        private System.Windows.Forms.TextBox PContact;
        private System.Windows.Forms.TextBox PAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox PGender;
    }
}
