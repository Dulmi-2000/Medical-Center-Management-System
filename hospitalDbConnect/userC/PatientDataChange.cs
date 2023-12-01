using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace hospitalDbConnect.userC
{
    public partial class Register : UserControl
    {
       
        public Register()
        {
            InitializeComponent();
        }

        private void APPname_TextChanged(object sender, EventArgs e)
        {

        }

        private void APPdoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void APPdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdcancel_Click(object sender, EventArgs e)
        {
            if (rdcancel != null)
            {
                rd1.Clear();
                rd2.Clear();
                rd3.Clear();
                APPdate.Text = "";
                gender.Text = "";
                idP.Text = "";
            }
        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


        //change
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int index = 0; // Replace with the actual index you want to use

                // Your code to update the DataGridView and the database
                DataGridViewRow newdata = patientRecordDataGridView.Rows[index];

                newdata.Cells[4].Value = gender.Text;
                newdata.Cells[2].Value = APPdate.Text;
                newdata.Cells[2].Value = rd1.Text;//name
                newdata.Cells[3].Value = rd3.Text;//contact
                newdata.Cells[1].Value = rd2.Text;//age
                newdata.Cells[0].Value = idP.Text;

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True"))
                {
                    con.Open();
                    //procedure connection

                    using (SqlCommand cmd = new SqlCommand("UpdatePatientsRecords", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Patient_Name", SqlDbType.Int).Value = rd1.Text;
                        cmd.Parameters.AddWithValue("@Patient_Age", SqlDbType.Int).Value = rd2.Text;
                        cmd.Parameters.AddWithValue("@Appoinment_date", SqlDbType.Int).Value = APPdate.Value;
                        cmd.Parameters.AddWithValue("@Contact_Number", SqlDbType.Int).Value = rd3.Text;
                        cmd.Parameters.AddWithValue("@Gender", SqlDbType.Int).Value = gender.Text;
                        cmd.Parameters.AddWithValue("@Patient_ID", SqlDbType.Int).Value = idP.Text;


                        cmd.ExecuteNonQuery();
                    }
                }

                // Display a success message
                MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            /*

            //  String Patient_Name, Patient_Age, Appointment_date, Contact_Number, Gender, Doctor_name;
            try
            {
                /*    String querry = "UPDATE PatientsDB SET Patient_Name='"+rd1.Text+"',Patient_Age='"+rd2.Text+"',Appointment_Date='"+APPdate.Text+"',Contact_Number='"+rd3.Text+"',Gender='"+gender.Text+"',Doctor_Name='"+APPdoc.Text+"' WHERE='"+rd1.Text+"'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                


                SqlCommand cmd = new SqlCommand("UPDATE PatientsDB SET Patient_Name = @Patient_Name , Patient_Age = Patient_Age, Appointment_Date = @Appointment_Date, Contact_Number = @Contact_Number, Gender =@Gender, Doctor_Name = @Doctor_Name WHERE Patient_ID = @Patient_ID", con);
                //SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Patient_Name", rd1.Text);
                cmd.Parameters.AddWithValue("@Patient_Age", rd2.Text);
                cmd.Parameters.AddWithValue("@Appoinment_date", APPdate.Value);
                cmd.Parameters.AddWithValue("@Contact_Number", rd3.Text);
                cmd.Parameters.AddWithValue("@Gender", gender.Text);
                cmd.Parameters.AddWithValue("@Doctor_name", APPdoc.Text);

                cmd.ExecuteNonQuery();


                MessageBox.Show("successfully Changed", "changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                //MessageBox.Show("error");
            }
            finally
            {
                con.Close();
            }*/
        }








        private void button1_Click(object sender, EventArgs e)
        {

            //delete button




            try
            {
                // Your code to update the DataGridView and the database
                // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


                int index1 = 0;
                index1 = patientRecordDataGridView.CurrentCell.RowIndex;
                patientRecordDataGridView.Rows.RemoveAt(index1);





                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("DeleteAppointmentRecords", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Patient_ID", SqlDbType.Int).Value = idP.Text;
                        cmd.Parameters.AddWithValue("@Patient_Name", SqlDbType.Int).Value = rd1.Text;
                        cmd.Parameters.AddWithValue("@Patient_Age", SqlDbType.Int).Value = rd2.Text;
                        cmd.Parameters.AddWithValue("@Appoinment_date", SqlDbType.Int).Value = APPdate.Value;
                        cmd.Parameters.AddWithValue("@Contact_Number", SqlDbType.Int).Value = rd3.Text;
                        cmd.Parameters.AddWithValue("@Gender", SqlDbType.Int).Value = gender.Text;
                        

                        cmd.ExecuteNonQuery();
                    }
                }

                // Display a success message
                MessageBox.Show("Data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                //delete data selected in textboxes
                rd1.Clear();
                rd2.Clear();
                APPdate.Text = "";
                APPdate.Text = "";
                rd3.Text = "";
                gender.Text="";
                idP.Text="";
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }







        private void ClearFormControls()
        {
            //Patient_id = 0;

            rd2.Clear();
            APPdate.Text = string.Empty;
            rd3.Clear();
            gender.Text = string.Empty;
            APPdate.Value = DateTime.Now;//Sets the appointmentDateTimePicker value to the current date and time

            rd1.Focus();

        }

            private DataTable dataTable;
        private object cmd;

     
    

    


          private void Register_Load(object sender, EventArgs e)
        {
           
            
            

        }



        private void button3_Click(object sender, EventArgs e)
        {
            
        }

   

        private void rd1_TextChanged(object sender, EventArgs e)
        {/*
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
            con.Open(); 

            SqlCommand cmd = new SqlCommand("Select Patient_ID,Patient_Name,Patient_Age,Appointment_Date,Contact_Number,Doctor_name from PatientsDB where Patient_ID=@Patients_ID", con);
            cmd.Parameters.AddWithValue("@Patient_ID",int.Parse(rd1.Text));
            // Assuming cmd is an instance of SqlCommand
            cmd.CommandText = "SELECT * FROM YourTable WHERE Patients_ID = @Patients_ID";
            cmd.Parameters.AddWithValue("@Patients_ID", SqlDbType.Int).Value = Column1; // Assuming recordId is the value you want to assign to @Patients_ID
            using (SqlDataReader dataReader = cmd.ExecuteReader())
            {
                // Process the data reader here
                // ...
            }
*/

            /*

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    rd2.Text = dash.getValue(0).ToString();
                    APPdate.Text = dash.getValue(1).ToString();
                    rd3.Text = dash.getValue(2).ToString();
                    gender.Text = dash.getValue(3).ToString();
                    APPdoc.Text = dash.getValue(4).ToString();

                }
            }*/

            DataTable dt = new DataTable();

        }



        private void patientRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from PatientsDB", con);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            patientRecordDataGridView.DataSource = dt;


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.patientRecordDataGridView.Rows[e.RowIndex];

                idP.Text = row.Cells["Column1"].Value.ToString();
                rd1.Text = row.Cells["Column2"].Value.ToString();
                rd2.Text = row.Cells["Column3"].Value.ToString();
                APPdate.Text = row.Cells["Column4"].Value.ToString();
                rd3.Text = row.Cells["Column5"].Value.ToString();
                gender.Text = row.Cells["Column6"].Value.ToString();
                // APPdoc.Text = row.Cells["Column6"].Value.ToString();


                //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");




            }
        }















            /*
            DataGridViewRow selectedRow = patientRecordDataGridView.SelectedRows[0];
            int recordId = Convert.ToInt32(selectedRow.Cells["Column1"].Value);
            string name = Convert.ToString(selectedRow.Cells["Column2"].Value);
            int age = Convert.ToInt32(selectedRow.Cells["Column3"].Value);
            int intValue;
            if (selectedRow.Cells["Column4"].Value != null &&
                int.TryParse(selectedRow.Cells["Column4"].Value.ToString(), out intValue))
            { }
                int phn = Convert.ToInt32(selectedRow.Cells["Column5"].Value);
            if (selectedRow.Cells["Column6"].Value != null)
            {
                string genderValue = selectedRow.Cells["Column6"].Value.ToString();
                if (int.TryParse(genderValue, out int gender))
                {
                    // The value was successfully converted to an Int32
                    // You can use the 'gender' variable in your code here
                }
            }
            if (selectedRow.Cells["Column7"].Value != null)
            {
                string doctorValue = selectedRow.Cells["Column7"].Value.ToString();
                if (int.TryParse(doctorValue, out int doctor))
                {
                    // The value was successfully converted to an Int32
                    // You can use the 'doctor' variable in your code here
                }
            }

                // Set the values in the panel controls
                rd1.Text = recordId.ToString();
            rd2.Text = name;
            APPdate.Text = age.ToString();

            /*  int recordId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
               string name = Convert.ToString(selectedRow.Cells["Name"].Value);
               int age = Convert.ToInt32(selectedRow.Cells["Age"].Value);

               // Pass the values to another form for further processing
               //  panel1 anotherForm = new panel(recordId, name, age);
               //  anotherForm.ShowDialog();
           */
            //= int.Parse(patientRecordDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString)
            //rd1.Text = patientRecordDataGridView.Rows[e.RowIndex].Cells[0].value.ToString();

            /*
                            // Iterate over the selected rows
                            foreach (DataGridViewRow row in patientRecordDataGridView.SelectedRows)
                            {
                                // Access data in each column of the selected row
                                string column1Value = row.Cells["Column1"].Value.ToString();
                                string column2Value = row.Cells["Column2"].Value.ToString();
                                // ... access other columns as needed
                            }



                        // Assuming you want to retrieve the value in the first column of the selected row
                        _ = patientRecordDataGridView.SelectedRows[0];
                        DataGridViewCell cell = selectedRow.Cells[0];
                            string cellValue = cell.Value.ToString();

                        */

        

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
