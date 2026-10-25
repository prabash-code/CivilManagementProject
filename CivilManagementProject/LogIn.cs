using BCrypt.Net;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CivilManagementProject
{
    public partial class LogIn : Form
    {
        string userMail = "";
        public LogIn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
         
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //validate user inputs

             userMail = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string getHashCode = BCrypt.Net.BCrypt.HashPassword(password);
            string hash_result = "";


            if (string.IsNullOrEmpty(userMail) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            //get stored hash code from database and compare with the entered password

            try {
                var dbCon = DBConnection.Instance();
                dbCon.ServerName = "localhost";
                dbCon.DatabaseName = "civil_project_management_system";
                dbCon.UserName = "root";
                dbCon.Password = "1234";

                if (dbCon.IsConnect())
                {
                 
                    string query1 = $"SELECT password_hash FROM users WHERE email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(query1, dbCon.SqlConnection)) {

                        cmd.Parameters.AddWithValue("@email", userMail);

                        if (dbCon.SqlConnection.State == ConnectionState.Closed)
                            dbCon.SqlConnection.Open();

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                           hash_result = result.ToString().Trim();

                        }
                        else {
                            MessageBox.Show("Invaild Email");
                        }
                        
                        bool vaild = BCrypt.Net.BCrypt.Verify(password,hash_result);

                        if (vaild)
                        {
                            string userName = userMail.Split('@')[0];
                            Dashboard dashboard = new Dashboard(userName);
                            Projects projects = new Projects(userName);
                            Tasks task = new Tasks(userName);
                            Materials materials = new Materials(userName);
                            Workers workers = new Workers(userName);
                            Budget budget = new Budget(userName);
                            Reports report = new Reports(userName);
                            Settings settings = new Settings(userName);
                            Equipment equipment = new Equipment(userName);


                            
                            dashboard.Show();
                            this.Hide();

                        }
                        else {
                            txtEmail.Clear();
                            txtPassword.Clear();
                            MessageBox.Show("Password is Incorrect try again" );

                        
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
            catch (Exception ex) {
            MessageBox.Show($"Database connection error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();   
            signUp.Show(); 
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void NewLog_Load(object sender, EventArgs e)
        {

        }

        private void btnForgotPW_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }
    }
}
