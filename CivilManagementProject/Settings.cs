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
    public partial class Settings : Form
    {
        String userId;
        public Settings()
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
        public Settings(String user) : this()
        {
            userId=user;
            txtUser.Text = user;
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
            Reports reportsForm = new Reports();
            reportsForm.Show();
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
    }
}
