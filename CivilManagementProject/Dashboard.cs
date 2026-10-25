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
using System.Windows.Forms.DataVisualization.Charting;

namespace CivilManagementProject
{
   
    public partial class Dashboard : Form
    {
        int projectCount;
        int onTrackCount;
        int atRiskCount;
        int delayedCount;
        String userId;
        public Dashboard()
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

        public Dashboard(String user) :this(){
            userId = user;
          
            txtUser.Text = user;
        }

        private void LoadData()
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
                    string query = "SELECT count(*) FROM projects";
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                        {
                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                projectCount = Convert.ToInt32(result);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data load issue: " + ex.Message);
                }
              

                try
                {
                    string query = "SELECT start_date,planned_end_date,actual_end_date FROM projects";
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, dbCon.SqlConnection))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                // Reset Counters
                                onTrackCount = 0;
                                atRiskCount = 0;
                                delayedCount = 0;

                                DateTime today = DateTime.Today;
                                while (reader.Read())
                                {
                                    DateTime startDate = Convert.ToDateTime(reader["start_date"]);
                                    DateTime plannedEndDate = Convert.ToDateTime(reader["planned_end_date"]);
                                    bool isCompleted = reader["actual_end_date"] != DBNull.Value;

                                    // Already Finished Projects ignore or count as On Track
                                    if (isCompleted)
                                    {
                                        onTrackCount++;
                                        continue;
                                    }

                                    // If ongoing, check dates:
                                    if (today > plannedEndDate)
                                    {

                                        delayedCount++;
                                    }
                                    else
                                    {
                                        // Gap between Start Date & Planned End Date 
                                        double monthsGap = (plannedEndDate - startDate).TotalDays / 30.0;

                                        if (monthsGap < 12)
                                        {

                                            atRiskCount++;
                                        }
                                        else
                                        {

                                            onTrackCount++;
                                        }
                                    }
                                }
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
            Tasks tasks = new Tasks(userId);
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme(this);
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
             
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        { 
        
        }
        private void InitializeChart()
        {
            if (chart == null || chart1 == null) return;

            // Clear existing configurations
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            //Configure Budget Bar Chart (chart)
            ChartArea budgetArea = new ChartArea("BudgetArea");
            budgetArea.AxisX.Interval = 1;
            budgetArea.AxisX.LabelStyle.Angle = -45;
            budgetArea.AxisY.LabelStyle.Format = "C0";
            chart.ChartAreas.Add(budgetArea);

            Series budgetSeries = new Series("Planned Budget")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double,
                ChartArea = "BudgetArea"
            };

            //Configure Worker Role Pie Chart (chart1)
            ChartArea workerArea = new ChartArea("WorkerArea");
            chart1.ChartAreas.Add(workerArea);

            Series workerSeries = new Series("Total Workers")
            {
                ChartType = SeriesChartType.Pie,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32,
                ChartArea = "WorkerArea",
                IsValueShownAsLabel = true // Displays counts directly on pie slices
            };

            //Load Data from MySQL Database
            var dbCon = DBConnection.Instance();
            dbCon.ServerName = "localhost";
            dbCon.DatabaseName = "civil_project_management_system";
            dbCon.UserName = "root";
            dbCon.Password = "1234";

            if (dbCon.IsConnect())
            {
                try
                {
                    //  Load Project Budgets 
                    string budgetQuery = "SELECT project_name, planned_budget FROM projects";
                    using (MySqlCommand cmd = new MySqlCommand(budgetQuery, dbCon.SqlConnection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string projectName = reader["project_name"].ToString();
                            double plannedBudget = Convert.ToDouble(reader["planned_budget"]);
                            budgetSeries.Points.AddXY(projectName, plannedBudget);
                        }
                    }

                    // Aggregate Workers by Role 
                    string workerQuery = "SELECT role, COUNT(*) AS total FROM workers GROUP BY role";
                    using (MySqlCommand cmd = new MySqlCommand(workerQuery, dbCon.SqlConnection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string role = reader["role"].ToString();
                            int count = Convert.ToInt32(reader["total"]);
                            workerSeries.Points.AddXY(role, count);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading chart data: " + ex.Message);
                }
            }

            //Attach Series to Controls
            chart.Series.Add(budgetSeries);
            chart1.Series.Add(workerSeries);
        }

     
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOnTrack_Click(object sender, EventArgs e)
        {
           
        }

        private void lblAtRisk_Click(object sender, EventArgs e)
        {
         
        }

        private void lblDelayed_Click(object sender, EventArgs e)
        {
           
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadData();
            lblTotalProjects.Text = projectCount.ToString();
            lblDelayed.Text = delayedCount.ToString();
            lblAtRisk.Text = atRiskCount.ToString();
            lblOnTrack.Text = onTrackCount.ToString();
            InitializeChart();
            LoadDataToTable();
            LoadDataToDelayedTable();
           
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
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
                    string query = "SELECT material_name,current_stock as available_stock FROM materials where reorder_level<=current_stock ";

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

        private void LoadDataToDelayedTable()
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
                    string query = "SELECT task_name as Task,planned_end_date  as Planned_End_Date,actual_end_date as Actual_End_Date,priority as Priority from tasks where planned_end_date<=actual_end_date";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbCon.SqlConnection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);


                        dataGridView.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
