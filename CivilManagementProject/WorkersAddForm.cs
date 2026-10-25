using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CivilManagementProject
{
    public partial class WorkersAddForm : Form
    {
        Boolean isEdit = false;
        String workerCode = "";
        public WorkersAddForm()
        {   
            InitializeComponent();
             workerCode=generateWorkerCode();

            }
        public WorkersAddForm(String employeeCode,String fullName,String role,String skills,String phone,DateTime start,String availability,decimal experiencedYears,decimal dailyWage)
        {
           

            InitializeComponent();
            
            txtFullName.Text = fullName;
            cmbRole.Text = role;
            textBox.Text = skills;
            txtExperienced.Text = experiencedYears.ToString();
            txtDailyWage.Text = dailyWage.ToString();
            txtPhone.Text  = phone;
            cmbAvailability.Text = availability;
            dpHireDate.Value = start;
            isEdit = true;

        }

        private String generateWorkerCode()
        {
            string newCode = "W001";
            var dbCon = DBConnection.Instance();
            dbCon.ServerName = "localhost";
            dbCon.DatabaseName = "civil_project_management_system";
            dbCon.UserName = "root";
            dbCon.Password = "1234";

            if (dbCon.IsConnect())
            {
                try
                {
                    string query = "SELECT employee_code FROM workers ORDER BY worker_id DESC LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string lastCode = result.ToString();
                            if (lastCode.StartsWith("W") && int.TryParse(lastCode.Substring(1), out int num))
                            {
                                newCode = "W" + (num + 1).ToString();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    // Fallback default
                }
                finally
                {
                    dbCon.Close();
                }
            }
            return newCode;
        }
        private void saveWorkersData()
        {
            var dbCon = DBConnection.Instance();
            dbCon.ServerName = "localhost";
            dbCon.DatabaseName = "civil_project_management_system";
            dbCon.UserName = "root";
            dbCon.Password = "1234";

            if (dbCon.IsConnect())
            {
                try
                {
                    string query;

                    if (isEdit)
                    {
                        query = @"UPDATE workers SET full_name=@full_name,role=@role,skill=@skill,experience_years=@experience_years,daily_wage=@daily_wage,phone=@phone,availability_status=@availability_status,hire_date=@hire_date where employee_code=@employee_code";
                    }
                    else
                    {
                        query = @"INSERT INTO workers (employee_code ,full_name ,role,skill,experience_years,daily_wage,phone,availability_status ,hire_date) values(@employee_code,@full_name,@role,@skill,@experience_years,@daily_wage,@phone,@availability_status,@hire_date)";                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@employee_code", workerCode);
                        cmd.Parameters.AddWithValue("@full_name",txtFullName.Text);
                        cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                        cmd.Parameters.AddWithValue("@skill", textBox.Text);
                        cmd.Parameters.AddWithValue("@experience_years", txtExperienced.Text);
                        cmd.Parameters.AddWithValue("@daily_wage", txtDailyWage.Text);
                        cmd.Parameters.AddWithValue("@phone",txtPhone.Text);
                        cmd.Parameters.AddWithValue("@availability_status", cmbAvailability.Text);
                        cmd.Parameters.AddWithValue("@hire_date", dpHireDate.Value);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Worker saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearFields();

                        Workers workers = new Workers();
                        workers.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data save issue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbCon.Close();

                }
            }
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            cmbRole.SelectedIndex=-1;
            textBox.Clear();
            txtExperienced.Clear();
            txtDailyWage.Clear();
            txtPhone.Clear();
            cmbAvailability.SelectedIndex = -1;
            dpHireDate.Checked=false;


        }

        private void LoadDataToTable()
        {
            var dbCon = DBConnection.Instance();
            dbCon.ServerName = "localhost";
            dbCon.DatabaseName = "civil_project_management_system";
            dbCon.UserName = "root";
            dbCon.Password = "1234";

            if (dbCon.IsConnect())
            {
                try
                {
                    string query = "SELECT * FROM materials";
 
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbCon.SqlConnection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data load issue: " + ex.Message);
                }
                finally
                {
                    dbCon.Close();
                }
            }
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
            Tasks tasks=new Tasks();
            tasks.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Equipment experimentsForm = new Equipment();
            experimentsForm.Show();
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
            Workers workers=new Workers();
            workers.Show();
        }

        private void budgetBtn_Click(object sender, EventArgs e)
        {
            Budget budgetForm = new Budget();
            budgetForm.Show();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports();
            reportsForm.Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }

        private void Materials_Load(object sender, EventArgs e)
        {
            LoadDataToTable();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaterialName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSupplierId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddMaterials_Click(object sender, EventArgs e)
        {
            saveWorkersData();
        }
    }
}
