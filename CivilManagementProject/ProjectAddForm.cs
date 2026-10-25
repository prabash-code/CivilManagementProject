using Grpc.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CivilManagementProject
{
    public partial class    ProjectAddForm : Form
    {
        private string currentProjectCode = null;
        private bool isEditMode = false;

        public ProjectAddForm(){
            InitializeComponent();
            isEditMode = false;
        }
        public ProjectAddForm(string projectCode, string projectName, string clientName, string location, string description, DateTime startDate, DateTime plannedEnd, DateTime actualEnd, decimal budget, string status, string projectManager)
        {

            InitializeComponent();
            isEditMode = true;
            currentProjectCode = projectCode;
            txtProjectName.Text = projectName;
            txtClientName.Text = clientName;
            txtLocation.Text = location;
            textBox.Text = description;

            dpStart.Value = startDate;
            dpPlannedEnd.Value = plannedEnd;
            dpActualEndDate.Value = actualEnd;

            txtPlannedBudget.Text = budget.ToString();
            cmbStatus.SelectedItem = status;
            cmdPM.Text = projectManager;
                        
            btnAddProject.Text = "Update Project";

        }

        private void LoadData()
        {
          
        }



        private void saveProjectData()
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

                    if (isEditMode)
                    {
                        query = @"UPDATE projects SET project_name = @project_name, client_name = @client_name, location = @location, description = @description, start_date = @start_date, planned_end_date = @planned_end_date, actual_end_date = @actual_end_date, planned_budget = @planned_budget, status = @status, project_manager_id = (SELECT user_id FROM users WHERE full_name = @project_manager_id LIMIT 1) WHERE project_code = @project_code";
                    }
                    else
                    {
                        query = @"INSERT INTO projects (project_code, project_name, client_name, location, description, start_date, planned_end_date, actual_end_date, planned_budget, status, project_manager_id)
                                        VALUES ((SELECT CONCAT('P', LPAD(COALESCE(MAX(CAST(SUBSTRING(project_code, 2) AS UNSIGNED)), 0) + 1, 3, '0')) FROM projects p), @project_name, @client_name, @location, @description, @start_date, @planned_end_date, @actual_end_date, @planned_budget, @status, (SELECT user_id FROM users WHERE full_name = @project_manager_id LIMIT 1))";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@project_code", currentProjectCode);
                        cmd.Parameters.AddWithValue("@project_name", txtProjectName.Text);
                        cmd.Parameters.AddWithValue("@client_name", txtClientName.Text);
                        cmd.Parameters.AddWithValue("@location", txtLocation.Text);
                        cmd.Parameters.AddWithValue("@description", textBox.Text);
                        cmd.Parameters.AddWithValue("@start_date", dpStart.Value);
                        cmd.Parameters.AddWithValue("@planned_end_date", dpPlannedEnd.Value);
                        cmd.Parameters.AddWithValue("@actual_end_date", dpActualEndDate.Value);

                        decimal budget = 0;
                        decimal.TryParse(txtPlannedBudget.Text, out budget);
                        cmd.Parameters.AddWithValue("@planned_budget", budget);

                        cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@project_manager_id", cmdPM.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Project saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        ClearFields();

                        Projects projects = new Projects();
                        projects.Show();
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
            txtProjectName.Clear();
            txtClientName.Clear();
            txtLocation.Clear();
            txtPlannedBudget.Clear();
            textBox.Clear();
            cmbStatus.SelectedIndex = -1;
            cmdPM.SelectedIndex = -1;
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
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tasks tasks=new Tasks();
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
            Equipment experimentsForm = new Equipment();
            experimentsForm.Show();
            this.Hide();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void materialBtn_Click(object sender, EventArgs e)
        {
            Materials materialsForm = new Materials();
            materialsForm.Show();
            this.Hide();
        }

        private void workersBtn_Click(object sender, EventArgs e)
        {
            Workers workers=new Workers();
            workers.Show();
            this.Hide();
        }

        private void budgetBtn_Click(object sender, EventArgs e)
        {
            Budget budgetForm = new Budget();
            budgetForm.Show();
            this.Hide();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports();
            reportsForm.Show();
            this.Hide();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
            this.Hide(); 
        }

        private void ProjectAddForm_Load(object sender, EventArgs e)
        {
            LoadData();
           
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
            saveProjectData();
          
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProject_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}
