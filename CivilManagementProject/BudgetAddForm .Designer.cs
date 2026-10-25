namespace CivilManagementProject
{
    partial class BudgetAddForm
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
            this.btnAddBudget = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblMaterialCategory = new System.Windows.Forms.Label();
            this.lblPlannedAmount = new System.Windows.Forms.Label();
            this.lblRevicedAmount = new System.Windows.Forms.Label();
            this.txtRrevicedAmount = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.txtPlannedAmount = new System.Windows.Forms.TextBox();
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
            // btnAddBudget
            // 
            this.btnAddBudget.BackColor = System.Drawing.Color.Navy;
            this.btnAddBudget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddBudget.Cursor = System.Windows.Forms.Cursors.No;
            this.btnAddBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddBudget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBudget.Location = new System.Drawing.Point(378, 489);
            this.btnAddBudget.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddBudget.Name = "btnAddBudget";
            this.btnAddBudget.Size = new System.Drawing.Size(115, 35);
            this.btnAddBudget.TabIndex = 10;
            this.btnAddBudget.Text = "Add Budget";
            this.btnAddBudget.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddBudget.UseVisualStyleBackColor = false;
            this.btnAddBudget.Click += new System.EventHandler(this.btnAddMaterials_Click);
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
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Basic Materials ",
            "Structural Materials ",
            "Masonry Materials",
            "Plumbing ",
            "Electrical ",
            "Finishing"});
            this.cmbCategory.Location = new System.Drawing.Point(256, 145);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(158, 24);
            this.cmbCategory.TabIndex = 16;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(256, 103);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(158, 22);
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
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Budget Adding Form";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblProjectName.Location = new System.Drawing.Point(59, 103);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(89, 16);
            this.lblProjectName.TabIndex = 19;
            this.lblProjectName.Text = "Project Name";
            // 
            // lblMaterialCategory
            // 
            this.lblMaterialCategory.AutoSize = true;
            this.lblMaterialCategory.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMaterialCategory.Location = new System.Drawing.Point(59, 153);
            this.lblMaterialCategory.Name = "lblMaterialCategory";
            this.lblMaterialCategory.Size = new System.Drawing.Size(62, 16);
            this.lblMaterialCategory.TabIndex = 20;
            this.lblMaterialCategory.Text = "Category";
            // 
            // lblPlannedAmount
            // 
            this.lblPlannedAmount.AutoSize = true;
            this.lblPlannedAmount.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPlannedAmount.Location = new System.Drawing.Point(59, 193);
            this.lblPlannedAmount.Name = "lblPlannedAmount";
            this.lblPlannedAmount.Size = new System.Drawing.Size(105, 16);
            this.lblPlannedAmount.TabIndex = 21;
            this.lblPlannedAmount.Text = "Planned Amount";
            // 
            // lblRevicedAmount
            // 
            this.lblRevicedAmount.AutoSize = true;
            this.lblRevicedAmount.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRevicedAmount.Location = new System.Drawing.Point(59, 239);
            this.lblRevicedAmount.Name = "lblRevicedAmount";
            this.lblRevicedAmount.Size = new System.Drawing.Size(110, 16);
            this.lblRevicedAmount.TabIndex = 23;
            this.lblRevicedAmount.Text = "Rerviced Amount";
            // 
            // txtRrevicedAmount
            // 
            this.txtRrevicedAmount.Location = new System.Drawing.Point(256, 236);
            this.txtRrevicedAmount.Name = "txtRrevicedAmount";
            this.txtRrevicedAmount.Size = new System.Drawing.Size(158, 22);
            this.txtRrevicedAmount.TabIndex = 24;
            this.txtRrevicedAmount.TextChanged += new System.EventHandler(this.txtSupplierId_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDescription.Location = new System.Drawing.Point(59, 287);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Description";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(256, 275);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(245, 88);
            this.textBox.TabIndex = 58;
            this.textBox.Text = "";
            // 
            // txtPlannedAmount
            // 
            this.txtPlannedAmount.Location = new System.Drawing.Point(256, 193);
            this.txtPlannedAmount.Name = "txtPlannedAmount";
            this.txtPlannedAmount.Size = new System.Drawing.Size(158, 22);
            this.txtPlannedAmount.TabIndex = 60;
            // 
            // BudgetAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(591, 577);
            this.Controls.Add(this.txtPlannedAmount);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtRrevicedAmount);
            this.Controls.Add(this.lblRevicedAmount);
            this.Controls.Add(this.lblPlannedAmount);
            this.Controls.Add(this.lblMaterialCategory);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnAddBudget);
            this.Controls.Add(this.lblTopic);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BudgetAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " b";
            this.Load += new System.EventHandler(this.Materials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button btnAddBudget;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblMaterialCategory;
        private System.Windows.Forms.Label lblPlannedAmount;
        private System.Windows.Forms.Label lblRevicedAmount;
        private System.Windows.Forms.TextBox txtRrevicedAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.TextBox txtPlannedAmount;
    }
}
