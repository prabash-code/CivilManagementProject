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
    public partial class Budget : Form       
    {
        String userId;
        public Budget()
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
        public Budget(String userName) :this()
        {
            userId = userName;
            txtUser.Text = userName;
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
                    string query = "SELECT * FROM project_budgets";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbCon.SqlConnection))
                    {
                        DataTable dt = new DataTable(userId);
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
            ;
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard(userId);
            dashboardForm.ShowDialog();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialBtn_Click(object sender, EventArgs e)
        {
            Materials materialsForm = new Materials(userId);
            materialsForm.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            BudgetAddForm budgetAddForm = new BudgetAddForm();
            budgetAddForm.Show();
        }

        private void btnEditMaterials_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];

            int projectId = int.TryParse(row.Cells["project_id"].Value?.ToString(), out var id)?id:0; 
            String category = row.Cells["category"].Value?.ToString() ?? "";
            String description = row.Cells["description"].Value?.ToString()?? "";
            decimal plannedAmount = decimal.TryParse(row.Cells["planned_amount"].Value?.ToString(), out var d) ? d : 0m;
            decimal revicedAmount = decimal.TryParse(row.Cells["reviced_amount"].Value?.ToString(), out var d1) ? d1 : 0m;

            BudgetAddForm workers = new BudgetAddForm(
             projectId,
             category,                 
             plannedAmount,
             revicedAmount,
             description
            
             );
        }

        private void Budget_Load(object sender, EventArgs e)
        {
            LoadDataToTable();
        }
    }
}
