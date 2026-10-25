namespace CivilManagementProject
{
    partial class ProjectAddForm
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
            this.btnAddProject = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.txtPlannedBudget = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndPlanned = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.dpPlannedEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblEndActual = new System.Windows.Forms.Label();
            this.dpActualEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.lblPm = new System.Windows.Forms.Label();
            this.cmdPM = new System.Windows.Forms.ComboBox();
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
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.Navy;
            this.btnAddProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddProject.Cursor = System.Windows.Forms.Cursors.No;
            this.btnAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProject.Location = new System.Drawing.Point(429, 621);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(115, 35);
            this.btnAddProject.TabIndex = 10;
            this.btnAddProject.Text = "Add  Project";
            this.btnAddProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProject.UseVisualStyleBackColor = false;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddMaterials_Click);
            this.btnAddProject.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnAddProject_DragEnter);
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
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(256, 103);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(200, 22);
            this.txtProjectName.TabIndex = 17;
            this.txtProjectName.TextChanged += new System.EventHandler(this.txtMaterialName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Project  Adding Form";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblName.Location = new System.Drawing.Point(59, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 16);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Project Name";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblClient.Location = new System.Drawing.Point(59, 153);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(80, 16);
            this.lblClient.TabIndex = 20;
            this.lblClient.Text = "Client Name";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblLocation.Location = new System.Drawing.Point(59, 196);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(58, 16);
            this.lblLocation.TabIndex = 21;
            this.lblLocation.Text = "Location";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblBudget.Location = new System.Drawing.Point(59, 242);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(103, 16);
            this.lblBudget.TabIndex = 23;
            this.lblBudget.Text = "Planned Budget";
            // 
            // txtPlannedBudget
            // 
            this.txtPlannedBudget.Location = new System.Drawing.Point(256, 236);
            this.txtPlannedBudget.Name = "txtPlannedBudget";
            this.txtPlannedBudget.Size = new System.Drawing.Size(200, 22);
            this.txtPlannedBudget.TabIndex = 24;
            this.txtPlannedBudget.TextChanged += new System.EventHandler(this.txtSupplierId_TextChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblStartDate.Location = new System.Drawing.Point(59, 287);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(66, 16);
            this.lblStartDate.TabIndex = 25;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndPlanned
            // 
            this.lblEndPlanned.AutoSize = true;
            this.lblEndPlanned.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblEndPlanned.Location = new System.Drawing.Point(59, 329);
            this.lblEndPlanned.Name = "lblEndPlanned";
            this.lblEndPlanned.Size = new System.Drawing.Size(121, 16);
            this.lblEndPlanned.TabIndex = 28;
            this.lblEndPlanned.Text = "End Date(Planned)";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(256, 147);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(200, 22);
            this.txtClientName.TabIndex = 30;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(256, 190);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(200, 22);
            this.txtLocation.TabIndex = 31;
            // 
            // dpStart
            // 
            this.dpStart.Location = new System.Drawing.Point(256, 281);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(200, 22);
            this.dpStart.TabIndex = 33;
            // 
            // dpPlannedEnd
            // 
            this.dpPlannedEnd.Location = new System.Drawing.Point(256, 323);
            this.dpPlannedEnd.Name = "dpPlannedEnd";
            this.dpPlannedEnd.Size = new System.Drawing.Size(200, 22);
            this.dpPlannedEnd.TabIndex = 35;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblStatus.Location = new System.Drawing.Point(59, 412);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 36;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Planning",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(256, 404);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 24);
            this.cmbStatus.TabIndex = 37;
            // 
            // lblEndActual
            // 
            this.lblEndActual.AutoSize = true;
            this.lblEndActual.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblEndActual.Location = new System.Drawing.Point(59, 368);
            this.lblEndActual.Name = "lblEndActual";
            this.lblEndActual.Size = new System.Drawing.Size(108, 16);
            this.lblEndActual.TabIndex = 38;
            this.lblEndActual.Text = "End Date(Actual)";
            // 
            // dpActualEndDate
            // 
            this.dpActualEndDate.Location = new System.Drawing.Point(256, 362);
            this.dpActualEndDate.Name = "dpActualEndDate";
            this.dpActualEndDate.Size = new System.Drawing.Size(200, 22);
            this.dpActualEndDate.TabIndex = 39;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDescription.Location = new System.Drawing.Point(59, 508);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 40;
            this.lblDescription.Text = "Description";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(256, 496);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(288, 105);
            this.textBox.TabIndex = 41;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblPm
            // 
            this.lblPm.AutoSize = true;
            this.lblPm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPm.Location = new System.Drawing.Point(59, 458);
            this.lblPm.Name = "lblPm";
            this.lblPm.Size = new System.Drawing.Size(106, 16);
            this.lblPm.TabIndex = 42;
            this.lblPm.Text = "Project Manager";
            // 
            // cmdPM
            // 
            this.cmdPM.FormattingEnabled = true;
            this.cmdPM.Items.AddRange(new object[] {
            "Prabash Withanachchi",
            "Saman Kumara",
            "Dasun De Silva",
            "Kamal Gunathilaka",
            "Supun  Shanaka"});
            this.cmdPM.Location = new System.Drawing.Point(256, 450);
            this.cmdPM.Name = "cmdPM";
            this.cmdPM.Size = new System.Drawing.Size(200, 24);
            this.cmdPM.TabIndex = 43;
            // 
            // ProjectAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(649, 689);
            this.Controls.Add(this.cmdPM);
            this.Controls.Add(this.lblPm);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dpActualEndDate);
            this.Controls.Add(this.lblEndActual);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dpPlannedEnd);
            this.Controls.Add(this.dpStart);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblEndPlanned);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtPlannedBudget);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.lblTopic);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " b";
            this.Load += new System.EventHandler(this.ProjectAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.TextBox txtPlannedBudget;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndPlanned;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.DateTimePicker dpPlannedEnd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblEndActual;
        private System.Windows.Forms.DateTimePicker dpActualEndDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Label lblPm;
        private System.Windows.Forms.ComboBox cmdPM;
    }
}
