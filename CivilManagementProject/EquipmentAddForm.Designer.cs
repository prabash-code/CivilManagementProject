namespace CivilManagementProject
{
    partial class EquipmentAddForm
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
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.txtRentalPerDay = new System.Windows.Forms.TextBox();
            this.lblRentalCost = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.dpPurchase = new System.Windows.Forms.DateTimePicker();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
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
            // btnAddEquipment
            // 
            this.btnAddEquipment.BackColor = System.Drawing.Color.Navy;
            this.btnAddEquipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddEquipment.Cursor = System.Windows.Forms.Cursors.No;
            this.btnAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEquipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddEquipment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEquipment.Location = new System.Drawing.Point(411, 466);
            this.btnAddEquipment.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(115, 35);
            this.btnAddEquipment.TabIndex = 10;
            this.btnAddEquipment.Text = "Add  Equipment";
            this.btnAddEquipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddEquipment.UseVisualStyleBackColor = false;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddMaterials_Click);
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
            // txtEquipmentName
            // 
            this.txtEquipmentName.Location = new System.Drawing.Point(256, 103);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(200, 22);
            this.txtEquipmentName.TabIndex = 17;
            this.txtEquipmentName.TextChanged += new System.EventHandler(this.txtMaterialName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Equipment Adding Form";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblName.Location = new System.Drawing.Point(59, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 16);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Equipment Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPassword.Location = new System.Drawing.Point(59, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 16);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Category";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblModel.Location = new System.Drawing.Point(59, 193);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 16);
            this.lblModel.TabIndex = 21;
            this.lblModel.Text = "Model";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRegNo.Location = new System.Drawing.Point(59, 239);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(103, 16);
            this.lblRegNo.TabIndex = 23;
            this.lblRegNo.Text = "Registration No.";
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.Location = new System.Drawing.Point(256, 236);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(200, 22);
            this.txtRegistrationNumber.TabIndex = 24;
            this.txtRegistrationNumber.TextChanged += new System.EventHandler(this.txtSupplierId_TextChanged);
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPurchaseDate.Location = new System.Drawing.Point(59, 287);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(96, 16);
            this.lblPurchaseDate.TabIndex = 25;
            this.lblPurchaseDate.Text = "Purchase Date";
            // 
            // txtRentalPerDay
            // 
            this.txtRentalPerDay.Location = new System.Drawing.Point(256, 329);
            this.txtRentalPerDay.Name = "txtRentalPerDay";
            this.txtRentalPerDay.Size = new System.Drawing.Size(200, 22);
            this.txtRentalPerDay.TabIndex = 26;
            this.txtRentalPerDay.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // lblRentalCost
            // 
            this.lblRentalCost.AutoSize = true;
            this.lblRentalCost.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRentalCost.Location = new System.Drawing.Point(59, 329);
            this.lblRentalCost.Name = "lblRentalCost";
            this.lblRentalCost.Size = new System.Drawing.Size(131, 16);
            this.lblRentalCost.TabIndex = 28;
            this.lblRentalCost.Text = "Rental Cost(Per day)";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(256, 190);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(200, 22);
            this.txtModel.TabIndex = 31;
            // 
            // dpPurchase
            // 
            this.dpPurchase.Location = new System.Drawing.Point(256, 281);
            this.dpPurchase.Name = "dpPurchase";
            this.dpPurchase.Size = new System.Drawing.Size(200, 22);
            this.dpPurchase.TabIndex = 33;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            " Heavy Machinery       ",
            " Lifting Equipment     ",
            " Concrete Equipment    ",
            " Heavy Machinery       ",
            " Earthmoving Equipment ",
            " Lifting Equipment     ",
            " Transport Equipment   ",
            " Power Equipment       ",
            " Compaction Equipment  ",
            " Temporary Equipment"});
            this.cmbCategory.Location = new System.Drawing.Point(256, 145);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 24);
            this.cmbCategory.TabIndex = 35;
            // 
            // EquipmentAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(591, 577);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.dpPurchase);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblRentalCost);
            this.Controls.Add(this.txtRentalPerDay);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.txtRegistrationNumber);
            this.Controls.Add(this.lblRegNo);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.lblTopic);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipmentAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " b";
            this.Load += new System.EventHandler(this.Materials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.TextBox txtRentalPerDay;
        private System.Windows.Forms.Label lblRentalCost;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.DateTimePicker dpPurchase;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}
