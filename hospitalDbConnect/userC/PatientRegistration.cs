using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalDbConnect.userC
{
    public partial class Patientregform : UserControl
    {
        public Patientregform()
        {
            InitializeComponent();
        }




        //create variable for patient id
        public int Patient_id;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");




        private void prcancel_Click(object sender, EventArgs e)
        {
            PName.Clear();
            PAge.Clear();
            PContact.Clear();
        }






        private bool IsValid()
        {
            if (PName.Text == string.Empty)
            {
                MessageBox.Show("Patient name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }




        private void Appsubmit_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");

            
               // String  Patient_Name,Patient_Age,Appointment_Date,Contact_Number,Gender,Doctor_Name ;

            con.Open();
               
                using (SqlCommand command = new SqlCommand("InsertPatientsData", con))
                {
                    // Set the CommandType to StoredProcedure
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        // Add parameters and execute the stored procedure
                        command.ExecuteNonQuery();
                    }
                    catch { }
                    command.Parameters.AddWithValue("@Patient_Name",SqlDbType.Int).Value= PName.Text;
                    command.Parameters.AddWithValue("@Patient_Age", SqlDbType.Int).Value = PAge.Text;
                    command.Parameters.AddWithValue("@Registerd_Date", SqlDbType.Int).Value = PDate.Text;
                    command.Parameters.AddWithValue("@Contact_Number", SqlDbType.Int).Value = PContact.Text;
                    command.Parameters.AddWithValue("@Gender", SqlDbType.Int).Value = PGender.Text;
                    //command.Parameters.AddWithValue("@Registerd_Date", SqlDbType.Int).Value = textBox3.Text;
                        // command.Parameters.AddWithValue("@thresholdQuantity", textBox3.Text);


                        command.ExecuteNonQuery ();
                }











            /*   try
               {


                   if (IsValid1())
                   {
                       SqlCommand cmd = new SqlCommand("INSERT INTO PatientsDB VALUES (@Patient_Name, @Patient_Age, @Appoinment_Date, @Contact_Number, @Gender, @Doctor_name)", con);
                       cmd.CommandType = CommandType.Text;
                       cmd.Parameters.AddWithValue("@Patient_Name", pr1.Text);
                       cmd.Parameters.AddWithValue("@Patient_Age", pr2.Text);
                       cmd.Parameters.AddWithValue("@Appoinment_Date", APPdate.Value);
                       cmd.Parameters.AddWithValue("@Contact_Number", pr3.Text);
                       cmd.Parameters.AddWithValue("@Doctor_name", comboBox1.Text);
                       string gender;
                            if (maleRadioBttn.Checked == true)
                             {
                                 gender = "Male";
                             }
                             else
                             {
                                 gender = "Female";
                             }
                       cmd.Parameters.AddWithValue("@Gender", maleRadioBttn);

                       con.Open();
                       cmd.ExecuteNonQuery();
                       con.Close();

                       MessageBox.Show("successfully registered", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   }


               }
               catch { 
               }
               finally
               {
                   con.Close();
               }


   }

           private bool IsValid1()
           {
               if (pr1.Text == string.Empty)
               {
                   MessageBox.Show("Patient name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }
               return true;*/




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Patientregform_Load(object sender, EventArgs e)
        {

        }
    }
}
