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
    public partial class    EquipmentAddForm : Form
    {
        Boolean isEdit = false;
        String equipmentCode = "";
        String statusEquipment = "Available";
        DateTime nextMaintain = DateTime.Now;

        decimal operatingHrs = 0.00m;

        int equipment_id = 0;


        public EquipmentAddForm()
        {   
            InitializeComponent();
           

            }

        public EquipmentAddForm(String code,String name,String category,String model,String registrationNumber,String status,DateTime purchaseDate,decimal rentalPerDay,decimal operatingHours,DateTime nextMaintainDay)
        {
            InitializeComponent();
            isEdit = true;

            
            equipmentCode = code;
            statusEquipment = status;
            nextMaintain = nextMaintainDay;
            operatingHrs = operatingHours;
            txtEquipmentName.Text = name;
            cmbCategory.Text = category;
            txtModel.Text = model;
            txtRegistrationNumber.Text = registrationNumber;
            dpPurchase.Value = purchaseDate;
            txtRentalPerDay.Text = rentalPerDay.ToString();
            
        }

        private void saveOrUpdateEquipments()
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
                    String q = "Select equipment_id from equipment where eqipment_name = @equipment_name limit 1";
                    using (MySqlCommand cmd1 = new MySqlCommand(q, dbCon.SqlConnection))
                    {
                        cmd1.Parameters.AddWithValue("@project_name", txtEquipmentName.Text);

                        var result = cmd1.ExecuteNonQuery();

                        if (result != null)
                        {
                            equipment_id = Convert.ToInt32(result);
                        }
                    }

                    string query = "";

                    if (isEdit)
                    {

                        query = @"UPDATE equipment 
                                  SET equipment_name = @equipment_name, 
                                      category = @category, 
                                      model = @model, 
                                      registration_no = @registration_no, 
                                      purchase_date = @purchase_date, 
                                      rental_cost_per_day = @rental_cost_per_day, 
                                      operating_hours = @operating_hours, 
                                      status = @status, 
                                      next_maintenance_date = @next_maintenance_date 
                                  WHERE equipment_id = @equipment_id";
                    }
                    else
                    {

                        query = @"INSERT INTO equipment (equipment_code, equipment_name, category, model, registration_no, purchase_date, rental_cost_per_day, operating_hours, status, next_maintenance_date) 
                                  VALUES (@equipment_code, @equipment_name, @category, @model, @registration_no, @purchase_date, @rental_cost_per_day, @operating_hours, @status, @next_maintenance_date)";
                    
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {

                        cmd.Parameters.AddWithValue("@equipment_name", txtEquipmentName.Text.Trim());
                        cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                        cmd.Parameters.AddWithValue("@model", txtModel.Text.Trim());
                        cmd.Parameters.AddWithValue("@registration_no", txtRegistrationNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@purchase_date", dpPurchase.Value);

                        decimal.TryParse(txtRentalPerDay.Text, out decimal rentalPerDay);
                        cmd.Parameters.AddWithValue("@rental_cost_per_day", rentalPerDay);

                        cmd.Parameters.AddWithValue("@operating_hours", operatingHrs);
                        cmd.Parameters.AddWithValue("@status", statusEquipment);
                        cmd.Parameters.AddWithValue("@next_maintenance_date", nextMaintain);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show(isEdit ? "Equipment updated successfully!" : "Equipment added successfully!");

                        Equipment equipmentForm = new Equipment();
                        equipmentForm.Show();
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
            saveOrUpdateEquipments();
        }
    }
}
