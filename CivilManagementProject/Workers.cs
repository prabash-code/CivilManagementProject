using MySql.Data.MySqlClient;
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
    public partial class Workers : Form
    {
        String userId;
        public Workers()
        {
            InitializeComponent();

            dashboardBtn.Image = new Bitmap(dashboardBtn.Image, new Size(15, 15));
            propertiesBtn.Image = new Bitmap(propertiesBtn.Image, new Size(15, 15));
            taskBtn.Image = new Bitmap(taskBtn.Image, new Size(15, 15));
            materialBtn.Image = new Bitmap(materialBtn.Image, new Size(15, 15));
            workersBtn.Image = new Bitmap(workersBtn.Image, new Size(15, 15));
            experimentBtn.Image = new Bitmap(experimentBtn.Image, new Size(15, 15));
            budgetBtn.Image = new Bitmap(budgetBtn.Image, new Size(15, 15));
            reportBtn.Image = new Bitmap(reportBtn.Image, new Size(15, 15));
            settingsBtn.Image = new Bitmap(settingsBtn.Image, new Size(15, 15));



        }
        public Workers(String user) : this()
        {
            userId = user;
            txtUser.Text = user;
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
                    string query = "SELECT * FROM workers";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbCon.SqlConnection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);


                        dataGridView1.DataSource = dt;
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
            Projects projects = new Projects(userId);
            projects.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks(userId);
            tasks.Show();
            this.Hide();
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
            Equipment equipmentForm = new Equipment(userId);
            equipmentForm.Show();
            this.Hide();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard(userId);
            dashboardForm.Show();
            this.Hide();
        }

        private void materialBtn_Click(object sender, EventArgs e)
        {
            Materials materials = new Materials(userId);
            materials.Show();
            this.Hide();
        }

        private void workersBtn_Click(object sender, EventArgs e)
        {
            Workers workers = new Workers(userId);
            workers.Show();
            this.Hide();
        }

        private void budgetBtn_Click(object sender, EventArgs e)
        {
            Budget budgetForm = new Budget(userId);
            budgetForm.Show();
            this.Hide();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports(userId);
            reportsForm.Show();
            this.Hide();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(userId);
            settings.Show();
            this.Hide();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            LoadDataToTable();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme(this);
        }

        private void workersBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddProjects_Click(object sender, EventArgs e)
        {
            WorkersAddForm workersAdd = new WorkersAddForm();
            workersAdd.Show();

        }

        private void btnEditMaterials_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];

            String employeeCode = row.Cells["employee_code"].Value?.ToString() ?? "";
            String fullName = row.Cells["full_name"].Value?.ToString() ?? "";
            String role = row.Cells["role"].Value?.ToString() ?? "";
            String skill = row.Cells["skill"].Value?.ToString() ?? "";
            String phone = row.Cells["phone"].Value?.ToString() ?? "";
            String availability = row.Cells["availability_status"].Value?.ToString() ?? "";
            DateTime start = DateTime.TryParse(row.Cells["hire_date"].Value?.ToString(), out var t1) ? t1 : DateTime.Now;
            decimal experienced_years = decimal.TryParse(row.Cells["experience_years"].Value?.ToString(), out var d) ? d : 0m;
            decimal dailyWage = decimal.TryParse(row.Cells["daily_wage"].Value?.ToString(), out var d1) ? d1 : 0m;

            WorkersAddForm workers = new WorkersAddForm(
              employeeCode,
              fullName,
              role,
              skill,
              phone,
              start,
              availability,
              experienced_years,
              dailyWage
                );


        }

        private void btnDeleteMaterials_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];
            string code = row.Cells["employee_code"].Value?.ToString() ?? "";

            var dbCon = DBConnection.Instance();
            dbCon.ServerName = "localhost";
            dbCon.DatabaseName = "civil_project_management_system";
            dbCon.UserName = "root";
            dbCon.Password = "1234";

            if (dbCon.IsConnect())
            {
                try
                {
                    string query = "DELETE FROM workers WHERE employee_code = @employee_code";

                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@employee_code", code);
                        cmd.ExecuteNonQuery();
                        LoadDataToTable();

                    }
                    MessageBox.Show("Data deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data delete issue: " + ex.Message);
                }
                finally
                {
                    dbCon.Close();
                }
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Check karanna row ekak select wela thiyeda kiyala
            if (dataGridView1.SelectedRows.Count == 0) return;

            var row = dataGridView1.SelectedRows[0];

            // Null check ekka values gannawa
            String employeeCode = row.Cells["employee_code"].Value?.ToString() ?? "";
            String fullName = row.Cells["full_name"].Value?.ToString() ?? "";
            String role = row.Cells["role"].Value?.ToString() ?? "";
            String phone = row.Cells["phone"].Value?.ToString() ?? "";

            // Labels walata values set karanawa
            lblId.Text = employeeCode;
            lblName.Text = fullName;
            lblCategory.Text = role;
            lblContact.Text = phone;
        }
    }

    }
