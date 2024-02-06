namespace Student_management_system.Views.Attendance_Mark
{
    partial class formAddAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddAttendance));
            this.pnlClass = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpAttDate = new System.Windows.Forms.DateTimePicker();
            this.cmbClassName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.pnlClassForm = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvUser_UserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvProduct_Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvUser_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUser_Contact = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvProduct_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAttButtonSet = new System.Windows.Forms.Panel();
            this.btnAttSave = new Guna.UI2.WinForms.Guna2Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.pnlClassForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlAttButtonSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClass
            // 
            this.pnlClass.BackColor = System.Drawing.Color.White;
            this.pnlClass.Controls.Add(this.label4);
            this.pnlClass.Controls.Add(this.btnBack);
            this.pnlClass.Controls.Add(this.label17);
            this.pnlClass.Controls.Add(this.dtpAttDate);
            this.pnlClass.Controls.Add(this.cmbClassName);
            this.pnlClass.Controls.Add(this.lblBranch);
            this.pnlClass.Controls.Add(this.pnlClassForm);
            this.pnlClass.Controls.Add(this.welcomeLabel);
            this.pnlClass.Location = new System.Drawing.Point(0, 12);
            this.pnlClass.Name = "pnlClass";
            this.pnlClass.Size = new System.Drawing.Size(885, 696);
            this.pnlClass.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Student_management_system.Properties.Resources.icons8_back_arrow_32;
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 24);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 218;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.label17.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label17.Location = new System.Drawing.Point(312, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 17);
            this.label17.TabIndex = 217;
            this.label17.Text = "Date :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpAttDate
            // 
            this.dtpAttDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpAttDate.CustomFormat = "dd/MM/yyyy";
            this.dtpAttDate.Enabled = false;
            this.dtpAttDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAttDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAttDate.Location = new System.Drawing.Point(378, 92);
            this.dtpAttDate.MinDate = new System.DateTime(2024, 2, 4, 0, 0, 0, 0);
            this.dtpAttDate.Name = "dtpAttDate";
            this.dtpAttDate.Size = new System.Drawing.Size(159, 25);
            this.dtpAttDate.TabIndex = 216;
            // 
            // cmbClassName
            // 
            this.cmbClassName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbClassName.BackColor = System.Drawing.Color.Transparent;
            this.cmbClassName.BorderRadius = 5;
            this.cmbClassName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClassName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClassName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClassName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbClassName.ItemHeight = 19;
            this.cmbClassName.Location = new System.Drawing.Point(136, 94);
            this.cmbClassName.Name = "cmbClassName";
            this.cmbClassName.Size = new System.Drawing.Size(158, 25);
            this.cmbClassName.TabIndex = 215;
            this.cmbClassName.SelectedIndexChanged += new System.EventHandler(this.cmbClassName_SelectedIndexChanged);
            // 
            // lblBranch
            // 
            this.lblBranch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.lblBranch.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblBranch.Location = new System.Drawing.Point(31, 94);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(99, 25);
            this.lblBranch.TabIndex = 214;
            this.lblBranch.Text = "Class Name";
            this.lblBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlClassForm
            // 
            this.pnlClassForm.BackColor = System.Drawing.Color.White;
            this.pnlClassForm.Controls.Add(this.dgvUsers);
            this.pnlClassForm.Controls.Add(this.pnlAttButtonSet);
            this.pnlClassForm.Location = new System.Drawing.Point(0, 134);
            this.pnlClassForm.Name = "pnlClassForm";
            this.pnlClassForm.Size = new System.Drawing.Size(885, 562);
            this.pnlClassForm.TabIndex = 213;
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
            this.dgvUser_Contact,
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
            this.dgvUsers.Location = new System.Drawing.Point(20, 24);
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
            this.dgvUsers.Size = new System.Drawing.Size(564, 399);
            this.dgvUsers.TabIndex = 214;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            this.dgvUsers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentDoubleClick);
            // 
            // dgvUser_UserCode
            // 
            this.dgvUser_UserCode.HeaderText = "Studuent #";
            this.dgvUser_UserCode.Name = "dgvUser_UserCode";
            this.dgvUser_UserCode.ReadOnly = true;
            this.dgvUser_UserCode.Visible = false;
            this.dgvUser_UserCode.Width = 111;
            // 
            // dgvProduct_Edit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.dgvProduct_Edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct_Edit.HeaderText = "";
            this.dgvProduct_Edit.Name = "dgvProduct_Edit";
            this.dgvProduct_Edit.ReadOnly = true;
            this.dgvProduct_Edit.Visible = false;
            this.dgvProduct_Edit.Width = 25;
            // 
            // dgvProduct_Delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.dgvProduct_Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct_Delete.HeaderText = "";
            this.dgvProduct_Delete.Name = "dgvProduct_Delete";
            this.dgvProduct_Delete.ReadOnly = true;
            this.dgvProduct_Delete.Visible = false;
            this.dgvProduct_Delete.Width = 25;
            // 
            // dgvUser_FullName
            // 
            this.dgvUser_FullName.HeaderText = "Student Name";
            this.dgvUser_FullName.Name = "dgvUser_FullName";
            this.dgvUser_FullName.ReadOnly = true;
            this.dgvUser_FullName.Visible = false;
            this.dgvUser_FullName.Width = 300;
            // 
            // dgvUser_Contact
            // 
            this.dgvUser_Contact.HeaderText = "Status";
            this.dgvUser_Contact.Name = "dgvUser_Contact";
            this.dgvUser_Contact.ReadOnly = true;
            this.dgvUser_Contact.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser_Contact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvUser_Contact.Visible = false;
            // 
            // dgvProduct_Index
            // 
            this.dgvProduct_Index.HeaderText = "";
            this.dgvProduct_Index.Name = "dgvProduct_Index";
            this.dgvProduct_Index.ReadOnly = true;
            this.dgvProduct_Index.Visible = false;
            this.dgvProduct_Index.Width = 37;
            // 
            // pnlAttButtonSet
            // 
            this.pnlAttButtonSet.Controls.Add(this.btnAttSave);
            this.pnlAttButtonSet.Location = new System.Drawing.Point(576, 449);
            this.pnlAttButtonSet.Name = "pnlAttButtonSet";
            this.pnlAttButtonSet.Size = new System.Drawing.Size(276, 72);
            this.pnlAttButtonSet.TabIndex = 213;
            // 
            // btnAttSave
            // 
            this.btnAttSave.BorderRadius = 5;
            this.btnAttSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAttSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAttSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAttSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAttSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAttSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttSave.ForeColor = System.Drawing.Color.White;
            this.btnAttSave.Location = new System.Drawing.Point(141, 13);
            this.btnAttSave.Name = "btnAttSave";
            this.btnAttSave.Size = new System.Drawing.Size(132, 44);
            this.btnAttSave.TabIndex = 209;
            this.btnAttSave.Text = "Save";
            this.btnAttSave.Click += new System.EventHandler(this.btnAttSave_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 36);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(224, 37);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Add Attendance";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Location = new System.Drawing.Point(543, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 95);
            this.label4.TabIndex = 219;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formAddAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 708);
            this.Controls.Add(this.pnlClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAddAttendance";
            this.Text = "formAddAttendance";
            this.Load += new System.EventHandler(this.formAddAttendance_Load);
            this.pnlClass.ResumeLayout(false);
            this.pnlClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.pnlClassForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlAttButtonSet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClass;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpAttDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbClassName;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Panel pnlClassForm;
        public System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlAttButtonSet;
        private Guna.UI2.WinForms.Guna2Button btnAttSave;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_UserCode;
        private System.Windows.Forms.DataGridViewImageColumn dgvProduct_Edit;
        private System.Windows.Forms.DataGridViewImageColumn dgvProduct_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUser_FullName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvUser_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_Index;
        private System.Windows.Forms.Label label4;
    }
}