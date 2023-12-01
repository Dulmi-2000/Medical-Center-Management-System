using hospitalDbConnect.userC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalDbConnect
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCon2.Controls.Clear();
            panelCon2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            addUserControl(register);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Patientregform pr = new Patientregform();
            addUserControl((UserControl)pr);
        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {
            availableDoc av = new availableDoc();
            addUserControl(av);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ChangeappForm chapp = new ChangeappForm();
            addUserControl(chapp);
        }

        private void dashbutton_Click(object sender, EventArgs e)
        {
            dash da1 = new dash();
            addUserControl(da1);
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox1.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox38.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox4.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox38.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox38.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox38.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox38.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox38.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox5.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox38.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox38.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox38.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox38.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox38.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox22.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox38.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox24.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox38.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox18.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox38.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox38.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox38.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
                con.Open();

                string querry = "SELECT COUNT(*) FROM DoctorssDB WHERE DoctorName='" + textBox14.Text + "'";

                SqlCommand command = new SqlCommand(querry, con);

                // Execute the command and retrieve the count
                int count = (int)command.ExecuteScalar();
                // MessageBox.Show("The number of rows in the table is " + count);

                textBox38.Text = count.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelCon2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelCon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
