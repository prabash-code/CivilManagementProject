using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient; 

namespace CivilManagementProject
{
    public partial class SignUp : Form
    {
        public SignUp()
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
            Projects projectsForm = new Projects();
            projectsForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Equipment equipmentForm = new Equipment();
            equipmentForm.Show();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
        }

        private void materialBtn_Click(object sender, EventArgs e)
        {
            Materials materialsForm = new Materials();
            materialsForm.Show();
        }

        private void workersBtn_Click(object sender, EventArgs e)
        {
            Workers workersForm = new Workers();
            workersForm.Show();
        }

        private void budgetBtn_Click(object sender, EventArgs e)
        {
            Budget budgetForm = new Budget();
            budgetForm.Show();

        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme(this);
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (insertUser()) {
                MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogIn log = new LogIn();
                log.Show();
                this.Hide();
            }
            
      

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool insertUser()

        {
            int selectedRoleId = 0;
            try
            {
                var dbCon = DBConnection.Instance();
                dbCon.ServerName = "localhost";
                dbCon.DatabaseName = "civil_project_management_system";
                dbCon.UserName = "root";
                dbCon.Password = "1234";

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

                if (dbCon.IsConnect())
                {
                    

                    switch (cmbBox.Text.Trim()) 
                    {
                        case "Admin":
                            selectedRoleId = 1;
                            break;
                        case "Project Manager":
                            selectedRoleId = 2;
                            break;
                        case "Site Engineer":
                            selectedRoleId = 3;
                            break;
                        case "Quantity Surveyor":
                            selectedRoleId = 4;
                            break;
                        default:
                            selectedRoleId = 5; 
                            break;
                    }


                    string query = "INSERT INTO users (username,password_hash,full_name,email,phone,role_id) VALUES (@username,@password,@full_name,@email,@phone,@roleid)";

                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon.SqlConnection))



                    {
                        cmd.Parameters.AddWithValue("@full_name", txtUserName.Text);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@username", cmbBox.Text);
                        cmd.Parameters.AddWithValue("@roleid", selectedRoleId);

                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                else {
                    MessageBox.Show("Database connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                } 

            }
            catch(Exception ex) {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }
    }  
}
