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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formManageClass));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlManageClass = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchClass = new Guna.UI2.WinForms.Guna2Button();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.txtSearchClass = new Guna.UI2.WinForms.Guna2TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.dgvClass_ClassCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClass_Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvClass_Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvClass_ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClass_ClassTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClass_ClassTeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClass_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlManageClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlManageClass
            // 
            this.pnlManageClass.BackColor = System.Drawing.Color.White;
            this.pnlManageClass.Controls.Add(this.label1);
            this.pnlManageClass.Controls.Add(this.btnSearchClass);
            this.pnlManageClass.Controls.Add(this.dgvClass);
            this.pnlManageClass.Controls.Add(this.txtSearchClass);
            this.pnlManageClass.Controls.Add(this.welcomeLabel);
            this.pnlManageClass.Location = new System.Drawing.Point(0, 12);
            this.pnlManageClass.Name = "pnlManageClass";
            this.pnlManageClass.Size = new System.Drawing.Size(885, 696);
            this.pnlManageClass.TabIndex = 4;
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
            // btnSearchClass
            // 
            this.btnSearchClass.BorderRadius = 15;
            this.btnSearchClass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchClass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchClass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSearchClass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClass.ForeColor = System.Drawing.Color.White;
            this.btnSearchClass.Location = new System.Drawing.Point(478, 96);
            this.btnSearchClass.Name = "btnSearchClass";
            this.btnSearchClass.Size = new System.Drawing.Size(91, 32);
            this.btnSearchClass.TabIndex = 175;
            this.btnSearchClass.Text = "Search";
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvClass.BackgroundColor = System.Drawing.Color.White;
            this.dgvClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClass.ColumnHeadersHeight = 25;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvClass_ClassCode,
            this.dgvClass_Edit,
            this.dgvClass_Delete,
            this.dgvClass_ClassName,
            this.dgvClass_ClassTeacherName,
            this.dgvClass_ClassTeacherID,
            this.dgvClass_Index});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClass.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClass.EnableHeadersVisualStyles = false;
            this.dgvClass.Location = new System.Drawing.Point(19, 151);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClass.RowHeadersVisible = false;
            this.dgvClass.RowHeadersWidth = 45;
            this.dgvClass.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClass.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClass.RowTemplate.Height = 25;
            this.dgvClass.RowTemplate.ReadOnly = true;
            this.dgvClass.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.ShowCellToolTips = false;
            this.dgvClass.Size = new System.Drawing.Size(601, 515);
            this.dgvClass.TabIndex = 174;
            // 
            // txtSearchClass
            // 
            this.txtSearchClass.BorderRadius = 5;
            this.txtSearchClass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchClass.DefaultText = "";
            this.txtSearchClass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchClass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchClass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchClass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchClass.Location = new System.Drawing.Point(129, 96);
            this.txtSearchClass.Name = "txtSearchClass";
            this.txtSearchClass.PasswordChar = '\0';
            this.txtSearchClass.PlaceholderText = "";
            this.txtSearchClass.SelectedText = "";
            this.txtSearchClass.Size = new System.Drawing.Size(324, 32);
            this.txtSearchClass.TabIndex = 172;
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
            // dgvClass_ClassCode
            // 
            this.dgvClass_ClassCode.Frozen = true;
            this.dgvClass_ClassCode.HeaderText = "Class #";
            this.dgvClass_ClassCode.Name = "dgvClass_ClassCode";
            this.dgvClass_ClassCode.ReadOnly = true;
            this.dgvClass_ClassCode.Width = 111;
            // 
            // dgvClass_Edit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.dgvClass_Edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClass_Edit.Frozen = true;
            this.dgvClass_Edit.HeaderText = "";
            this.dgvClass_Edit.Name = "dgvClass_Edit";
            this.dgvClass_Edit.ReadOnly = true;
            this.dgvClass_Edit.Width = 25;
            // 
            // dgvClass_Delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.dgvClass_Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClass_Delete.Frozen = true;
            this.dgvClass_Delete.HeaderText = "";
            this.dgvClass_Delete.Name = "dgvClass_Delete";
            this.dgvClass_Delete.ReadOnly = true;
            this.dgvClass_Delete.Width = 25;
            // 
            // dgvClass_ClassName
            // 
            this.dgvClass_ClassName.Frozen = true;
            this.dgvClass_ClassName.HeaderText = "Class Name";
            this.dgvClass_ClassName.Name = "dgvClass_ClassName";
            this.dgvClass_ClassName.ReadOnly = true;
            // 
            // dgvClass_ClassTeacherName
            // 
            this.dgvClass_ClassTeacherName.HeaderText = "Class Teacher Name";
            this.dgvClass_ClassTeacherName.Name = "dgvClass_ClassTeacherName";
            this.dgvClass_ClassTeacherName.ReadOnly = true;
            this.dgvClass_ClassTeacherName.Width = 200;
            // 
            // dgvClass_ClassTeacherID
            // 
            this.dgvClass_ClassTeacherID.HeaderText = "Class Teacher ID";
            this.dgvClass_ClassTeacherID.Name = "dgvClass_ClassTeacherID";
            this.dgvClass_ClassTeacherID.ReadOnly = true;
            this.dgvClass_ClassTeacherID.Width = 140;
            // 
            // dgvClass_Index
            // 
            this.dgvClass_Index.HeaderText = "";
            this.dgvClass_Index.Name = "dgvClass_Index";
            this.dgvClass_Index.ReadOnly = true;
            this.dgvClass_Index.Visible = false;
            this.dgvClass_Index.Width = 37;
            // 
            // formManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 708);
            this.Controls.Add(this.pnlManageClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formManageClass";
            this.Text = "formManageClass";
            this.pnlManageClass.ResumeLayout(false);
            this.pnlManageClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManageClass;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSearchClass;
        public System.Windows.Forms.DataGridView dgvClass;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchClass;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClass_ClassCode;
        private System.Windows.Forms.DataGridViewImageColumn dgvClass_Edit;
        private System.Windows.Forms.DataGridViewImageColumn dgvClass_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClass_ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClass_ClassTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClass_ClassTeacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClass_Index;
    }
}