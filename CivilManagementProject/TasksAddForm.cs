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
    public partial class TasksAddForm : Form
    {
        private bool isEditMode = false;
        public TasksAddForm()
        {   
            InitializeComponent();
           

            }

        public TasksAddForm(String projectName,String taskName, String description, DateTime plannedStartDATE, DateTime plannedEndDate, DateTime actualStartDate, DateTime actualEndDate, String plannedProgress, String actualProgress, String priority, String status)
        {
            InitializeComponent();
            isEditMode = true;
            txtProjectlName.Text = projectName;
            txtTaskName.Text = taskName;
            textBox.Text = description;
            dtpPlannedStartDate.Value = plannedStartDATE;
            dpStartActual.Value = plannedEndDate;
            dpPlannedEnd.Value = actualStartDate;
            dpActualEndDate.Value = actualEndDate;
            txtPlannedProgress.Text = plannedProgress;
            txtActualProgress.Text = actualProgress;
            cmbPriority.Text = priority;
            cmbStatus.Text = status;

        }
        private void SaveData()
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
                        query = "UPDATE tasks SET project_id=@projectName, task_name=@taskName, description=@description, planned_start_date=@plannedStartDate, planned_end_date=@plannedEndDate, actual_start_date=@actualStartDate, actual_end_date=@actualEndDate, planned_progress=@plannedProgress, actual_progress=@actualProgress, priority=@priority, status=@status WHERE task_name=@taskName";

                    }
                    else
                    {
                        query = "INSERT INTO tasks (project_id, task_name, description, planned_start_date, planned_end_date, actual_start_date, actual_end_date, planned_progress, actual_progress, priority, status) VALUES (@projectName, @taskName, @description, @plannedStartDate, @plannedEndDate, @actualStartDate, @actualEndDate, @plannedProgress, @actualProgress, @priority, @status)";
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@projectName", txtProjectlName.Text);
                        cmd.Parameters.AddWithValue("@taskName", txtTaskName.Text);
                        cmd.Parameters.AddWithValue("@description", textBox.Text);
                        cmd.Parameters.AddWithValue("@plannedStartDate", dtpPlannedStartDate.Value);
                        cmd.Parameters.AddWithValue("@plannedEndDate", dpStartActual.Value);
                        cmd.Parameters.AddWithValue("@actualStartDate", dpPlannedEnd.Value);
                        cmd.Parameters.AddWithValue("@actualEndDate", dpActualEndDate.Value);
                        cmd.Parameters.AddWithValue("@plannedProgress", txtPlannedProgress.Text);
                        cmd.Parameters.AddWithValue("@actualProgress", txtActualProgress.Text);
                        cmd.Parameters.AddWithValue("@priority", cmbPriority.Text);
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data saved successfully.");
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
            SaveData();
        }
    }
}
