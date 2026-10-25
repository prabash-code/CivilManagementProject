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
    public partial class Materials : Form
    {
        List<materials> materialArray;
        String userId;
        public Materials()
        {
            InitializeComponent();

            dashboardBtn.Image = new Bitmap(dashboardBtn.Image, new Size(15, 15));
            propertiesBtn.Image = new Bitmap(propertiesBtn.Image, new Size(15, 15));
            taskBtn.Image = new Bitmap(taskBtn.Image, new Size(15, 15));
            workersBtn.Image = new Bitmap(workersBtn.Image, new Size(15, 15));
            materialBtn.Image = new Bitmap(materialBtn.Image, new Size(15, 15));
            experimentBtn.Image = new Bitmap(experimentBtn.Image, new Size(15, 15));
            budgetBtn.Image = new Bitmap(budgetBtn.Image, new Size(15, 15));
            reportBtn.Image = new Bitmap(reportBtn.Image, new Size(15, 15));
            settingsBtn.Image = new Bitmap(settingsBtn.Image, new Size(15, 15));
        }
        public Materials(String user) : this()
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

            materialArray = new List<materials>();

            if (dbCon.IsConnect())
            {
                try
                {
                    string query = "SELECT * FROM materials";

                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                materialArray.Add(new materials
                                {
                                    material_code = reader["material_code"] != DBNull.Value ? reader["material_code"].ToString() : "",
                                    material_name = reader["material_name"] != DBNull.Value ? reader["material_name"].ToString() : "",
                                    category = reader["category"] != DBNull.Value ? reader["category"].ToString() : "",
                                    unit = reader["unit"] != DBNull.Value ? reader["unit"].ToString() : "",
                                    current_stock = reader["current_stock"] != DBNull.Value ? reader["current_stock"].ToString() : "0",
                                    reorder_level = reader["reorder_level"] != DBNull.Value ? reader["reorder_level"].ToString() : "0",
                                    unit_price = reader["unit_price"] != DBNull.Value ? reader["unit_price"].ToString() : "0.00",
                                    supplier_id = reader["supplier_id"] != DBNull.Value ? reader["supplier_id"].ToString() : "",
                                    status = reader["status"] != DBNull.Value ? reader["status"].ToString() : ""

                                });
                            }
                        }
                    }

                    // Bind the list to your DataGridView
                    dataGridView1.DataSource = materialArray;
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks(userId);
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
            Equipment experimentsForm = new Equipment(userId);
            experimentsForm.Show();
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
            materialsForm.Show();
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
            Settings settingsForm = new Settings();
            settingsForm.Show();
            this.Hide();

        }

        private void Materials_Load(object sender, EventArgs e)
        {
            LoadDataToTable();
            lowMaterialsAlerts();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddMaterials_Click(object sender, EventArgs e)
        {
            MaterialsAddForm materialsAdd = new MaterialsAddForm(
                );
            materialsAdd.Show();

        }



        private void lowMaterialsAlerts() {
            List<string> alerts = new List<string>();
            foreach (var mat in materialArray)
            {

                if (decimal.TryParse(mat.current_stock, out decimal stock) &&
            decimal.TryParse(mat.reorder_level, out decimal recoarder))
                {
                    if (stock <= recoarder)
                    {
                        alerts.Add($"{mat.material_name} is low quantity");
                    }
                    txtAlerts.Text = string.Join(Environment.NewLine, alerts);
                }
            }
        }

        

        public class materials
        {
            public string material_code { get; set; }
            public string material_name { get; set; }
            public string category { get; set; }
            public string unit { get; set; }
            public string current_stock { get; set; }
            public string reorder_level { get; set; }
            public string unit_price { get; set; }
            public string supplier_id { get; set; }

            public string status { get; set; }
        }

        private void btnEditMaterials_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];

            decimal.TryParse(row.Cells["unit_price"].Value?.ToString(), out decimal price);
            MaterialsAddForm maf = new MaterialsAddForm(
                code: row.Cells["material_code"].Value.ToString(),
                name: row.Cells["material_name"].Value.ToString(),
                category: row.Cells["category"].Value.ToString(),
                unit: row.Cells["unit"].Value.ToString(),
                reorderLevel: row.Cells["reorder_level"].Value.ToString(),
                supplierId: row.Cells["supplier_id"].Value.ToString(),
                unitPrice: price,
                status: ""
            );
            maf.Show();

        }

        private void btnDeleteMaterials_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];
            string code = row.Cells["material_code"].Value?.ToString() ?? "";

            var dbCon = DBConnection.Instance();
            dbCon.ServerName = "localhost";
            dbCon.DatabaseName = "civil_project_management_system";
            dbCon.UserName = "root";
            dbCon.Password = "1234";

            if (dbCon.IsConnect())
            {
                try
                {
                    string query = "DELETE FROM materials WHERE material_code = @material_code";

                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@material_code", code);
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
