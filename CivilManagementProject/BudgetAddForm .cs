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
    public partial class BudgetAddForm : Form
    {
        Boolean isEdit = false;
        int project_id;
        public BudgetAddForm()
        {   
            InitializeComponent();
            isEdit = false;
           

            }

        public BudgetAddForm(int projectId, String category, decimal plannedAmount, decimal revicedAmount, String description)
        {
            InitializeComponent();
            isEdit = true;


            project_id = projectId;
            cmbCategory.Text = category;              
            txtPlannedAmount.Text = plannedAmount.ToString(); // (Planned Amount textbox)
            txtRrevicedAmount.Text = revicedAmount.ToString(); // (Revised Amount textbox)
            textBox.Text = description;

        }

        private void saveOrUpdateBudget()
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
                    String q="Select project_id from projects where project_name = @project_name limit 1";
                    using (MySqlCommand cmd1 = new MySqlCommand(q, dbCon.SqlConnection)) {
                        cmd1.Parameters.AddWithValue("@project_name",txtProjectName.Text);
                        
                        var result=cmd1.ExecuteNonQuery();

                        if (result!=null) {
                            project_id = Convert.ToInt32(result);
                        }
                    }

                        string query = "";

                    if (isEdit)
                    {
                   
                        query = @"UPDATE project_budgets 
                                  SET category = @category, 
                                      description = @description, 
                                      planned_amount = @planned_amount, 
                                      reviced_amount = @reviced_amount 
                                  WHERE project_id = @project_id";
                    }
                    else
                    {
                       
                        query = @"INSERT INTO project_budgets (project_id, category, description, planned_amount, reviced_amount) 
                                  VALUES (@project_id, @category, @description, @planned_amount, @reviced_amount)";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                       
                        cmd.Parameters.AddWithValue("@project_id", project_id);
                        cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                        cmd.Parameters.AddWithValue("@description", textBox.Text);

                        decimal.TryParse(txtPlannedAmount.Text, out decimal planned);
                        cmd.Parameters.AddWithValue("@planned_amount", planned);

                        decimal.TryParse(txtRrevicedAmount.Text, out decimal revised);
                        cmd.Parameters.AddWithValue("@reviced_amount", revised);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show(isEdit ? "Budget updated successfully!" : "Budget added successfully!");

                        // Return to Budget Form
                        Budget budgetForm = new Budget();
                        budgetForm.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                finally
                {
                    dbCon.Close();
                }
            }
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
            saveOrUpdateBudget();
        }
    }
}
