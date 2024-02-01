namespace Student_management_system.Views.Users
{
    partial class formManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formManageUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPageTitle = new System.Windows.Forms.Panel();
            this.txtEPFNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbAutoOpen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvProduct_ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvProduct_Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvProduct_ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_UnitWeightVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_ShelfLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_SubunitWeightVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_SubUnitsPerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_UnitsPerPack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_UpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_UpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblPageTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.BackColor = System.Drawing.Color.White;
            this.lblPageTitle.Controls.Add(this.btnLogin);
            this.lblPageTitle.Controls.Add(this.dgvUsers);
            this.lblPageTitle.Controls.Add(this.txtEPFNo);
            this.lblPageTitle.Controls.Add(this.cmbAutoOpen);
            this.lblPageTitle.Controls.Add(this.lblBranch);
            this.lblPageTitle.Controls.Add(this.welcomeLabel);
            this.lblPageTitle.Location = new System.Drawing.Point(0, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(885, 696);
            this.lblPageTitle.TabIndex = 3;
            // 
            // txtEPFNo
            // 
            this.txtEPFNo.BorderRadius = 5;
            this.txtEPFNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEPFNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEPFNo.DefaultText = "";
            this.txtEPFNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEPFNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEPFNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEPFNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEPFNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEPFNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEPFNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEPFNo.Location = new System.Drawing.Point(373, 85);
            this.txtEPFNo.Name = "txtEPFNo";
            this.txtEPFNo.PasswordChar = '\0';
            this.txtEPFNo.PlaceholderText = "";
            this.txtEPFNo.SelectedText = "";
            this.txtEPFNo.Size = new System.Drawing.Size(374, 32);
            this.txtEPFNo.TabIndex = 172;
            // 
            // cmbAutoOpen
            // 
            this.cmbAutoOpen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbAutoOpen.BackColor = System.Drawing.Color.Transparent;
            this.cmbAutoOpen.BorderRadius = 5;
            this.cmbAutoOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAutoOpen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAutoOpen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutoOpen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAutoOpen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAutoOpen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAutoOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAutoOpen.ItemHeight = 19;
            this.cmbAutoOpen.Location = new System.Drawing.Point(170, 92);
            this.cmbAutoOpen.Name = "cmbAutoOpen";
            this.cmbAutoOpen.Size = new System.Drawing.Size(176, 25);
            this.cmbAutoOpen.TabIndex = 171;
            // 
            // lblBranch
            // 
            this.lblBranch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.lblBranch.Image = global::Student_management_system.Properties.Resources.icons8_asterisk_8;
            this.lblBranch.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblBranch.Location = new System.Drawing.Point(33, 100);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(99, 17);
            this.lblBranch.TabIndex = 170;
            this.lblBranch.Text = "User Type";
            this.lblBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 36);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(198, 37);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Manage Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 25;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProduct_ProductCode,
            this.dgvProduct_Edit,
            this.dgvProduct_Delete,
            this.dgvProduct_ProdName,
            this.dgvProduct_Manufacturer,
            this.dgvProduct_SupplierName,
            this.dgvProduct_ItemType,
            this.dgvProduct_CategoryName,
            this.dgvProduct_UnitWeightVolume,
            this.dgvProduct_ShelfLocation,
            this.dgvProduct_SubunitWeightVolume,
            this.dgvProduct_SubUnitsPerUnit,
            this.dgvProduct_UnitsPerPack,
            this.dgvProduct_Status,
            this.dgvProduct_CreatedBy,
            this.dgvProduct_CreatedDate,
            this.dgvProduct_UpdatedBy,
            this.dgvProduct_UpdatedDate,
            this.dgvProduct_Index});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Location = new System.Drawing.Point(19, 151);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 45;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.RowTemplate.ReadOnly = true;
            this.dgvUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.ShowCellToolTips = false;
            this.dgvUsers.Size = new System.Drawing.Size(844, 515);
            this.dgvUsers.TabIndex = 174;
            // 
            // dgvProduct_ProductCode
            // 
            this.dgvProduct_ProductCode.Frozen = true;
            this.dgvProduct_ProductCode.HeaderText = "Product #";
            this.dgvProduct_ProductCode.Name = "dgvProduct_ProductCode";
            this.dgvProduct_ProductCode.ReadOnly = true;
            this.dgvProduct_ProductCode.Width = 111;
            // 
            // dgvProduct_Edit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.dgvProduct_Edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct_Edit.Frozen = true;
            this.dgvProduct_Edit.HeaderText = "";
            this.dgvProduct_Edit.Name = "dgvProduct_Edit";
            this.dgvProduct_Edit.ReadOnly = true;
            this.dgvProduct_Edit.Width = 25;
            // 
            // dgvProduct_Delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.dgvProduct_Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct_Delete.Frozen = true;
            this.dgvProduct_Delete.HeaderText = "";
            this.dgvProduct_Delete.Name = "dgvProduct_Delete";
            this.dgvProduct_Delete.ReadOnly = true;
            this.dgvProduct_Delete.Width = 25;
            // 
            // dgvProduct_ProdName
            // 
            this.dgvProduct_ProdName.Frozen = true;
            this.dgvProduct_ProdName.HeaderText = "Product Name";
            this.dgvProduct_ProdName.Name = "dgvProduct_ProdName";
            this.dgvProduct_ProdName.ReadOnly = true;
            this.dgvProduct_ProdName.Width = 300;
            // 
            // dgvProduct_Manufacturer
            // 
            this.dgvProduct_Manufacturer.HeaderText = "Company";
            this.dgvProduct_Manufacturer.Name = "dgvProduct_Manufacturer";
            this.dgvProduct_Manufacturer.ReadOnly = true;
            this.dgvProduct_Manufacturer.Width = 150;
            // 
            // dgvProduct_SupplierName
            // 
            this.dgvProduct_SupplierName.HeaderText = "Supplier";
            this.dgvProduct_SupplierName.Name = "dgvProduct_SupplierName";
            this.dgvProduct_SupplierName.ReadOnly = true;
            this.dgvProduct_SupplierName.Visible = false;
            // 
            // dgvProduct_ItemType
            // 
            this.dgvProduct_ItemType.HeaderText = "Item Type";
            this.dgvProduct_ItemType.Name = "dgvProduct_ItemType";
            this.dgvProduct_ItemType.ReadOnly = true;
            this.dgvProduct_ItemType.Visible = false;
            this.dgvProduct_ItemType.Width = 111;
            // 
            // dgvProduct_CategoryName
            // 
            this.dgvProduct_CategoryName.HeaderText = "Category";
            this.dgvProduct_CategoryName.Name = "dgvProduct_CategoryName";
            this.dgvProduct_CategoryName.ReadOnly = true;
            this.dgvProduct_CategoryName.Width = 150;
            // 
            // dgvProduct_UnitWeightVolume
            // 
            this.dgvProduct_UnitWeightVolume.HeaderText = "Unit Vol";
            this.dgvProduct_UnitWeightVolume.Name = "dgvProduct_UnitWeightVolume";
            this.dgvProduct_UnitWeightVolume.ReadOnly = true;
            // 
            // dgvProduct_ShelfLocation
            // 
            this.dgvProduct_ShelfLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvProduct_ShelfLocation.HeaderText = "Shelf Location";
            this.dgvProduct_ShelfLocation.Name = "dgvProduct_ShelfLocation";
            this.dgvProduct_ShelfLocation.ReadOnly = true;
            this.dgvProduct_ShelfLocation.Width = 135;
            // 
            // dgvProduct_SubunitWeightVolume
            // 
            this.dgvProduct_SubunitWeightVolume.HeaderText = "Subunit W/V";
            this.dgvProduct_SubunitWeightVolume.Name = "dgvProduct_SubunitWeightVolume";
            this.dgvProduct_SubunitWeightVolume.ReadOnly = true;
            this.dgvProduct_SubunitWeightVolume.Visible = false;
            this.dgvProduct_SubunitWeightVolume.Width = 128;
            // 
            // dgvProduct_SubUnitsPerUnit
            // 
            this.dgvProduct_SubUnitsPerUnit.HeaderText = "Subunits per unit";
            this.dgvProduct_SubUnitsPerUnit.Name = "dgvProduct_SubUnitsPerUnit";
            this.dgvProduct_SubUnitsPerUnit.ReadOnly = true;
            this.dgvProduct_SubUnitsPerUnit.Visible = false;
            this.dgvProduct_SubUnitsPerUnit.Width = 156;
            // 
            // dgvProduct_UnitsPerPack
            // 
            this.dgvProduct_UnitsPerPack.HeaderText = "Units Per Pack";
            this.dgvProduct_UnitsPerPack.Name = "dgvProduct_UnitsPerPack";
            this.dgvProduct_UnitsPerPack.ReadOnly = true;
            this.dgvProduct_UnitsPerPack.Visible = false;
            this.dgvProduct_UnitsPerPack.Width = 138;
            // 
            // dgvProduct_Status
            // 
            this.dgvProduct_Status.FillWeight = 120F;
            this.dgvProduct_Status.HeaderText = "Status";
            this.dgvProduct_Status.Name = "dgvProduct_Status";
            this.dgvProduct_Status.ReadOnly = true;
            // 
            // dgvProduct_CreatedBy
            // 
            this.dgvProduct_CreatedBy.FillWeight = 150F;
            this.dgvProduct_CreatedBy.HeaderText = "Created By";
            this.dgvProduct_CreatedBy.Name = "dgvProduct_CreatedBy";
            this.dgvProduct_CreatedBy.ReadOnly = true;
            this.dgvProduct_CreatedBy.Width = 150;
            // 
            // dgvProduct_CreatedDate
            // 
            this.dgvProduct_CreatedDate.HeaderText = "Created Date";
            this.dgvProduct_CreatedDate.Name = "dgvProduct_CreatedDate";
            this.dgvProduct_CreatedDate.ReadOnly = true;
            this.dgvProduct_CreatedDate.Width = 150;
            // 
            // dgvProduct_UpdatedBy
            // 
            this.dgvProduct_UpdatedBy.HeaderText = "Updated By";
            this.dgvProduct_UpdatedBy.Name = "dgvProduct_UpdatedBy";
            this.dgvProduct_UpdatedBy.ReadOnly = true;
            this.dgvProduct_UpdatedBy.Width = 150;
            // 
            // dgvProduct_UpdatedDate
            // 
            this.dgvProduct_UpdatedDate.HeaderText = "Updated Date";
            this.dgvProduct_UpdatedDate.Name = "dgvProduct_UpdatedDate";
            this.dgvProduct_UpdatedDate.ReadOnly = true;
            this.dgvProduct_UpdatedDate.Width = 150;
            // 
            // dgvProduct_Index
            // 
            this.dgvProduct_Index.HeaderText = "";
            this.dgvProduct_Index.Name = "dgvProduct_Index";
            this.dgvProduct_Index.ReadOnly = true;
            this.dgvProduct_Index.Visible = false;
            this.dgvProduct_Index.Width = 37;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(772, 85);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 32);
            this.btnLogin.TabIndex = 175;
            this.btnLogin.Text = "Search";
            // 
            // formManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 708);
            this.Controls.Add(this.lblPageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formManageUsers";
            this.Text = "formManageUsers";
            this.lblPageTitle.ResumeLayout(false);
            this.lblPageTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblPageTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtEPFNo;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAutoOpen;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label welcomeLabel;
        public System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_ProductCode;
        private System.Windows.Forms.DataGridViewImageColumn dgvProduct_Edit;
        private System.Windows.Forms.DataGridViewImageColumn dgvProduct_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_UnitWeightVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_ShelfLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_SubunitWeightVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_SubUnitsPerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_UnitsPerPack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_UpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_UpdatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_Index;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}