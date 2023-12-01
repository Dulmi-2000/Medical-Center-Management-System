namespace hospitalDbConnect.userC
{
    partial class availableDoc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(availableDoc));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.appgobutton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PatientCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDoc = new System.Windows.Forms.ComboBox();
            this.Appdate = new System.Windows.Forms.DateTimePicker();
            this.docavailBUTOON = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hospitalDataSet = new hospitalDbConnect.hospitalDataSet();
            this.doctorDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorDBTableAdapter = new hospitalDbConnect.hospitalDataSetTableAdapters.DoctorDBTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 678);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label7);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(55, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 70);
            this.panel2.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label7.Location = new System.Drawing.Point(348, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Availability of Doctors";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(55, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1063, 542);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.appgobutton);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(54, 327);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(955, 213);
            this.panel4.TabIndex = 1;
            this.panel4.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(346, 153);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3);
            this.button2.Size = new System.Drawing.Size(279, 42);
            this.button2.TabIndex = 52;
            this.button2.Text = "Check for another day";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // appgobutton
            // 
            this.appgobutton.BackColor = System.Drawing.Color.AliceBlue;
            this.appgobutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appgobutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.appgobutton.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.appgobutton.Location = new System.Drawing.Point(346, 93);
            this.appgobutton.Margin = new System.Windows.Forms.Padding(2);
            this.appgobutton.Name = "appgobutton";
            this.appgobutton.Padding = new System.Windows.Forms.Padding(3);
            this.appgobutton.Size = new System.Drawing.Size(279, 42);
            this.appgobutton.TabIndex = 51;
            this.appgobutton.Text = "Register Now";
            this.appgobutton.UseVisualStyleBackColor = false;
            this.appgobutton.Click += new System.EventHandler(this.appgobutton_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.PatientCount);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(110, 15);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(736, 55);
            this.panel6.TabIndex = 50;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 48);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PatientCount
            // 
            this.PatientCount.AutoSize = true;
            this.PatientCount.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientCount.Location = new System.Drawing.Point(207, 15);
            this.PatientCount.Name = "PatientCount";
            this.PatientCount.Size = new System.Drawing.Size(0, 27);
            this.PatientCount.TabIndex = 3;
            this.PatientCount.Click += new System.EventHandler(this.PatientCount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "patients already registered for that day.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "There are";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtDoc);
            this.panel5.Controls.Add(this.Appdate);
            this.panel5.Controls.Add(this.docavailBUTOON);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(54, 17);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(955, 305);
            this.panel5.TabIndex = 0;
            // 
            // txtDoc
            // 
            this.txtDoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoc.FormattingEnabled = true;
            this.txtDoc.Items.AddRange(new object[] {
            "Dr.WD Kavindya",
            "Dr.Nimal Nanayakkara",
            "Dr.Supun Kalhara",
            "Dr.Kumudu Perera"});
            this.txtDoc.Location = new System.Drawing.Point(456, 57);
            this.txtDoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(258, 26);
            this.txtDoc.TabIndex = 52;
            this.txtDoc.SelectedIndexChanged += new System.EventHandler(this.txtDoc_SelectedIndexChanged);
            // 
            // Appdate
            // 
            this.Appdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Appdate.Location = new System.Drawing.Point(456, 123);
            this.Appdate.Margin = new System.Windows.Forms.Padding(2);
            this.Appdate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.Appdate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.Appdate.Name = "Appdate";
            this.Appdate.Size = new System.Drawing.Size(188, 26);
            this.Appdate.TabIndex = 50;
            // 
            // docavailBUTOON
            // 
            this.docavailBUTOON.BackColor = System.Drawing.Color.AliceBlue;
            this.docavailBUTOON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.docavailBUTOON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.docavailBUTOON.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.docavailBUTOON.Location = new System.Drawing.Point(337, 197);
            this.docavailBUTOON.Margin = new System.Windows.Forms.Padding(2);
            this.docavailBUTOON.Name = "docavailBUTOON";
            this.docavailBUTOON.Padding = new System.Windows.Forms.Padding(3);
            this.docavailBUTOON.Size = new System.Drawing.Size(279, 42);
            this.docavailBUTOON.TabIndex = 48;
            this.docavailBUTOON.Text = "Check for Availability";
            this.docavailBUTOON.UseVisualStyleBackColor = false;
            this.docavailBUTOON.Click += new System.EventHandler(this.Appsubmit_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "Doctor Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 45;
            this.label1.Text = "Date";
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "hospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorDBBindingSource
            // 
            this.doctorDBBindingSource.DataMember = "DoctorDB";
            this.doctorDBBindingSource.DataSource = this.hospitalDataSet;
            // 
            // doctorDBTableAdapter
            // 
            this.doctorDBTableAdapter.ClearBeforeFill = true;
            // 
            // availableDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "availableDoc";
            this.Size = new System.Drawing.Size(1244, 678);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox txtDoc;
        private System.Windows.Forms.DateTimePicker Appdate;
        private System.Windows.Forms.Button docavailBUTOON;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource doctorDBBindingSource;
        private hospitalDataSet hospitalDataSet;
        private hospitalDataSetTableAdapters.DoctorDBTableAdapter doctorDBTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button appgobutton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label PatientCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
