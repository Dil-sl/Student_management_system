namespace Student_management_system.Views.Classes
{
    partial class formClasses
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
            this.lblPageTitle = new System.Windows.Forms.Panel();
            this.btnMainManageClass = new System.Windows.Forms.Button();
            this.btnAddMainClass = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.lblPageTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.BackColor = System.Drawing.Color.White;
            this.lblPageTitle.Controls.Add(this.btnMainManageClass);
            this.lblPageTitle.Controls.Add(this.btnAddMainClass);
            this.lblPageTitle.Controls.Add(this.welcomeLabel);
            this.lblPageTitle.Location = new System.Drawing.Point(0, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(885, 696);
            this.lblPageTitle.TabIndex = 2;
            // 
            // btnMainManageClass
            // 
            this.btnMainManageClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.btnMainManageClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainManageClass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainManageClass.ForeColor = System.Drawing.Color.White;
            this.btnMainManageClass.Image = global::Student_management_system.Properties.Resources.icons8_renew_50;
            this.btnMainManageClass.Location = new System.Drawing.Point(226, 90);
            this.btnMainManageClass.Name = "btnMainManageClass";
            this.btnMainManageClass.Padding = new System.Windows.Forms.Padding(2);
            this.btnMainManageClass.Size = new System.Drawing.Size(182, 90);
            this.btnMainManageClass.TabIndex = 5;
            this.btnMainManageClass.Text = "Manage Class";
            this.btnMainManageClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainManageClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMainManageClass.UseVisualStyleBackColor = false;
            this.btnMainManageClass.Click += new System.EventHandler(this.btnMainManageClass_Click);
            // 
            // btnAddMainClass
            // 
            this.btnAddMainClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.btnAddMainClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMainClass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMainClass.ForeColor = System.Drawing.Color.White;
            this.btnAddMainClass.Image = global::Student_management_system.Properties.Resources.icons8_add_50;
            this.btnAddMainClass.Location = new System.Drawing.Point(38, 90);
            this.btnAddMainClass.Name = "btnAddMainClass";
            this.btnAddMainClass.Padding = new System.Windows.Forms.Padding(2);
            this.btnAddMainClass.Size = new System.Drawing.Size(182, 90);
            this.btnAddMainClass.TabIndex = 4;
            this.btnAddMainClass.Text = "Add Class";
            this.btnAddMainClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddMainClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddMainClass.UseVisualStyleBackColor = false;
            this.btnAddMainClass.Click += new System.EventHandler(this.btnAddMainClass_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 36);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(108, 37);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Classes";
            // 
            // formClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 708);
            this.Controls.Add(this.lblPageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formClasses";
            this.Text = "formClasses";
            this.lblPageTitle.ResumeLayout(false);
            this.lblPageTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblPageTitle;
        private System.Windows.Forms.Button btnMainManageClass;
        private System.Windows.Forms.Button btnAddMainClass;
        private System.Windows.Forms.Label welcomeLabel;
    }
}