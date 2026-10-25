namespace CivilManagementProject
{
    partial class TasksAddForm
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
            this.btnAddTasks = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.txtProjectlName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblPm = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dpActualEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndActual = new System.Windows.Forms.Label();
            this.lblPlannedProgress = new System.Windows.Forms.Label();
            this.dpPlannedEnd = new System.Windows.Forms.DateTimePicker();
            this.dpStartActual = new System.Windows.Forms.DateTimePicker();
            this.lblEndPlanned = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpPlannedStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDatePlanned = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.llbPriority = new System.Windows.Forms.Label();
            this.txtPlannedProgress = new System.Windows.Forms.TextBox();
            this.txtActualProgress = new System.Windows.Forms.TextBox();
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
            // btnAddTasks
            // 
            this.btnAddTasks.BackColor = System.Drawing.Color.Navy;
            this.btnAddTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddTasks.Cursor = System.Windows.Forms.Cursors.No;
            this.btnAddTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTasks.Location = new System.Drawing.Point(430, 49);
            this.btnAddTasks.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddTasks.Name = "btnAddTasks";
            this.btnAddTasks.Size = new System.Drawing.Size(115, 35);
            this.btnAddTasks.TabIndex = 10;
            this.btnAddTasks.Text = "Add Tasks";
            this.btnAddTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTasks.UseVisualStyleBackColor = false;
            this.btnAddTasks.Click += new System.EventHandler(this.btnAddMaterials_Click);
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
            // txtProjectlName
            // 
            this.txtProjectlName.Location = new System.Drawing.Point(256, 103);
            this.txtProjectlName.Name = "txtProjectlName";
            this.txtProjectlName.Size = new System.Drawing.Size(158, 22);
            this.txtProjectlName.TabIndex = 17;
            this.txtProjectlName.TextChanged += new System.EventHandler(this.txtMaterialName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tasks Adding Form";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblName.Location = new System.Drawing.Point(59, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 16);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Project  Name";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTaskName.Location = new System.Drawing.Point(59, 153);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(78, 16);
            this.lblTaskName.TabIndex = 20;
            this.lblTaskName.Text = "Task Name";
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSupplierId.Location = new System.Drawing.Point(59, 239);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(0, 16);
            this.lblSupplierId.TabIndex = 23;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblUnitPrice.Location = new System.Drawing.Point(59, 287);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(0, 16);
            this.lblUnitPrice.TabIndex = 25;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(256, 147);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(158, 22);
            this.txtTaskName.TabIndex = 28;
            // 
            // lblPm
            // 
            this.lblPm.AutoSize = true;
            this.lblPm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPm.Location = new System.Drawing.Point(59, 458);
            this.lblPm.Name = "lblPm";
            this.lblPm.Size = new System.Drawing.Size(102, 16);
            this.lblPm.TabIndex = 58;
            this.lblPm.Text = "Actual Progress";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(256, 535);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(288, 105);
            this.textBox.TabIndex = 57;
            this.textBox.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDescription.Location = new System.Drawing.Point(59, 538);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 56;
            this.lblDescription.Text = "Description";
            // 
            // dpActualEndDate
            // 
            this.dpActualEndDate.Location = new System.Drawing.Point(256, 362);
            this.dpActualEndDate.Name = "dpActualEndDate";
            this.dpActualEndDate.Size = new System.Drawing.Size(200, 22);
            this.dpActualEndDate.TabIndex = 55;
            // 
            // lblEndActual
            // 
            this.lblEndActual.AutoSize = true;
            this.lblEndActual.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblEndActual.Location = new System.Drawing.Point(59, 368);
            this.lblEndActual.Name = "lblEndActual";
            this.lblEndActual.Size = new System.Drawing.Size(108, 16);
            this.lblEndActual.TabIndex = 54;
            this.lblEndActual.Text = "End Date(Actual)";
            // 
            // lblPlannedProgress
            // 
            this.lblPlannedProgress.AutoSize = true;
            this.lblPlannedProgress.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPlannedProgress.Location = new System.Drawing.Point(59, 412);
            this.lblPlannedProgress.Name = "lblPlannedProgress";
            this.lblPlannedProgress.Size = new System.Drawing.Size(115, 16);
            this.lblPlannedProgress.TabIndex = 52;
            this.lblPlannedProgress.Text = "Planned Progress";
            // 
            // dpPlannedEnd
            // 
            this.dpPlannedEnd.Location = new System.Drawing.Point(256, 323);
            this.dpPlannedEnd.Name = "dpPlannedEnd";
            this.dpPlannedEnd.Size = new System.Drawing.Size(200, 22);
            this.dpPlannedEnd.TabIndex = 51;
            // 
            // dpStartActual
            // 
            this.dpStartActual.Location = new System.Drawing.Point(256, 281);
            this.dpStartActual.Name = "dpStartActual";
            this.dpStartActual.Size = new System.Drawing.Size(200, 22);
            this.dpStartActual.TabIndex = 50;
            // 
            // lblEndPlanned
            // 
            this.lblEndPlanned.AutoSize = true;
            this.lblEndPlanned.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblEndPlanned.Location = new System.Drawing.Point(59, 329);
            this.lblEndPlanned.Name = "lblEndPlanned";
            this.lblEndPlanned.Size = new System.Drawing.Size(121, 16);
            this.lblEndPlanned.TabIndex = 48;
            this.lblEndPlanned.Text = "End Date(Planned)";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblStartDate.Location = new System.Drawing.Point(59, 287);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(111, 16);
            this.lblStartDate.TabIndex = 47;
            this.lblStartDate.Text = "Start Date(Actual)";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblStatus.Location = new System.Drawing.Point(59, 196);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 44;
            this.lblStatus.Text = "Status";
            // 
            // dtpPlannedStartDate
            // 
            this.dtpPlannedStartDate.Location = new System.Drawing.Point(256, 233);
            this.dtpPlannedStartDate.Name = "dtpPlannedStartDate";
            this.dtpPlannedStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpPlannedStartDate.TabIndex = 61;
            // 
            // lblStartDatePlanned
            // 
            this.lblStartDatePlanned.AutoSize = true;
            this.lblStartDatePlanned.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblStartDatePlanned.Location = new System.Drawing.Point(59, 239);
            this.lblStartDatePlanned.Name = "lblStartDatePlanned";
            this.lblStartDatePlanned.Size = new System.Drawing.Size(124, 16);
            this.lblStartDatePlanned.TabIndex = 60;
            this.lblStartDatePlanned.Text = "Start Date(Planned)";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "In Progress",
            "Delayed",
            "Pending",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(256, 188);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 24);
            this.cmbStatus.TabIndex = 62;
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Critical",
            "High",
            "Medium"});
            this.cmbPriority.Location = new System.Drawing.Point(256, 491);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(200, 24);
            this.cmbPriority.TabIndex = 64;
            // 
            // llbPriority
            // 
            this.llbPriority.AutoSize = true;
            this.llbPriority.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.llbPriority.Location = new System.Drawing.Point(59, 499);
            this.llbPriority.Name = "llbPriority";
            this.llbPriority.Size = new System.Drawing.Size(48, 16);
            this.llbPriority.TabIndex = 63;
            this.llbPriority.Text = "Priority";
            // 
            // txtPlannedProgress
            // 
            this.txtPlannedProgress.Location = new System.Drawing.Point(256, 406);
            this.txtPlannedProgress.Name = "txtPlannedProgress";
            this.txtPlannedProgress.Size = new System.Drawing.Size(158, 22);
            this.txtPlannedProgress.TabIndex = 65;
            // 
            // txtActualProgress
            // 
            this.txtActualProgress.Location = new System.Drawing.Point(256, 452);
            this.txtActualProgress.Name = "txtActualProgress";
            this.txtActualProgress.Size = new System.Drawing.Size(158, 22);
            this.txtActualProgress.TabIndex = 66;
            // 
            // TasksAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(591, 701);
            this.Controls.Add(this.txtActualProgress);
            this.Controls.Add(this.txtPlannedProgress);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.llbPriority);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtpPlannedStartDate);
            this.Controls.Add(this.lblStartDatePlanned);
            this.Controls.Add(this.lblPm);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dpActualEndDate);
            this.Controls.Add(this.lblEndActual);
            this.Controls.Add(this.lblPlannedProgress);
            this.Controls.Add(this.dpPlannedEnd);
            this.Controls.Add(this.dpStartActual);
            this.Controls.Add(this.lblEndPlanned);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblSupplierId);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProjectlName);
            this.Controls.Add(this.btnAddTasks);
            this.Controls.Add(this.lblTopic);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TasksAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " b";
            this.Load += new System.EventHandler(this.Materials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button btnAddTasks;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.TextBox txtProjectlName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblPm;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dpActualEndDate;
        private System.Windows.Forms.Label lblEndActual;
        private System.Windows.Forms.Label lblPlannedProgress;
        private System.Windows.Forms.DateTimePicker dpPlannedEnd;
        private System.Windows.Forms.DateTimePicker dpStartActual;
        private System.Windows.Forms.Label lblEndPlanned;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtpPlannedStartDate;
        private System.Windows.Forms.Label lblStartDatePlanned;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label llbPriority;
        private System.Windows.Forms.TextBox txtPlannedProgress;
        private System.Windows.Forms.TextBox txtActualProgress;
    }
}
