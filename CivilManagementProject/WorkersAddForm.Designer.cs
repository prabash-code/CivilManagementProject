namespace CivilManagementProject
{
    partial class WorkersAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTopic = new System.Windows.Forms.Label();
            this.btnAddWorkers = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblSkill = new System.Windows.Forms.Label();
            this.lblExperiencedYears = new System.Windows.Forms.Label();
            this.txtExperienced = new System.Windows.Forms.TextBox();
            this.lblDailyWage = new System.Windows.Forms.Label();
            this.txtDailyWage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAvailability = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtExperiencedYears = new System.Windows.Forms.TextBox();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.dpHireDate = new System.Windows.Forms.DateTimePicker();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTopic.Location = new System.Drawing.Point(236, 87);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(0, 32);
            this.lblTopic.TabIndex = 1;
            this.lblTopic.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnAddWorkers
            // 
            this.btnAddWorkers.BackColor = System.Drawing.Color.Navy;
            this.btnAddWorkers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddWorkers.Cursor = System.Windows.Forms.Cursors.No;
            this.btnAddWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorkers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddWorkers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddWorkers.Location = new System.Drawing.Point(429, 528);
            this.btnAddWorkers.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddWorkers.Name = "btnAddWorkers";
            this.btnAddWorkers.Size = new System.Drawing.Size(115, 35);
            this.btnAddWorkers.TabIndex = 10;
            this.btnAddWorkers.Text = "Add Workers";
            this.btnAddWorkers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddWorkers.UseVisualStyleBackColor = false;
            this.btnAddWorkers.Click += new System.EventHandler(this.btnAddMaterials_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            " Mason              ",
            " Carpenter          ",
            " Electrician        ",
            " Plumber            ",
            " Labourer           ",
            " Steel Fixer        ",
            " Painter            ",
            " Machine Operator",
            " Tile Worker        ",
            " Site Supervisor"});
            this.cmbRole.Location = new System.Drawing.Point(256, 145);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(158, 24);
            this.cmbRole.TabIndex = 16;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(256, 103);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(158, 22);
            this.txtFullName.TabIndex = 17;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtMaterialName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Workers Adding Form";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFullName.Location = new System.Drawing.Point(59, 103);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(68, 16);
            this.lblFullName.TabIndex = 19;
            this.lblFullName.Text = "Full Name";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRole.Location = new System.Drawing.Point(59, 145);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(36, 16);
            this.lblRole.TabIndex = 20;
            this.lblRole.Text = "Role";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSkill.Location = new System.Drawing.Point(59, 193);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(32, 16);
            this.lblSkill.TabIndex = 21;
            this.lblSkill.Text = "Skill";
            // 
            // lblExperiencedYears
            // 
            this.lblExperiencedYears.AutoSize = true;
            this.lblExperiencedYears.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblExperiencedYears.Location = new System.Drawing.Point(59, 266);
            this.lblExperiencedYears.Name = "lblExperiencedYears";
            this.lblExperiencedYears.Size = new System.Drawing.Size(122, 16);
            this.lblExperiencedYears.TabIndex = 23;
            this.lblExperiencedYears.Text = "Experienced Years";
            // 
            // txtExperienced
            // 
            this.txtExperienced.Location = new System.Drawing.Point(256, 266);
            this.txtExperienced.Name = "txtExperienced";
            this.txtExperienced.Size = new System.Drawing.Size(158, 22);
            this.txtExperienced.TabIndex = 24;
            this.txtExperienced.TextChanged += new System.EventHandler(this.txtSupplierId_TextChanged);
            // 
            // lblDailyWage
            // 
            this.lblDailyWage.AutoSize = true;
            this.lblDailyWage.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDailyWage.Location = new System.Drawing.Point(59, 305);
            this.lblDailyWage.Name = "lblDailyWage";
            this.lblDailyWage.Size = new System.Drawing.Size(78, 16);
            this.lblDailyWage.TabIndex = 25;
            this.lblDailyWage.Text = "Daily Wage";
            // 
            // txtDailyWage
            // 
            this.txtDailyWage.Location = new System.Drawing.Point(256, 305);
            this.txtDailyWage.Name = "txtDailyWage";
            this.txtDailyWage.Size = new System.Drawing.Size(158, 22);
            this.txtDailyWage.TabIndex = 26;
            this.txtDailyWage.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(59, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Experienced Years";
            // 
            // cmbAvailability
            // 
            this.cmbAvailability.FormattingEnabled = true;
            this.cmbAvailability.Items.AddRange(new object[] {
            "Available",
            "Busy"});
            this.cmbAvailability.Location = new System.Drawing.Point(256, 348);
            this.cmbAvailability.Name = "cmbAvailability";
            this.cmbAvailability.Size = new System.Drawing.Size(158, 24);
            this.cmbAvailability.TabIndex = 29;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblStatus.Location = new System.Drawing.Point(59, 348);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(112, 16);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Availability Status";
            // 
            // txtExperiencedYears
            // 
            this.txtExperiencedYears.Location = new System.Drawing.Point(256, 393);
            this.txtExperiencedYears.Name = "txtExperiencedYears";
            this.txtExperiencedYears.Size = new System.Drawing.Size(158, 22);
            this.txtExperiencedYears.TabIndex = 31;
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHireDate.Location = new System.Drawing.Point(63, 473);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(64, 16);
            this.lblHireDate.TabIndex = 32;
            this.lblHireDate.Text = "Hire Date";
            // 
            // dpHireDate
            // 
            this.dpHireDate.Location = new System.Drawing.Point(256, 473);
            this.dpHireDate.Name = "dpHireDate";
            this.dpHireDate.Size = new System.Drawing.Size(200, 22);
            this.dpHireDate.TabIndex = 33;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(256, 187);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(288, 60);
            this.textBox.TabIndex = 42;
            this.textBox.Text = "";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(256, 430);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(158, 22);
            this.txtPhone.TabIndex = 44;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPhone.Location = new System.Drawing.Point(59, 430);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 20);
            this.lblPhone.TabIndex = 43;
            this.lblPhone.Text = "Phone";
            // 
            // WorkersAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(591, 577);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.dpHireDate);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.txtExperiencedYears);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAvailability);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtDailyWage);
            this.Controls.Add(this.lblDailyWage);
            this.Controls.Add(this.txtExperienced);
            this.Controls.Add(this.lblExperiencedYears);
            this.Controls.Add(this.lblSkill);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnAddWorkers);
            this.Controls.Add(this.lblTopic);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkersAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " b";
            this.Load += new System.EventHandler(this.Materials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button btnAddWorkers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.Label lblExperiencedYears;
        private System.Windows.Forms.TextBox txtExperienced;
        private System.Windows.Forms.Label lblDailyWage;
        private System.Windows.Forms.TextBox txtDailyWage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAvailability;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtExperiencedYears;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker dpHireDate;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
    }
}
