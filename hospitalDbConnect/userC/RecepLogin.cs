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

namespace hospitalDbConnect.userC
{
    public partial class receptlogin : UserControl
    {
        public receptlogin()
        {
            InitializeComponent();
        }

        private void repsub_Click(object sender, EventArgs e)
        {

            String username, password;


            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D6GBCCJ\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");



            username = rece.Text;
                password = pass.Text;


            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {

                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();

            }
                /*
                try
                    {
                        String querry = "SELECT * FROM ReceptionistDetails WHERE UserName = '" + rece.Text + "' AND Password = '" + pass.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                        DataTable dtable = new DataTable();
                        sda.Fill(dtable);

                        if (dtable.Rows.Count > 0)
                        {
                            username = rece.Text;
                            password = pass.Text;

                            //page that needed to be load next
                            Form3 form3 = new Form3();
                            form3.Show();
                            this.Hide();
                        }

                      else
                        {
                            MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rece.Clear();
                            pass.Clear();

                            //to focus username
                            rece.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }*/
                
                // Perform login authentication logic here
                // ...
                // If authentication succeeds, proceed with the application
                // ...

            
        }

        private void adlogclear_Click(object sender, EventArgs e)
        {
            rece.Clear();
            pass.Clear();

            rece.Focus();
        }

        private void receptlogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();
            log.Show();

        }
    }
}
