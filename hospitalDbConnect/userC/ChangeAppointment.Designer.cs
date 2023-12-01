namespace hospitalDbConnect.userC
{
    partial class ChangeappForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeappForm));
            this.Deletepanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.patientRecordDataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pay1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.TextBox();
            this.APPdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appno = new System.Windows.Forms.TextBox();
            this.doct1 = new System.Windows.Forms.ComboBox();
            this.regno = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.APPcancel = new System.Windows.Forms.Button();
            this.appointmentsDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet2 = new hospitalDbConnect.hospitalDataSet2();
            this.appointmentsDBTableAdapter = new hospitalDbConnect.hospitalDataSet2TableAdapters.AppointmentsDBTableAdapter();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deletepanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordDataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // Deletepanel
            // 
            this.Deletepanel.BackColor = System.Drawing.Color.AliceBlue;
            this.Deletepanel.Controls.Add(this.panel3);
            this.Deletepanel.Controls.Add(this.patientRecordDataGridView1);
            this.Deletepanel.Controls.Add(this.panel2);
            this.Deletepanel.Controls.Add(this.panel4);
            this.Deletepanel.Location = new System.Drawing.Point(0, 0);
            this.Deletepanel.Margin = new System.Windows.Forms.Padding(2);
            this.Deletepanel.Name = "Deletepanel";
            this.Deletepanel.Size = new System.Drawing.Size(1244, 678);
            this.Deletepanel.TabIndex = 0;
            this.Deletepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Deletepanel_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label9);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(632, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 70);
            this.panel3.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label9.Location = new System.Drawing.Point(97, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(328, 39);
            this.label9.TabIndex = 0;
            this.label9.Text = "Appointment Details";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // patientRecordDataGridView1
            // 
            this.patientRecordDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientRecordDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column5,
            this.Column2,
            this.Column1,
            this.Column4,
            this.Column6});
            this.patientRecordDataGridView1.Location = new System.Drawing.Point(632, 121);
            this.patientRecordDataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.patientRecordDataGridView1.Name = "patientRecordDataGridView1";
            this.patientRecordDataGridView1.RowHeadersWidth = 51;
            this.patientRecordDataGridView1.RowTemplate.Height = 24;
            this.patientRecordDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientRecordDataGridView1.Size = new System.Drawing.Size(509, 532);
            this.patientRecordDataGridView1.TabIndex = 41;
            this.patientRecordDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientRecordDataGridView_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label7);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(36, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 70);
            this.panel2.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label7.Location = new System.Drawing.Point(38, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(490, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Change or Delete Appointment";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.pay1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.AppName);
            this.panel4.Controls.Add(this.APPdate);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.appno);
            this.panel4.Controls.Add(this.doct1);
            this.panel4.Controls.Add(this.regno);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.APPcancel);
            this.panel4.Location = new System.Drawing.Point(36, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(569, 532);
            this.panel4.TabIndex = 39;
            // 
            // pay1
            // 
            this.pay1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay1.FormattingEnabled = true;
            this.pay1.Items.AddRange(new object[] {
            "Paid",
            "Not Paid"});
            this.pay1.Location = new System.Drawing.Point(306, 375);
            this.pay1.Margin = new System.Windows.Forms.Padding(2);
            this.pay1.Name = "pay1";
            this.pay1.Size = new System.Drawing.Size(188, 26);
            this.pay1.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label5.Size = new System.Drawing.Size(202, 21);
            this.label5.TabIndex = 64;
            this.label5.Text = "Patient Name";
            // 
            // AppName
            // 
            this.AppName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.Location = new System.Drawing.Point(306, 30);
            this.AppName.Margin = new System.Windows.Forms.Padding(2);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(232, 26);
            this.AppName.TabIndex = 58;
            this.AppName.TextChanged += new System.EventHandler(this.AppName_TextChanged);
            // 
            // APPdate
            // 
            this.APPdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.APPdate.Location = new System.Drawing.Point(306, 168);
            this.APPdate.Margin = new System.Windows.Forms.Padding(2);
            this.APPdate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.APPdate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.APPdate.Name = "APPdate";
            this.APPdate.Size = new System.Drawing.Size(188, 26);
            this.APPdate.TabIndex = 66;
            this.APPdate.ValueChanged += new System.EventHandler(this.APPdate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(27, 379);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 65;
            this.label6.Text = "Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 21);
            this.label4.TabIndex = 63;
            this.label4.Text = "Patient Registration Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 62;
            this.label3.Text = "Docter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "Appointment Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Date";
            // 
            // appno
            // 
            this.appno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appno.Location = new System.Drawing.Point(306, 306);
            this.appno.Margin = new System.Windows.Forms.Padding(2);
            this.appno.Name = "appno";
            this.appno.Size = new System.Drawing.Size(232, 26);
            this.appno.TabIndex = 59;
            this.appno.TextChanged += new System.EventHandler(this.da4_TextChanged);
            // 
            // doct1
            // 
            this.doct1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doct1.FormattingEnabled = true;
            this.doct1.Items.AddRange(new object[] {
            "1 - Jayathissa",
            "2 - Piyathissa",
            "3 - Wijenayaka",
            "4 - Jayarathne",
            "5 - Lasi",
            "6 - Lahiru",
            "7 - Dulmi",
            "8 - Aishu",
            "9 - Kavidu",
            "10 - Wijerathne"});
            this.doct1.Location = new System.Drawing.Point(306, 237);
            this.doct1.Margin = new System.Windows.Forms.Padding(2);
            this.doct1.Name = "doct1";
            this.doct1.Size = new System.Drawing.Size(188, 26);
            this.doct1.TabIndex = 67;
            this.doct1.SelectedIndexChanged += new System.EventHandler(this.da3_SelectedIndexChanged);
            // 
            // regno
            // 
            this.regno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regno.Location = new System.Drawing.Point(306, 99);
            this.regno.Margin = new System.Windows.Forms.Padding(2);
            this.regno.Name = "regno";
            this.regno.Size = new System.Drawing.Size(232, 26);
            this.regno.TabIndex = 57;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(76, 456);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3);
            this.button2.Size = new System.Drawing.Size(102, 42);
            this.button2.TabIndex = 56;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(232, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(102, 42);
            this.button1.TabIndex = 55;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // APPcancel
            // 
            this.APPcancel.BackColor = System.Drawing.Color.AliceBlue;
            this.APPcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.APPcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.APPcancel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.APPcancel.Location = new System.Drawing.Point(379, 456);
            this.APPcancel.Margin = new System.Windows.Forms.Padding(2);
            this.APPcancel.Name = "APPcancel";
            this.APPcancel.Padding = new System.Windows.Forms.Padding(3);
            this.APPcancel.Size = new System.Drawing.Size(102, 42);
            this.APPcancel.TabIndex = 41;
            this.APPcancel.Text = "Clear";
            this.APPcancel.UseVisualStyleBackColor = false;
            this.APPcancel.Click += new System.EventHandler(this.APPcancel_Click);
            // 
            // appointmentsDBBindingSource
            // 
            this.appointmentsDBBindingSource.DataMember = "AppointmentsDB";
            this.appointmentsDBBindingSource.DataSource = this.hospitalDataSet2;
            // 
            // hospitalDataSet2
            // 
            this.hospitalDataSet2.DataSetName = "hospitalDataSet2";
            this.hospitalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsDBTableAdapter
            // 
            this.appointmentsDBTableAdapter.ClearBeforeFill = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ADate";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "AppointmentNo";
            this.Column5.HeaderText = "Appointment No";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PatientRegNo";
            this.Column2.HeaderText = "Patient Registration No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PatientName";
            this.Column1.HeaderText = "Patient Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DoctorName";
            this.Column4.HeaderText = "Doctor Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Payment";
            this.Column6.HeaderText = "Payment";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // ChangeappForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Deletepanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeappForm";
            this.Size = new System.Drawing.Size(1244, 678);
            this.Deletepanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordDataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Deletepanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView patientRecordDataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox pay1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AppName;
        private System.Windows.Forms.DateTimePicker APPdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox appno;
        private System.Windows.Forms.ComboBox doct1;
        private System.Windows.Forms.TextBox regno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button APPcancel;
        private System.Windows.Forms.BindingSource appointmentsDBBindingSource;
        private hospitalDataSet2 hospitalDataSet2;
        private hospitalDataSet2TableAdapters.AppointmentsDBTableAdapter appointmentsDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
