using System;
using System.Windows.Forms;

namespace hospitalDbConnect.userC
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdcancel = new System.Windows.Forms.Button();
            this.APPdate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idP = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rd3 = new System.Windows.Forms.TextBox();
            this.rd2 = new System.Windows.Forms.TextBox();
            this.rd1 = new System.Windows.Forms.TextBox();
            this.pID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.patientRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.patientsDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet1 = new hospitalDbConnect.hospitalDataSet1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.patientsDBTableAdapter = new hospitalDbConnect.hospitalDataSet1TableAdapters.PatientsDBTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 75, 0);
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 37;
            this.label4.Text = "Patient Name";
            // 
            // rdcancel
            // 
            this.rdcancel.BackColor = System.Drawing.Color.AliceBlue;
            this.rdcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdcancel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.rdcancel.Location = new System.Drawing.Point(379, 451);
            this.rdcancel.Margin = new System.Windows.Forms.Padding(2);
            this.rdcancel.Name = "rdcancel";
            this.rdcancel.Padding = new System.Windows.Forms.Padding(3);
            this.rdcancel.Size = new System.Drawing.Size(107, 42);
            this.rdcancel.TabIndex = 41;
            this.rdcancel.Text = "Clear";
            this.rdcancel.UseVisualStyleBackColor = false;
            this.rdcancel.Click += new System.EventHandler(this.rdcancel_Click);
            // 
            // APPdate
            // 
            this.APPdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.APPdate.Location = new System.Drawing.Point(226, 242);
            this.APPdate.Margin = new System.Windows.Forms.Padding(2);
            this.APPdate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.APPdate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.APPdate.Name = "APPdate";
            this.APPdate.Size = new System.Drawing.Size(188, 26);
            this.APPdate.TabIndex = 42;
            this.APPdate.ValueChanged += new System.EventHandler(this.APPdate_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.idP);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.rd3);
            this.panel1.Controls.Add(this.rd2);
            this.panel1.Controls.Add(this.rd1);
            this.panel1.Controls.Add(this.pID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.APPdate);
            this.panel1.Controls.Add(this.rdcancel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 525);
            this.panel1.TabIndex = 31;
            // 
            // idP
            // 
            this.idP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idP.Location = new System.Drawing.Point(226, 114);
            this.idP.Margin = new System.Windows.Forms.Padding(2);
            this.idP.Name = "idP";
            this.idP.Size = new System.Drawing.Size(297, 26);
            this.idP.TabIndex = 62;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(675, 118);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 26);
            this.textBox1.TabIndex = 61;
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(226, 357);
            this.gender.Margin = new System.Windows.Forms.Padding(2);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(236, 26);
            this.gender.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 302);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 22);
            this.label10.TabIndex = 59;
            this.label10.Text = "Contact Number";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(68, 451);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3);
            this.button2.Size = new System.Drawing.Size(107, 42);
            this.button2.TabIndex = 56;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(226, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 55;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 22);
            this.label8.TabIndex = 54;
            this.label8.Text = "Years";
            // 
            // rd3
            // 
            this.rd3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd3.Location = new System.Drawing.Point(226, 301);
            this.rd3.Margin = new System.Windows.Forms.Padding(2);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(297, 26);
            this.rd3.TabIndex = 51;
            // 
            // rd2
            // 
            this.rd2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2.Location = new System.Drawing.Point(226, 174);
            this.rd2.Margin = new System.Windows.Forms.Padding(2);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(49, 26);
            this.rd2.TabIndex = 50;
            // 
            // rd1
            // 
            this.rd1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1.Location = new System.Drawing.Point(226, 51);
            this.rd1.Margin = new System.Windows.Forms.Padding(2);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(297, 26);
            this.rd1.TabIndex = 49;
            this.rd1.TextChanged += new System.EventHandler(this.rd1_TextChanged);
            // 
            // pID
            // 
            this.pID.AutoSize = true;
            this.pID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pID.Location = new System.Drawing.Point(44, 118);
            this.pID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pID.Name = "pID";
            this.pID.Size = new System.Drawing.Size(98, 22);
            this.pID.TabIndex = 48;
            this.pID.Text = "Patient ID";
            this.pID.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 47;
            this.label5.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(125, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Edit Patient Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(34, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 70);
            this.panel2.TabIndex = 32;
            // 
            // patientRecordDataGridView
            // 
            this.patientRecordDataGridView.AllowUserToOrderColumns = true;
            this.patientRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.patientRecordDataGridView.Location = new System.Drawing.Point(629, 122);
            this.patientRecordDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.patientRecordDataGridView.Name = "patientRecordDataGridView";
            this.patientRecordDataGridView.RowHeadersWidth = 51;
            this.patientRecordDataGridView.RowTemplate.Height = 24;
            this.patientRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientRecordDataGridView.Size = new System.Drawing.Size(512, 525);
            this.patientRecordDataGridView.TabIndex = 33;
            this.patientRecordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientRecordDataGridView_CellContentClick);
            // 
            // patientsDBBindingSource
            // 
            this.patientsDBBindingSource.DataMember = "PatientsDB";
            this.patientsDBBindingSource.DataSource = this.hospitalDataSet1;
            // 
            // hospitalDataSet1
            // 
            this.hospitalDataSet1.DataSetName = "hospitalDataSet1";
            this.hospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(629, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 70);
            this.panel3.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(135, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 39);
            this.label9.TabIndex = 0;
            this.label9.Text = "Patient Details";
            // 
            // patientsDBTableAdapter
            // 
            this.patientsDBTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Patient_ID";
            this.Column1.HeaderText = "Patient ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Patient_Name";
            this.Column2.HeaderText = "Patient Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Patient_Age";
            this.Column3.HeaderText = "Age";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Registerd_Date";
            this.Column4.HeaderText = "Registerd Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Contact_Number";
            this.Column5.HeaderText = "Contact Number";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Gender";
            this.Column6.HeaderText = "Gender";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.patientRecordDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(1244, 678);
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rdcancel;
        private System.Windows.Forms.DateTimePicker APPdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rd3;
        private System.Windows.Forms.TextBox rd2;
        private System.Windows.Forms.TextBox rd1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView patientRecordDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox gender;
        private BindingSource patientsDBBindingSource;
        private hospitalDataSet1 hospitalDataSet1;
        private hospitalDataSet1TableAdapters.PatientsDBTableAdapter patientsDBTableAdapter;
        private Label pID;
        private TextBox idP;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
