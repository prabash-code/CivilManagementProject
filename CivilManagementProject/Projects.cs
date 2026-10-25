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
    public partial class Projects : Form
    {
        String userId;
        public Projects()
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
        public Projects(String user) : this()
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
                    string query = "SELECT * FROM projects";

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
            Tasks tasksForm = new Tasks(userId);
            tasksForm.Show();
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
            Materials materialsForm = new Materials(userId);
            materialsForm.ShowDialog();
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
            Reports reports = new Reports(userId);
            reports.Show();
            this.Hide();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings(userId);
            settingsForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            LoadDataToTable();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme(this);
        }

        private void btnAddProjects_Click(object sender, EventArgs e)
        {
            var projectAddForm = new ProjectAddForm(
                        projectCode: "",
                        projectName: "",
                        clientName: "",
                        location: "",
                        status: "",
                        startDate: DateTime.Now,
                        plannedEnd: DateTime.Now,
                        actualEnd: DateTime.Now,
                        budget: 0m,
                        projectManager: "",
                        description: ""
);
            projectAddForm.Show();
        }

        private void btnEditMaterials_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
                var row = dataGridView1.SelectedRows[0];

                string code = row.Cells["project_code"].Value?.ToString() ?? "";
                string name = row.Cells["project_name"].Value?.ToString() ?? "";
                string client = row.Cells["client_name"].Value?.ToString() ?? "";
                string location = row.Cells["location"].Value?.ToString() ?? "";
                string status = row.Cells["status"].Value?.ToString() ?? "";

                DateTime start = DateTime.TryParse(row.Cells["start_date"].Value?.ToString(), out var t1) ? t1 : DateTime.Now;
                DateTime plannedEnd = DateTime.TryParse(row.Cells["planned_end_date"].Value?.ToString(), out var t2) ? t2 : DateTime.Now;
                DateTime actualEnd = DateTime.TryParse(row.Cells["actual_end_date"].Value?.ToString(), out var t3) ? t3 : DateTime.Now;
                decimal budget = decimal.TryParse(row.Cells["planned_budget"].Value?.ToString(), out var d) ? d : 0m;

                string pm = row.Cells["project_manager_id"].Value?.ToString() ?? "";
                string description = row.Cells["description"].Value?.ToString() ?? "";

                var paf = new ProjectAddForm(code, name, client, location, status, start, plannedEnd, actualEnd, budget, pm, description);
                paf.Show();
        }

        private void btnDeleteMaterials_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];
            string code = row.Cells["project_code"].Value?.ToString() ?? "";

            var dbCon = DBConnection.Instance();
            dbCon.ServerName = "localhost";
            dbCon.DatabaseName = "civil_project_management_system";
            dbCon.UserName = "root";
            dbCon.Password = "1234";

            if (dbCon.IsConnect())
            {
                try
                {
                    string query = "DELETE FROM projects WHERE project_code = @project_code";

                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@project_code", code);
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
    }
}
