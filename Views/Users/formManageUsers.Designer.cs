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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formManageUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPageTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchUser = new Guna.UI2.WinForms.Guna2Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbUserType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.dgvUser_UserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvUser_Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvUser_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Gname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Gcontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_UserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblPageTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.BackColor = System.Drawing.Color.White;
            this.lblPageTitle.Controls.Add(this.btnBack);
            this.lblPageTitle.Controls.Add(this.label1);
            this.lblPageTitle.Controls.Add(this.btnSearchUser);
            this.lblPageTitle.Controls.Add(this.dgvUsers);
            this.lblPageTitle.Controls.Add(this.txtUserName);
            this.lblPageTitle.Controls.Add(this.cmbUserType);
            this.lblPageTitle.Controls.Add(this.lblBranch);
            this.lblPageTitle.Controls.Add(this.welcomeLabel);
            this.lblPageTitle.Location = new System.Drawing.Point(0, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(885, 696);
            this.lblPageTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(344, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 176;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BorderRadius = 15;
            this.btnSearchUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSearchUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.Location = new System.Drawing.Point(772, 85);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(91, 32);
            this.btnSearchUser.TabIndex = 175;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsers.ColumnHeadersHeight = 25;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvUser_UserCode,
            this.dgvUser_Edit,
            this.dgvUser_Delete,
            this.dgvUser_FullName,
            this.dgvUser_UserName,
            this.dgvUser_Contact,
            this.dgvUser_Email,
            this.dgvUser_Reg,
            this.dgvUser_DOB,
            this.dgvUser_Gname,
            this.dgvUser_Gcontact,
            this.dgvUser_Class,
            this.dgvUser_UserType,
            this.dgvUser_Gender,
            this.dgvUser_Address,
            this.dgvUser_Subjects,
            this.dgvUser_Date,
            this.dgvUser_Index});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle10;
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
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderRadius = 5;
            this.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(418, 85);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(329, 32);
            this.txtUserName.TabIndex = 172;
            // 
            // cmbUserType
            // 
            this.cmbUserType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbUserType.BackColor = System.Drawing.Color.Transparent;
            this.cmbUserType.BorderRadius = 5;
            this.cmbUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUserType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUserType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUserType.ItemHeight = 19;
            this.cmbUserType.Items.AddRange(new object[] {
            "Admin",
            "Student",
            "Teacher"});
            this.cmbUserType.Location = new System.Drawing.Point(126, 92);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(159, 25);
            this.cmbUserType.TabIndex = 171;
            this.cmbUserType.SelectedIndexChanged += new System.EventHandler(this.cmbUserType_SelectedIndexChanged);
            // 
            // lblBranch
            // 
            this.lblBranch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.lblBranch.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblBranch.Location = new System.Drawing.Point(21, 92);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(99, 25);
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
            // dgvUser_UserCode
            // 
            this.dgvUser_UserCode.Frozen = true;
            this.dgvUser_UserCode.HeaderText = "User #";
            this.dgvUser_UserCode.Name = "dgvUser_UserCode";
            this.dgvUser_UserCode.ReadOnly = true;
            // 
            // dgvUser_Edit
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.dgvUser_Edit.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUser_Edit.Frozen = true;
            this.dgvUser_Edit.HeaderText = "";
            this.dgvUser_Edit.Name = "dgvUser_Edit";
            this.dgvUser_Edit.ReadOnly = true;
            this.dgvUser_Edit.Width = 25;
            // 
            // dgvUser_Delete
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.dgvUser_Delete.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUser_Delete.Frozen = true;
            this.dgvUser_Delete.HeaderText = "";
            this.dgvUser_Delete.Name = "dgvUser_Delete";
            this.dgvUser_Delete.ReadOnly = true;
            this.dgvUser_Delete.Width = 25;
            // 
            // dgvUser_FullName
            // 
            this.dgvUser_FullName.FillWeight = 150F;
            this.dgvUser_FullName.Frozen = true;
            this.dgvUser_FullName.HeaderText = "Full Name";
            this.dgvUser_FullName.Name = "dgvUser_FullName";
            this.dgvUser_FullName.ReadOnly = true;
            this.dgvUser_FullName.Width = 150;
            // 
            // dgvUser_UserName
            // 
            this.dgvUser_UserName.HeaderText = "User Name";
            this.dgvUser_UserName.Name = "dgvUser_UserName";
            this.dgvUser_UserName.ReadOnly = true;
            this.dgvUser_UserName.Width = 150;
            // 
            // dgvUser_Contact
            // 
            this.dgvUser_Contact.HeaderText = "Contact";
            this.dgvUser_Contact.Name = "dgvUser_Contact";
            this.dgvUser_Contact.ReadOnly = true;
            // 
            // dgvUser_Email
            // 
            this.dgvUser_Email.HeaderText = "Email";
            this.dgvUser_Email.Name = "dgvUser_Email";
            this.dgvUser_Email.ReadOnly = true;
            // 
            // dgvUser_Reg
            // 
            this.dgvUser_Reg.HeaderText = "Reg No.";
            this.dgvUser_Reg.Name = "dgvUser_Reg";
            this.dgvUser_Reg.ReadOnly = true;
            // 
            // dgvUser_DOB
            // 
            this.dgvUser_DOB.HeaderText = "Date Of Birth";
            this.dgvUser_DOB.Name = "dgvUser_DOB";
            this.dgvUser_DOB.ReadOnly = true;
            this.dgvUser_DOB.Width = 120;
            // 
            // dgvUser_Gname
            // 
            this.dgvUser_Gname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvUser_Gname.FillWeight = 150F;
            this.dgvUser_Gname.HeaderText = "Gurdian Name";
            this.dgvUser_Gname.Name = "dgvUser_Gname";
            this.dgvUser_Gname.ReadOnly = true;
            this.dgvUser_Gname.Width = 150;
            // 
            // dgvUser_Gcontact
            // 
            this.dgvUser_Gcontact.HeaderText = "Gurdian Contact";
            this.dgvUser_Gcontact.Name = "dgvUser_Gcontact";
            this.dgvUser_Gcontact.ReadOnly = true;
            this.dgvUser_Gcontact.Width = 140;
            // 
            // dgvUser_Class
            // 
            this.dgvUser_Class.HeaderText = "Class";
            this.dgvUser_Class.Name = "dgvUser_Class";
            this.dgvUser_Class.ReadOnly = true;
            // 
            // dgvUser_UserType
            // 
            this.dgvUser_UserType.HeaderText = "User Type";
            this.dgvUser_UserType.Name = "dgvUser_UserType";
            this.dgvUser_UserType.ReadOnly = true;
            // 
            // dgvUser_Gender
            // 
            this.dgvUser_Gender.HeaderText = "Gender";
            this.dgvUser_Gender.Name = "dgvUser_Gender";
            this.dgvUser_Gender.ReadOnly = true;
            // 
            // dgvUser_Address
            // 
            this.dgvUser_Address.FillWeight = 300F;
            this.dgvUser_Address.HeaderText = "Address";
            this.dgvUser_Address.Name = "dgvUser_Address";
            this.dgvUser_Address.ReadOnly = true;
            this.dgvUser_Address.Width = 300;
            // 
            // dgvUser_Subjects
            // 
            this.dgvUser_Subjects.FillWeight = 200F;
            this.dgvUser_Subjects.HeaderText = "Subjects";
            this.dgvUser_Subjects.Name = "dgvUser_Subjects";
            this.dgvUser_Subjects.ReadOnly = true;
            this.dgvUser_Subjects.Width = 200;
            // 
            // dgvUser_Date
            // 
            this.dgvUser_Date.HeaderText = "Updated Date";
            this.dgvUser_Date.Name = "dgvUser_Date";
            this.dgvUser_Date.ReadOnly = true;
            this.dgvUser_Date.Visible = false;
            // 
            // dgvUser_Index
            // 
            this.dgvUser_Index.HeaderText = "";
            this.dgvUser_Index.Name = "dgvUser_Index";
            this.dgvUser_Index.ReadOnly = true;
            this.dgvUser_Index.Visible = false;
            this.dgvUser_Index.Width = 37;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Student_management_system.Properties.Resources.icons8_back_arrow_32;
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 24);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 177;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblPageTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUserType;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label welcomeLabel;
        public System.Windows.Forms.DataGridView dgvUsers;
        private Guna.UI2.WinForms.Guna2Button btnSearchUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_UserCode;
        private System.Windows.Forms.DataGridViewImageColumn dgvUser_Edit;
        private System.Windows.Forms.DataGridViewImageColumn dgvUser_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Gname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Gcontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_UserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Subjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Index;
        private System.Windows.Forms.PictureBox btnBack;
    }
}