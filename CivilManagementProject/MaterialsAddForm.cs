using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class MaterialsAddForm : Form
    {
        Boolean isEditMode = false;
        String materialStatus;
        String materialSupplierId;

        String materialCode = "";
        Double quantity = 0.00;
        public MaterialsAddForm()
        {   
            InitializeComponent();
            isEditMode= false;
           materialCode= generateMaterialCode();


        }

        public MaterialsAddForm(String code, String name, String category, String unit, String reorderLevel, decimal unitPrice, String supplierId, String status)
        {
            InitializeComponent();

            materialCode = code;
            txtMaterialName.Text = name;
            cmbCategory.Text = category;
            cmbUnit.Text = unit;
            txtReorder.Text = reorderLevel;
            txtUnitPrice.Text = unitPrice.ToString();
            materialStatus = status;
            materialSupplierId = supplierId;

            if (double.TryParse(txtQuantity.Text, out double qty)) {
                quantity = qty;
            }
            else {
                quantity = 0.00;
            }
             


            isEditMode = true;

        }

        private String generateMaterialCode() {
            string newCode = "M001";
            var dbCon = DBConnection.Instance();
            dbCon.ServerName = "localhost";
            dbCon.DatabaseName = "civil_project_management_system";
            dbCon.UserName = "root";
            dbCon.Password = "1234";

            if (dbCon.IsConnect())
            {
                try
                {
                    string query = "SELECT material_code FROM materials ORDER BY material_id DESC LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string lastCode = result.ToString(); 
                            if (lastCode.StartsWith("M") && int.TryParse(lastCode.Substring(1), out int num))
                            {
                                newCode = "M" + (num + 1).ToString(); 
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    // Fallback default
                }
                finally
                {
                    dbCon.Close();
                }
            }
            return newCode;
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

        private void saveMaterials()
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
                    string query = "";

                    // Check if material already exists by material_code or material_name
                    bool exists = false;
                    string checkQuery = "SELECT COUNT(*) FROM materials WHERE material_code = @material_code";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, dbCon.SqlConnection))
                    {
                        checkCmd.Parameters.AddWithValue("@material_code", materialCode);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0) exists = true;
                    }

                    if (isEditMode || exists)
                    {
                        // UPDATE Query if it already exists or in edit mode
                        query = @"UPDATE materials 
                                  SET material_name = @material_name, 
                                      category = @category, 
                                      unit = @unit, 
                                      reorder_level = @reorder_level, 
                                      current_stock=current_stock+@add_amount,
                                      unit_price = @unit_price 
                                  WHERE material_code = @material_code";
                    }
                    else
                    {
                       
                        query = @"INSERT INTO materials (material_code, material_name, category, unit, current_stock, reorder_level, unit_price, status) 
                                  VALUES (@material_code, @material_name, @category, @unit, @current_stock, @reorder_level, @unit_price, @status)";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@material_code", materialCode);
                        cmd.Parameters.AddWithValue("@material_name", txtMaterialName.Text);
                        cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                        cmd.Parameters.AddWithValue("@unit", cmbUnit.Text);
                        cmd.Parameters.AddWithValue("@add_amount", quantity);

                        decimal.TryParse(txtReorder.Text, out decimal reorder);
                        cmd.Parameters.AddWithValue("@reorder_level", reorder);

                        decimal.TryParse(txtUnitPrice.Text, out decimal price);
                        cmd.Parameters.AddWithValue("@unit_price", price);


                        if (!isEditMode && !exists)
                        {
                            cmd.Parameters.AddWithValue("@current_stock", 0.00); // Default stock for new item
                            cmd.Parameters.AddWithValue("@status", "Insufficient");
                        }

                        cmd.ExecuteNonQuery();
                        MessageBox.Show((isEditMode || exists) ? "Material updated successfully!" : "Material added successfully!");

                        Materials materialsForm = new Materials();
                        materialsForm.Show();
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
            saveMaterials();
        }

 
    }
}
