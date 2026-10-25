using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using MySql.Data.MySqlClient;
using Net.Pkcs11Interop.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CivilManagementProject
{
    public partial class Reports : Form
    {
        List<users> employeeData;
        List<materials> materialsData;
        List<equipment> equipmentData;
        List<budget> budgetData;
        List<project_summary> projectSummaryData;
        String userId;

        public Reports()
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

        public Reports(String user) : this()
        {
            userId = user;
            txtUser.Text = user;
        }

        private void LoadUserDataToTable()
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
                    string query = "SELECT * FROM users";
                    employeeData = new List<users>();

                    using (MySqlCommand adapter = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        using (MySqlDataReader reader = adapter.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                employeeData.Add(new users
                                {
                                    full_name = reader["full_name"].ToString(),
                                    email = reader["email"].ToString(),
                                    phone = reader["phone"].ToString(),
                                    username = reader["username"].ToString(),
                                    status = reader["status"].ToString()
                                });
                            }
                        }
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

        private void LoadBudgetDataToTable()
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
                    budgetData = new List<budget>();

                    using (MySqlCommand adapter = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        using (MySqlDataReader reader = adapter.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                budgetData.Add(new budget
                                {
                                    project_id = reader["project_id"].ToString(),
                                    category = reader["category"].ToString(),
                                    planned_amount = reader["planned_amount"].ToString(),
                                    revised_amount = reader["revised_amount"].ToString(),
                                    description = reader["description"].ToString(),
                                    
                                });
                            }
                        }
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

        private void LoadProjectDataToTable()
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
                    string query = "SELECT project_code, project_name, client_name, location, start_date, planned_end_date, planned_budget, status FROM projects";
                    projectSummaryData = new List<project_summary>();

                    using (MySqlCommand adapter = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        using (MySqlDataReader reader = adapter.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                projectSummaryData.Add(new project_summary
                                {
                                    project_code = reader["project_code"].ToString(),
                                    project_name = reader["project_name"].ToString(),
                                    client_name = reader["client_name"].ToString(),
                                    location = reader["location"].ToString(),
                                    start_date = reader["start_date"] != DBNull.Value ? Convert.ToDateTime(reader["start_date"]).ToString("yyyy-MM-dd") : "-",
                                    planned_end_date = reader["planned_end_date"] != DBNull.Value ? Convert.ToDateTime(reader["planned_end_date"]).ToString("yyyy-MM-dd") : "-",
                                    planned_budget = reader["planned_budget"] != DBNull.Value ? reader["planned_budget"].ToString() : "0.00",
                                    status = reader["status"].ToString()
                                });
                            }
                        }
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

        private void LoadMaterialsDataToTable()
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
                    materialsData = new List<materials>();

                    using (MySqlCommand adapter = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        using (MySqlDataReader reader = adapter.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                materialsData.Add(new materials
                                {
                                    material_code = reader["material_code"].ToString(),
                                    material_name = reader["material_name"].ToString(),
                                    category = reader["category"].ToString(),
                                    unit = reader["unit"].ToString(),
                                    current_stock = reader["current_stock"].ToString(),
                                    reorder_level = reader["reorder_level"].ToString(),
                                    unit_price = reader["unit_price"].ToString(),
                                    supplier_id = reader["supplier_id"].ToString(),
                                    status = reader["status"].ToString()
                                });
                            }
                        }
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

        private void LoadEquipmentDataToTable()
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
                    equipmentData = new List<equipment>();

                    using (MySqlCommand adapter = new MySqlCommand(query, dbCon.SqlConnection))
                    {
                        using (MySqlDataReader reader = adapter.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                equipmentData.Add(new equipment
                                {
                                    equipment_code = reader["equipment_code"].ToString(),
                                    equipment_name = reader["equipment_name"].ToString(),
                                    category = reader["category"].ToString(),
                                    model = reader["model"] != DBNull.Value ? reader["model"].ToString() : "-",
                                    registration_no = reader["registration_no"] != DBNull.Value ? reader["registration_no"].ToString() : "-",
                                    purchase_date = reader["purchase_date"] != DBNull.Value ? Convert.ToDateTime(reader["purchase_date"]).ToString("yyyy-MM-dd") : "-",
                                    rental_cost_per_day = reader["rental_cost_per_day"] != DBNull.Value ? reader["rental_cost_per_day"].ToString() : "0.00",
                                    operating_hours = reader["operating_hours"] != DBNull.Value ? reader["operating_hours"].ToString() : "0.00",
                                    status = reader["status"].ToString(),
                                    next_maintenance_date = reader["next_maintenance_date"] != DBNull.Value ? Convert.ToDateTime(reader["next_maintenance_date"]).ToString("yyyy-MM-dd") : "-"
                                });
                            }
                        }
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

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

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

        private void label1_Click_1(object sender, EventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e) { }

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

        private void Reports_Load(object sender, EventArgs e) { }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings(userId);
            settingsForm.Show();
            this.Hide();
        }

        private void materialBtn_Click(object sender, EventArgs e)
        {
            Materials materialForm = new Materials(userId);
            materialForm.Show();
            this.Hide();
        }

        private void workersBtn_Click(object sender, EventArgs e)
        {
            Workers workersForm = new Workers();
            workersForm.Show();
        }

        private void budgetBtn_Click(object sender, EventArgs e)
        {
            Budget budgetForm = new Budget(userId);
            budgetForm.Show();
            this.Hide();
        }

        //Budget Report
        private void btnBudgetDownload_Click(object sender, EventArgs e) {
            LoadBudgetDataToTable();
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Document (*.pdf)|*.pdf";
                saveFileDialog.FileName = "BudgetSummaryReport.pdf";
                saveFileDialog.Title = "Select Save Location";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PdfDocument document = new PdfDocument();
                        document.Info.Title = "Budget Summary Report";

                        string[] headers = { "Project_Id","Category","planned_budget","Revised_budget","description"  };
                        double[] colWidths = { 50,70 , 70, 70, 200};

                        var rows = new List<string[]>();
                        foreach (var bd in budgetData)
                        {
                            rows.Add(new string[] {
                                bd.project_id, bd.category, bd.planned_amount,
                                bd.revised_amount,bd.description
                            });
                        }

                        DrawPdfTable(document, "Budget Summary Report", headers, colWidths, rows, false);
                        document.Save(saveFileDialog.FileName);

                        MessageBox.Show("PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports(userId);
            reportsForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme(this);
        }

        //Project Report
        private void btnDownloadProjectSummary_Click(object sender, EventArgs e)
        {
            LoadProjectDataToTable();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Document (*.pdf)|*.pdf";
                saveFileDialog.FileName = "ProjectSummaryReport.pdf";
                saveFileDialog.Title = "Select Save Location";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PdfDocument document = new PdfDocument();
                        document.Info.Title = "Project Summary Report";

                        // Columns: Code, Name, Client, Location, Start Date, End Date, Budget, Status
                        string[] headers = { "Project Code", "Project Name", "Client Name", "Location", "Start Date", "End Date", "Budget", "Status" };
                        double[] colWidths = { 65, 110, 95, 75, 65, 65, 65, 55 };

                        var rows = new List<string[]>();
                        foreach (var proj in projectSummaryData)
                        {
                            rows.Add(new string[] {
                                proj.project_code,
                                proj.project_name,
                                proj.client_name,
                                proj.location,
                                proj.start_date,
                                proj.planned_end_date,
                                proj.planned_budget,
                                proj.status
                            });
                        }

                        DrawPdfTable(document, "Project Summary Report", headers, colWidths, rows, true);
                        document.Save(saveFileDialog.FileName);

                        MessageBox.Show("Project Summary PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Material Report
        private void btnMaterialReportDownload_Click(object sender, EventArgs e)
        {
            LoadMaterialsDataToTable();
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Document (*.pdf)|*.pdf";
                saveFileDialog.FileName = "MaterialsSummaryReport.pdf";
                saveFileDialog.Title = "Select Save Location";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PdfDocument document = new PdfDocument();
                        document.Info.Title = "Materials Summary Report";

                        string[] headers = { "Code", "Name", "Category", "Unit", "Stock", "Reorder", "Price", "Supp ID", "Status" };
                        double[] colWidths = { 50, 90, 70, 40, 50, 50, 50, 50, 50 };

                        var rows = new List<string[]>();
                        foreach (var mat in materialsData)
                        {
                            rows.Add(new string[] {
                                mat.material_code, mat.material_name, mat.category, mat.unit,
                                mat.current_stock, mat.reorder_level, mat.unit_price, mat.supplier_id, mat.status
                            });
                        }

                        DrawPdfTable(document, "Materials Summary Report", headers, colWidths, rows, false);
                        document.Save(saveFileDialog.FileName);

                        MessageBox.Show("PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Workers Report
        private void btnWorkersDownload_Click(object sender, EventArgs e)
        {
            LoadUserDataToTable();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Document (*.pdf)|*.pdf";
                saveFileDialog.FileName = "WorkersReport.pdf";
                saveFileDialog.Title = "Select Save Location";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PdfDocument document = new PdfDocument();
                        document.Info.Title = "Employee Report";

                        string[] headers = { "Name", "Email", "Phone", "Role", "Status" };
                        double[] colWidths = { 120, 150, 80, 80, 70 };

                        var rows = new List<string[]>();
                        foreach (var emp in employeeData)
                        {
                            rows.Add(new string[] {
                                emp.full_name, emp.email, emp.phone, emp.username, emp.status
                            });
                        }

                        DrawPdfTable(document, "Employee Report", headers, colWidths, rows, false);
                        document.Save(saveFileDialog.FileName);

                        MessageBox.Show("PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Equipment Report
        private void btnEquipmentDownload_Click(object sender, EventArgs e)
        {
            LoadEquipmentDataToTable();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Document (*.pdf)|*.pdf";
                saveFileDialog.FileName = "EquipmentReport.pdf";
                saveFileDialog.Title = "Select Save Location";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PdfDocument document = new PdfDocument();
                        document.Info.Title = "Equipment Report";

                        string[] headers = { "Code", "Name", "Category", "Model", "Reg. No", "Purchase Date", "Rental/Day", "Op. Hours", "Status", "Next Maint." };
                        double[] colWidths = { 45, 75, 65, 55, 55, 65, 55, 50, 50, 65 };

                        var rows = new List<string[]>();
                        foreach (var eq in equipmentData)
                        {
                            rows.Add(new string[] {
                                eq.equipment_code, eq.equipment_name, eq.category, eq.model,
                                eq.registration_no, eq.purchase_date, eq.rental_cost_per_day,
                                eq.operating_hours, eq.status, eq.next_maintenance_date
                            });
                        }

                        DrawPdfTable(document, "Equipment Report", headers, colWidths, rows, true);
                        document.Save(saveFileDialog.FileName);

                        MessageBox.Show("Equipment PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // PDF Helper
        private void DrawPdfTable(PdfDocument document, string reportTitle, string[] headers, double[] colWidths, List<string[]> rows, bool isLandscape)
        {
            PdfPage page = document.AddPage();
            if (isLandscape)
            {
                page.Orientation = PdfSharp.PageOrientation.Landscape;
            }

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont titleFont = new XFont("Arial", 16);
            XFont headerFont = new XFont("Arial", 9);
            XFont cellFont = new XFont("Arial", 8);

            double margin = 40;
            double yPosition = margin;

            // Title
            gfx.DrawString(reportTitle, titleFont, XBrushes.DarkBlue, new XRect(margin, yPosition, page.Width.Point - (2 * margin), 30), XStringFormats.TopLeft);
            yPosition += 35;

            double startX = margin;
            double rowHeight = 22;

            // Draw Headers
            gfx.DrawRectangle(XPens.DarkGray, XBrushes.LightGray, startX, yPosition, colWidths.Sum(), rowHeight);
            double currentX = startX;
            for (int i = 0; i < headers.Length; i++)
            {
                gfx.DrawRectangle(XPens.DarkGray, currentX, yPosition, colWidths[i], rowHeight);
                gfx.DrawString(headers[i], headerFont, XBrushes.Black, new XRect(currentX + 3, yPosition + 4, colWidths[i] - 6, rowHeight), XStringFormats.TopLeft);
                currentX += colWidths[i];
            }
            yPosition += rowHeight;

            // Draw Rows
            foreach (var row in rows)
            {
                if (yPosition + rowHeight > page.Height.Point - margin)
                {
                    page = document.AddPage();
                    if (isLandscape) page.Orientation = PdfSharp.PageOrientation.Landscape;
                    gfx = XGraphics.FromPdfPage(page);
                    yPosition = margin;
                }

                currentX = startX;
                for (int i = 0; i < row.Length; i++)
                {
                    gfx.DrawRectangle(XPens.LightGray, currentX, yPosition, colWidths[i], rowHeight);

                    string text = row[i] ?? "";
                    gfx.DrawString(text, cellFont, XBrushes.DarkSlateGray, new XRect(currentX + 3, yPosition + 5, colWidths[i] - 6, rowHeight), XStringFormats.TopLeft);
                    currentX += colWidths[i];
                }
                yPosition += rowHeight;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void btnProgressDownload_Click(object sender, EventArgs e) { }
    }

    public class users
    {
        public string full_name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string username { get; set; }
        public string status { get; set; }
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

    public class equipment
    {
        public string equipment_code { get; set; }
        public string equipment_name { get; set; }
        public string category { get; set; }
        public string model { get; set; }
        public string registration_no { get; set; }
        public string purchase_date { get; set; }
        public string rental_cost_per_day { get; set; }
        public string operating_hours { get; set; }
        public string status { get; set; }
        public string next_maintenance_date { get; set; }
    }

    public class budget
    {
        public string project_id { get; set; }
        public string category { get; set; }
        public string planned_amount { get; set; }
        public string revised_amount { get; set; }
        public string description { get; set; }
    }

    public class project_summary
    {
        public string project_code { get; set; }
        public string project_name { get; set; }
        public string client_name { get; set; }
        public string location { get; set; }
        public string start_date { get; set; }
        public string planned_end_date { get; set; }
        public string planned_budget { get; set; }
        public string status { get; set; }
    }
}