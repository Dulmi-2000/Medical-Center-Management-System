using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospitalDbConnect.userC
{
    public partial class ChangeappForm : UserControl
    {
        public ChangeappForm()
        {
            InitializeComponent();
        }



        ///clear button  
        private void APPcancel_Click(object sender, EventArgs e)
        {
            if (APPcancel != null)
            {
                AppName.Clear();
                regno.Clear();
                doct1.Text = "";
                APPdate.Text = "";
                pay1.Text = "";
                regno.Clear();
                appno.Clear();


            }
        }


        private void GetAppointmentRecord()
        {

        }





        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
        private int index;

        private void button2_Click(object sender, EventArgs e)
        {

            //  String Patient_Name, Patient_Age, Appointment_date, Contact_Number, Gender, Doctor_name;
            try
            {
                /*    String querry = "UPDATE PatientsDB SET Patient_Name='"+rd1.Text+"',Patient_Age='"+rd2.Text+"',Appointment_Date='"+APPdate.Text+"',Contact_Number='"+rd3.Text+"',Gender='"+gender.Text+"',Doctor_Name='"+APPdoc.Text+"' WHERE='"+rd1.Text+"'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                */


                SqlCommand cmd = new SqlCommand("UPDATE PatientsDB SET Patient_Name = @Patient_Name , Patient_Age = Patient_Age, Appointment_Date = @Appointment_Date, Contact_Number = @Contact_Number, Gender =@Gender, Doctor_Name = @Doctor_Name WHERE Patient_ID = @Patient_ID", con);
                //SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Patient_Name", AppName.Text);
                cmd.Parameters.AddWithValue("@Patient_Age", regno.Text);
                cmd.Parameters.AddWithValue("@Appoinment_date", APPdate.Value);
                cmd.Parameters.AddWithValue("@Contact_Number", doct1.Text);
                cmd.Parameters.AddWithValue("@Gender", appno.Text);
                cmd.Parameters.AddWithValue("@Doctor_name", pay1.Text);

                cmd.ExecuteNonQuery();


                MessageBox.Show("successfully Changed", "Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                //MessageBox.Show("error");
            }
            finally
            {
                // con.Close();
            }

        }





        //delete button

        private void button1_Click(object sender, EventArgs e)
        {

            //delete button




            try
            {
                // Your code to update the DataGridView and the database
                // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");

                index = patientRecordDataGridView1.CurrentCell.RowIndex;
                patientRecordDataGridView1.Rows.RemoveAt(index);





                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("DeleteAppointmentRecords", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PatientName", SqlDbType.Text).Value = AppName.Text;
                        cmd.Parameters.AddWithValue("@PatientRegNo", SqlDbType.Text).Value = regno.Text;
                        cmd.Parameters.AddWithValue("@ADate", SqlDbType.Text).Value = APPdate.Value;
                        cmd.Parameters.AddWithValue("@DoctorName", SqlDbType.Text).Value = doct1.Text;
                        cmd.Parameters.AddWithValue("@AppointmentNo", SqlDbType.Text).Value = appno.Text;
                        cmd.Parameters.AddWithValue("@Payment", SqlDbType.Text).Value = pay1.Text;
                        cmd.ExecuteNonQuery();
                    }
                }

                // Display a success message
                MessageBox.Show("Data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                
                //delete data selected in textboxes
                AppName.Clear();
                regno.Clear();
                doct1.Text = "";
                APPdate.Text = "";
                pay1.Text = "";
                regno.Clear();
                appno.Clear();
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }








        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            GetAppointmentRecord();
        }






        private void Deletepanel_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("Select * from AppointmentsDB", con);
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            //con.Open(); 
            //SqlDataReader dr = cmd.ExecuteReader();
            //dt.Load(dr);
            dr.Fill(dt);
            // con.Close();
            patientRecordDataGridView1.DataSource = dt;

        }



        private void patientRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
            con.Open();

             SqlCommand cmd = new SqlCommand("Select * from AppointmentsDB", con);
            SqlDataAdapter sql=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            patientRecordDataGridView1.DataSource = dt;

           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.patientRecordDataGridView1.Rows[e.RowIndex];
           
                AppName.Text = row.Cells["Column1"].Value.ToString();
                regno.Text = row.Cells["Column2"].Value.ToString();
                APPdate.Text = row.Cells["Column3"].Value.ToString();
                doct1.Text = row.Cells["Column4"].Value.ToString();
                appno.Text = row.Cells["Column5"].Value.ToString();
                pay1.Text = row.Cells["Column6"].Value.ToString();


              


            }
        }




        private void Display_Click(object sender, EventArgs e)
        {
            /*      if(IsValid)
                {
                    SqlCommand cmd = new SqlCommand("");
                }
            }
            private bool IsValid()
            {
                if(AppName.Text==string.Empty)
                {
                    MessageBox.Show("Patient Registration number is required");
                    return false;
                }
                return true;    */
        }




        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void APPdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void da3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void da4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AppName_TextChanged(object sender, EventArgs e)
        {

        }



        //change button
        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Your code to update the DataGridView and the database
                DataGridViewRow newdata = patientRecordDataGridView1.Rows[index];
                newdata.Cells[3].Value = AppName.Text;
                newdata.Cells[2].Value = regno.Text;
                newdata.Cells[0].Value = APPdate.Text;
                newdata.Cells[4].Value = doct1.Text;
                newdata.Cells[1].Value = appno.Text;
                newdata.Cells[5].Value = pay1.Text;

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("UpdateAppointmentRecords", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PatientName", SqlDbType.Text).Value = AppName.Text;
                        cmd.Parameters.AddWithValue("@PatientRegNo", SqlDbType.Text).Value = regno.Text;
                        cmd.Parameters.AddWithValue("@ADate", SqlDbType.Text).Value = APPdate.Value;
                        cmd.Parameters.AddWithValue("@DoctorName", SqlDbType.Text).Value = doct1.Text;
                        cmd.Parameters.AddWithValue("@AppointmentNo", SqlDbType.Text).Value = appno.Text;
                        cmd.Parameters.AddWithValue("@Payment", SqlDbType.Text).Value = pay1.Text;
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

        }

    }

}