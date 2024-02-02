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
            this.btnSearchUser = new Guna.UI2.WinForms.Guna2Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtEPFNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbAutoOpen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUser_UserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvProduct_Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvUser_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Gname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Gcontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPageTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.BackColor = System.Drawing.Color.White;
            this.lblPageTitle.Controls.Add(this.label1);
            this.lblPageTitle.Controls.Add(this.btnSearchUser);
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
            this.dgvUser_UserCode,
            this.dgvProduct_Edit,
            this.dgvProduct_Delete,
            this.dgvUser_FullName,
            this.dgvUser_UserName,
            this.dgvUser_Contact,
            this.dgvUser_Email,
            this.dgvUser_Reg,
            this.dgvUser_DOB,
            this.dgvUser_Gname,
            this.dgvUser_Gcontact,
            this.dgvUser_Class,
            this.dgvUser_Gender,
            this.dgvUser_Address,
            this.dgvUser_Subjects,
            this.dgvUser_Date,
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
            this.txtEPFNo.Location = new System.Drawing.Point(418, 85);
            this.txtEPFNo.Name = "txtEPFNo";
            this.txtEPFNo.PasswordChar = '\0';
            this.txtEPFNo.PlaceholderText = "";
            this.txtEPFNo.SelectedText = "";
            this.txtEPFNo.Size = new System.Drawing.Size(329, 32);
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
            this.cmbAutoOpen.Location = new System.Drawing.Point(126, 92);
            this.cmbAutoOpen.Name = "cmbAutoOpen";
            this.cmbAutoOpen.Size = new System.Drawing.Size(159, 25);
            this.cmbAutoOpen.TabIndex = 171;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(302, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 176;
            this.label1.Text = "User Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvUser_UserCode
            // 
            this.dgvUser_UserCode.Frozen = true;
            this.dgvUser_UserCode.HeaderText = "User #";
            this.dgvUser_UserCode.Name = "dgvUser_UserCode";
            this.dgvUser_UserCode.ReadOnly = true;
            this.dgvUser_UserCode.Width = 111;
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
            // dgvUser_FullName
            // 
            this.dgvUser_FullName.Frozen = true;
            this.dgvUser_FullName.HeaderText = "Full Name";
            this.dgvUser_FullName.Name = "dgvUser_FullName";
            this.dgvUser_FullName.ReadOnly = true;
            this.dgvUser_FullName.Width = 300;
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
            this.dgvUser_Contact.Visible = false;
            // 
            // dgvUser_Email
            // 
            this.dgvUser_Email.HeaderText = "Email";
            this.dgvUser_Email.Name = "dgvUser_Email";
            this.dgvUser_Email.ReadOnly = true;
            this.dgvUser_Email.Visible = false;
            this.dgvUser_Email.Width = 111;
            // 
            // dgvUser_Reg
            // 
            this.dgvUser_Reg.HeaderText = "Reg No.";
            this.dgvUser_Reg.Name = "dgvUser_Reg";
            this.dgvUser_Reg.ReadOnly = true;
            this.dgvUser_Reg.Width = 150;
            // 
            // dgvUser_DOB
            // 
            this.dgvUser_DOB.HeaderText = "Date Of Birth";
            this.dgvUser_DOB.Name = "dgvUser_DOB";
            this.dgvUser_DOB.ReadOnly = true;
            // 
            // dgvUser_Gname
            // 
            this.dgvUser_Gname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvUser_Gname.HeaderText = "Gurdian Name";
            this.dgvUser_Gname.Name = "dgvUser_Gname";
            this.dgvUser_Gname.ReadOnly = true;
            this.dgvUser_Gname.Width = 135;
            // 
            // dgvUser_Gcontact
            // 
            this.dgvUser_Gcontact.HeaderText = "Gurdian Contact";
            this.dgvUser_Gcontact.Name = "dgvUser_Gcontact";
            this.dgvUser_Gcontact.ReadOnly = true;
            this.dgvUser_Gcontact.Visible = false;
            this.dgvUser_Gcontact.Width = 128;
            // 
            // dgvUser_Class
            // 
            this.dgvUser_Class.HeaderText = "Class";
            this.dgvUser_Class.Name = "dgvUser_Class";
            this.dgvUser_Class.ReadOnly = true;
            this.dgvUser_Class.Visible = false;
            this.dgvUser_Class.Width = 156;
            // 
            // dgvUser_Gender
            // 
            this.dgvUser_Gender.HeaderText = "Gender";
            this.dgvUser_Gender.Name = "dgvUser_Gender";
            this.dgvUser_Gender.ReadOnly = true;
            this.dgvUser_Gender.Visible = false;
            this.dgvUser_Gender.Width = 138;
            // 
            // dgvUser_Address
            // 
            this.dgvUser_Address.FillWeight = 120F;
            this.dgvUser_Address.HeaderText = "Address";
            this.dgvUser_Address.Name = "dgvUser_Address";
            this.dgvUser_Address.ReadOnly = true;
            // 
            // dgvUser_Subjects
            // 
            this.dgvUser_Subjects.FillWeight = 150F;
            this.dgvUser_Subjects.HeaderText = "Subjects";
            this.dgvUser_Subjects.Name = "dgvUser_Subjects";
            this.dgvUser_Subjects.ReadOnly = true;
            this.dgvUser_Subjects.Width = 150;
            // 
            // dgvUser_Date
            // 
            this.dgvUser_Date.HeaderText = "Updated Date";
            this.dgvUser_Date.Name = "dgvUser_Date";
            this.dgvUser_Date.ReadOnly = true;
            this.dgvUser_Date.Width = 150;
            // 
            // dgvProduct_Index
            // 
            this.dgvProduct_Index.HeaderText = "";
            this.dgvProduct_Index.Name = "dgvProduct_Index";
            this.dgvProduct_Index.ReadOnly = true;
            this.dgvProduct_Index.Visible = false;
            this.dgvProduct_Index.Width = 37;
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
        private Guna.UI2.WinForms.Guna2Button btnSearchUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_UserCode;
        private System.Windows.Forms.DataGridViewImageColumn dgvProduct_Edit;
        private System.Windows.Forms.DataGridViewImageColumn dgvProduct_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Gname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Gcontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Subjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_Index;
    }
}