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
    public partial class Tasks : Form
    {
        String userId;
        public Tasks()
        {   
            InitializeComponent();
           
                dashboardBtn.Image = new Bitmap(dashboardBtn.Image, new Size(15,15));
                propertiesBtn.Image = new Bitmap(propertiesBtn.Image, new Size(15, 15));
                taskBtn.Image = new Bitmap(taskBtn.Image, new Size(15, 15));
                workersBtn.Image = new Bitmap(workersBtn.Image, new Size(15, 15));
                materialBtn.Image = new Bitmap(materialBtn.Image, new Size(15, 15));
                experimentBtn.Image = new Bitmap(experimentBtn.Image, new Size(15, 15));
                budgetBtn.Image = new Bitmap(budgetBtn.Image, new Size(15, 15));
                reportBtn.Image = new Bitmap(reportBtn.Image, new Size(15, 15));
                settingsBtn.Image = new Bitmap(settingsBtn.Image, new Size(15, 15));



        }
        public Tasks(String user) : this()
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
                    string query = "SELECT project_id,task_name,description,planned_start_date,planned_end_date,actual_start_date,actual_end_date,planned_progress,actual_progress,priority,status FROM tasks";

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
            Projects projectsForm = new Projects(userId);
            projectsForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tasks tasks=new Tasks(userId);
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
            Materials materials=new Materials(userId);
            materials.Show();
            this.Hide();
        }

        private void workersBtn_Click(object sender, EventArgs e)
        {
            Workers workersForm = new Workers(userId);    
            workersForm.Show();
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
            Settings settingsForm = new Settings(userId);
            settingsForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            LoadDataToTable();
        }

        private void btnAddTasks_Click(object sender, EventArgs e)
        {
            TasksAddForm tasksAddForm = new TasksAddForm(
                projectName:"",
                taskName:"",
                description:"",
                plannedStartDATE: DateTime.Now,
                plannedEndDate:DateTime.Now,
                actualStartDate: DateTime.Now,
                actualEndDate: DateTime.Now,
                plannedProgress:"",
                actualProgress:"",
                priority : "",
                status : ""

                );

            tasksAddForm.Show();
            this.Hide();
        }

        private void btnEditTasks_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];

            String projectName = row.Cells["project_id"].Value?.ToString() ?? "";
            String taskName = row.Cells["task_name"].Value?.ToString() ?? "";
            String description = row.Cells["description"].Value?.ToString() ?? "";  
            DateTime startPlannedDate = row.Cells["planned_start_date"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["planned_start_date"].Value) : DateTime.Now;
            DateTime endPlannedDate = row.Cells["planned_end_date"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["planned_end_date"].Value) : DateTime.Now;
            DateTime startActualDate = row.Cells["actual_start_date"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["actual_start_date"].Value) : DateTime.Now;
            DateTime endActualDate = row.Cells["actual_end_date"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["actual_end_date"].Value) : DateTime.Now;
            String plannedProgress = row.Cells["planned_progress"].Value?.ToString() ?? "";
            String actualProgress = row.Cells["actual_progress"].Value?.ToString() ?? "";
            String priority = row.Cells["priority"].Value?.ToString() ?? "";
            String status = row.Cells["status"].Value?.ToString() ?? "";
            
            TasksAddForm tasksAddForm = new TasksAddForm(
                projectName,
                taskName,
                description,
                startPlannedDate,
                endPlannedDate,
                startActualDate,
                endActualDate,
                plannedProgress,
                actualProgress,
                priority,
                status
            );
            tasksAddForm.Show();
            this.Hide();
        }

        private void btnDeleteTasks_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];
            string task = row.Cells["task_name"].Value?.ToString() ?? "";

            var dbCon = DBConnection.Instance();
            dbCon.ServerName = "localhost";
            dbCon.DatabaseName = "civil_project_management_system";
            dbCon.UserName = "root";
            dbCon.Password = "1234";

            if (dbCon.IsConnect())
            {
                try
                {
                    string query = "DELETE FROM tasks WHERE task_name = @task_name";

                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@task_name", task);
                        cmd.ExecuteNonQuery();
                        LoadDataToTable();

                    }
                    MessageBox.Show("Task deleted successfully.");
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
    }
}
