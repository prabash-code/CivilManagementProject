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
    public partial class Equipment : Form
    {
        String userId;
        public Equipment()
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

        public Equipment(String user) : this()
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
                    string query = "SELECT * FROM equipment";

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


        private void Equipment_Load(object sender, EventArgs e)
        {
            LoadDataToTable();
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tasks tasks=new Tasks(userId);
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
            Equipment equipmentForm = new Equipment(userId  );
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

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports(userId);
            reportsForm.Show();
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

    

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            EquipmentAddForm equipmentAddForm = new EquipmentAddForm();
            equipmentAddForm.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditMaterials_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];

            string code = row.Cells["equipment_code"].Value?.ToString() ?? "";
            string name = row.Cells["equipment_name "].Value?.ToString() ?? "";
            string category = row.Cells["category"].Value?.ToString() ?? "";
            string model = row.Cells["model"].Value?.ToString() ?? "";
            string registrationNumber = row.Cells["registration_no "].Value?.ToString() ?? "";
            string status = row.Cells["status"].Value?.ToString() ?? "";
            DateTime purchaseDate = DateTime.TryParse(row.Cells["purchase_date"].Value?.ToString(), out var t1) ? t1 : DateTime.Now;
            decimal rentalPerDay = decimal.TryParse(row.Cells["rental_cost_per_day"].Value?.ToString(), out var d) ? d : 0m;
            decimal operatingHours = decimal.TryParse(row.Cells["operating_hours"].Value?.ToString(), out var d1) ? d1 : 0m;
            DateTime nextMaintainDay = DateTime.TryParse(row.Cells["next_maintenance_date"].Value?.ToString(), out var t2) ? t2 : DateTime.Now;


            EquipmentAddForm equipmentAddForm = new EquipmentAddForm(
                code,
                name,
                category,
                model,
                registrationNumber,
                status,
                purchaseDate,
                rentalPerDay,
                operatingHours,
                nextMaintainDay
                );
            equipmentAddForm.Show();
        }

        private void btnDeleteMaterials_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];
            string code = row.Cells["equipment_code"].Value?.ToString() ?? "";

            var dbCon = DBConnection.Instance();
            dbCon.ServerName = "localhost";
            dbCon.DatabaseName = "civil_project_management_system";
            dbCon.UserName = "root";
            dbCon.Password = "1234";

            if (dbCon.IsConnect())
            {
                try
                {
                    string query = "DELETE FROM equipment WHERE equipment_code = @equipment_code";

                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@equipment_code", code);
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
    

