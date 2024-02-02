namespace Student_management_system.Views.Announcements
{
    partial class formManageAnnouncement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formManageAnnouncement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPageTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.dtpTeacherDob = new System.Windows.Forms.DateTimePicker();
            this.dgvAnnou_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvProduct_Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvAnnou_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnnou_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnnou_ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnnou_PubDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPageTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.BackColor = System.Drawing.Color.White;
            this.lblPageTitle.Controls.Add(this.dtpTeacherDob);
            this.lblPageTitle.Controls.Add(this.label1);
            this.lblPageTitle.Controls.Add(this.dgvUsers);
            this.lblPageTitle.Controls.Add(this.welcomeLabel);
            this.lblPageTitle.Location = new System.Drawing.Point(0, 6);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(885, 696);
            this.lblPageTitle.TabIndex = 5;
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
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dgvAnnou_ID,
            this.dgvProduct_Edit,
            this.dgvProduct_Delete,
            this.dgvAnnou_Title,
            this.dgvAnnou_Desc,
            this.dgvAnnou_ExpireDate,
            this.dgvAnnou_PubDate,
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
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 36);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(319, 37);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Manage Annoncements";
            // 
            // dtpTeacherDob
            // 
            this.dtpTeacherDob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpTeacherDob.CustomFormat = "dd/MM/yyyy";
            this.dtpTeacherDob.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTeacherDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTeacherDob.Location = new System.Drawing.Point(96, 103);
            this.dtpTeacherDob.Name = "dtpTeacherDob";
            this.dtpTeacherDob.Size = new System.Drawing.Size(159, 25);
            this.dtpTeacherDob.TabIndex = 194;
            // 
            // dgvAnnou_ID
            // 
            this.dgvAnnou_ID.Frozen = true;
            this.dgvAnnou_ID.HeaderText = "ID #";
            this.dgvAnnou_ID.Name = "dgvAnnou_ID";
            this.dgvAnnou_ID.ReadOnly = true;
            this.dgvAnnou_ID.Width = 111;
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
            // dgvAnnou_Title
            // 
            this.dgvAnnou_Title.Frozen = true;
            this.dgvAnnou_Title.HeaderText = "Title";
            this.dgvAnnou_Title.Name = "dgvAnnou_Title";
            this.dgvAnnou_Title.ReadOnly = true;
            this.dgvAnnou_Title.Width = 300;
            // 
            // dgvAnnou_Desc
            // 
            this.dgvAnnou_Desc.HeaderText = "Description";
            this.dgvAnnou_Desc.Name = "dgvAnnou_Desc";
            this.dgvAnnou_Desc.ReadOnly = true;
            // 
            // dgvAnnou_ExpireDate
            // 
            this.dgvAnnou_ExpireDate.HeaderText = "Expire Date";
            this.dgvAnnou_ExpireDate.Name = "dgvAnnou_ExpireDate";
            this.dgvAnnou_ExpireDate.ReadOnly = true;
            this.dgvAnnou_ExpireDate.Width = 111;
            // 
            // dgvAnnou_PubDate
            // 
            this.dgvAnnou_PubDate.HeaderText = "Published Date";
            this.dgvAnnou_PubDate.Name = "dgvAnnou_PubDate";
            this.dgvAnnou_PubDate.ReadOnly = true;
            // 
            // dgvProduct_Index
            // 
            this.dgvProduct_Index.HeaderText = "";
            this.dgvProduct_Index.Name = "dgvProduct_Index";
            this.dgvProduct_Index.ReadOnly = true;
            this.dgvProduct_Index.Visible = false;
            this.dgvProduct_Index.Width = 37;
            // 
            // formManageAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 708);
            this.Controls.Add(this.lblPageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formManageAnnouncement";
            this.Text = "formManageAnnouncement";
            this.lblPageTitle.ResumeLayout(false);
            this.lblPageTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblPageTitle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.DateTimePicker dtpTeacherDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnnou_ID;
        private System.Windows.Forms.DataGridViewImageColumn dgvProduct_Edit;
        private System.Windows.Forms.DataGridViewImageColumn dgvProduct_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnnou_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnnou_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnnou_ExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnnou_PubDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct_Index;
    }
}