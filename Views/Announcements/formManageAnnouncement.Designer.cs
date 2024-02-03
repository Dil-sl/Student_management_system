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
            this.dtpAnnouFilter = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAnnou = new System.Windows.Forms.DataGridView();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.dgvAnnou_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnnou_Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvAnnou_Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvAnnou_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnnou_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnnou_ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnnou_PubDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnnou_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPageTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnou)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.BackColor = System.Drawing.Color.White;
            this.lblPageTitle.Controls.Add(this.dtpAnnouFilter);
            this.lblPageTitle.Controls.Add(this.label1);
            this.lblPageTitle.Controls.Add(this.dgvAnnou);
            this.lblPageTitle.Controls.Add(this.welcomeLabel);
            this.lblPageTitle.Location = new System.Drawing.Point(0, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(885, 696);
            this.lblPageTitle.TabIndex = 5;
            // 
            // dtpAnnouFilter
            // 
            this.dtpAnnouFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpAnnouFilter.CustomFormat = "dd/MM/yyyy";
            this.dtpAnnouFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAnnouFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnnouFilter.Location = new System.Drawing.Point(96, 103);
            this.dtpAnnouFilter.Name = "dtpAnnouFilter";
            this.dtpAnnouFilter.Size = new System.Drawing.Size(159, 25);
            this.dtpAnnouFilter.TabIndex = 194;
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
            // dgvAnnou
            // 
            this.dgvAnnou.AllowUserToAddRows = false;
            this.dgvAnnou.AllowUserToDeleteRows = false;
            this.dgvAnnou.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAnnou.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAnnou.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvAnnou.BackgroundColor = System.Drawing.Color.White;
            this.dgvAnnou.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAnnou.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAnnou.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnnou.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnnou.ColumnHeadersHeight = 25;
            this.dgvAnnou.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAnnou.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvAnnou_ID,
            this.dgvAnnou_Edit,
            this.dgvAnnou_Delete,
            this.dgvAnnou_Title,
            this.dgvAnnou_Desc,
            this.dgvAnnou_ExpireDate,
            this.dgvAnnou_PubDate,
            this.dgvAnnou_Index});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnnou.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAnnou.EnableHeadersVisualStyles = false;
            this.dgvAnnou.Location = new System.Drawing.Point(19, 151);
            this.dgvAnnou.Name = "dgvAnnou";
            this.dgvAnnou.ReadOnly = true;
            this.dgvAnnou.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAnnou.RowHeadersVisible = false;
            this.dgvAnnou.RowHeadersWidth = 45;
            this.dgvAnnou.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAnnou.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAnnou.RowTemplate.Height = 25;
            this.dgvAnnou.RowTemplate.ReadOnly = true;
            this.dgvAnnou.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnnou.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnnou.ShowCellToolTips = false;
            this.dgvAnnou.Size = new System.Drawing.Size(842, 515);
            this.dgvAnnou.TabIndex = 174;
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
            // dgvAnnou_ID
            // 
            this.dgvAnnou_ID.Frozen = true;
            this.dgvAnnou_ID.HeaderText = "ID #";
            this.dgvAnnou_ID.Name = "dgvAnnou_ID";
            this.dgvAnnou_ID.ReadOnly = true;
            this.dgvAnnou_ID.Width = 111;
            // 
            // dgvAnnou_Edit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.dgvAnnou_Edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAnnou_Edit.Frozen = true;
            this.dgvAnnou_Edit.HeaderText = "";
            this.dgvAnnou_Edit.Name = "dgvAnnou_Edit";
            this.dgvAnnou_Edit.ReadOnly = true;
            this.dgvAnnou_Edit.Width = 25;
            // 
            // dgvAnnou_Delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.dgvAnnou_Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAnnou_Delete.Frozen = true;
            this.dgvAnnou_Delete.HeaderText = "";
            this.dgvAnnou_Delete.Name = "dgvAnnou_Delete";
            this.dgvAnnou_Delete.ReadOnly = true;
            this.dgvAnnou_Delete.Width = 25;
            // 
            // dgvAnnou_Title
            // 
            this.dgvAnnou_Title.Frozen = true;
            this.dgvAnnou_Title.HeaderText = "Title";
            this.dgvAnnou_Title.Name = "dgvAnnou_Title";
            this.dgvAnnou_Title.ReadOnly = true;
            this.dgvAnnou_Title.Width = 150;
            // 
            // dgvAnnou_Desc
            // 
            this.dgvAnnou_Desc.HeaderText = "Description";
            this.dgvAnnou_Desc.Name = "dgvAnnou_Desc";
            this.dgvAnnou_Desc.ReadOnly = true;
            this.dgvAnnou_Desc.Width = 300;
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
            this.dgvAnnou_PubDate.Width = 140;
            // 
            // dgvAnnou_Index
            // 
            this.dgvAnnou_Index.HeaderText = "";
            this.dgvAnnou_Index.Name = "dgvAnnou_Index";
            this.dgvAnnou_Index.ReadOnly = true;
            this.dgvAnnou_Index.Visible = false;
            this.dgvAnnou_Index.Width = 37;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnou)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblPageTitle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvAnnou;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.DateTimePicker dtpAnnouFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnnou_ID;
        private System.Windows.Forms.DataGridViewImageColumn dgvAnnou_Edit;
        private System.Windows.Forms.DataGridViewImageColumn dgvAnnou_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnnou_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnnou_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnnou_ExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnnou_PubDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnnou_Index;
    }
}