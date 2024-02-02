namespace Student_management_system.Views.Classes
{
    partial class formManageClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formManageClass));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPageTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchUser = new Guna.UI2.WinForms.Guna2Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtEPFNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.dgvUser_UserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvProduct_Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvUser_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblPageTitle.Controls.Add(this.welcomeLabel);
            this.lblPageTitle.Location = new System.Drawing.Point(0, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(885, 696);
            this.lblPageTitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(45, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 176;
            this.label1.Text = "Class Name";
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
            this.btnSearchUser.Location = new System.Drawing.Point(478, 96);
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
            this.dgvProduct_Edit,
            this.dgvProduct_Delete,
            this.dgvUser_FullName,
            this.dgvUser_Contact,
            this.dgvUser_Email,
            this.dgvProduct_Index});
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
            this.txtEPFNo.Location = new System.Drawing.Point(129, 96);
            this.txtEPFNo.Name = "txtEPFNo";
            this.txtEPFNo.PasswordChar = '\0';
            this.txtEPFNo.PlaceholderText = "";
            this.txtEPFNo.SelectedText = "";
            this.txtEPFNo.Size = new System.Drawing.Size(324, 32);
            this.txtEPFNo.TabIndex = 172;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 36);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(177, 37);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Mange Class";
            // 
            // dgvUser_UserCode
            // 
            this.dgvUser_UserCode.Frozen = true;
            this.dgvUser_UserCode.HeaderText = "Class #";
            this.dgvUser_UserCode.Name = "dgvUser_UserCode";
            this.dgvUser_UserCode.ReadOnly = true;
            this.dgvUser_UserCode.Width = 111;
            // 
            // dgvProduct_Edit
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.dgvProduct_Edit.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProduct_Edit.Frozen = true;
            this.dgvProduct_Edit.HeaderText = "";
            this.dgvProduct_Edit.Name = "dgvProduct_Edit";
            this.dgvProduct_Edit.ReadOnly = true;
            this.dgvProduct_Edit.Width = 25;
            // 
            // dgvProduct_Delete
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.dgvProduct_Delete.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProduct_Delete.Frozen = true;
            this.dgvProduct_Delete.HeaderText = "";
            this.dgvProduct_Delete.Name = "dgvProduct_Delete";
            this.dgvProduct_Delete.ReadOnly = true;
            this.dgvProduct_Delete.Width = 25;
            // 
            // dgvUser_FullName
            // 
            this.dgvUser_FullName.Frozen = true;
            this.dgvUser_FullName.HeaderText = "Class Name";
            this.dgvUser_FullName.Name = "dgvUser_FullName";
            this.dgvUser_FullName.ReadOnly = true;
            this.dgvUser_FullName.Width = 300;
            // 
            // dgvUser_Contact
            // 
            this.dgvUser_Contact.HeaderText = "Class Teacher Name";
            this.dgvUser_Contact.Name = "dgvUser_Contact";
            this.dgvUser_Contact.ReadOnly = true;
            // 
            // dgvUser_Email
            // 
            this.dgvUser_Email.HeaderText = "Class Teacher ID";
            this.dgvUser_Email.Name = "dgvUser_Email";
            this.dgvUser_Email.ReadOnly = true;
            this.dgvUser_Email.Width = 111;
            // 
            // dgvProduct_Index
            // 
            this.dgvProduct_Index.HeaderText = "";
            this.dgvProduct_Index.Name = "dgvProduct_Index";
            this.dgvProduct_Index.ReadOnly = true;
            this.dgvProduct_Index.Visible = false;
            this.dgvProduct_Index.Width = 37;
            // 
            // formManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 708);
            this.Controls.Add(this.lblPageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formManageClass";
            this.Text = "formManageClass";
            this.lblPageTitle.ResumeLayout(false);
            this.lblPageTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblPageTitle;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSearchUser;
        public System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_UserCode;
        private System.Windows.Forms.DataGridViewImageColumn dgvProduct_Edit;
        private System.Windows.Forms.DataGridViewImageColumn dgvProduct_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_Index;
        private Guna.UI2.WinForms.Guna2TextBox txtEPFNo;
        private System.Windows.Forms.Label welcomeLabel;
    }
}