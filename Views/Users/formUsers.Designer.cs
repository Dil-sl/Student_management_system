namespace Student_management_system.Views.Users
{
    partial class formUsers
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
            this.btnMainManageUser = new System.Windows.Forms.Button();
            this.btnMainAddUser = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.lblPageTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.BackColor = System.Drawing.Color.White;
            this.lblPageTitle.Controls.Add(this.btnMainManageUser);
            this.lblPageTitle.Controls.Add(this.btnMainAddUser);
            this.lblPageTitle.Controls.Add(this.welcomeLabel);
            this.lblPageTitle.Location = new System.Drawing.Point(0, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(885, 696);
            this.lblPageTitle.TabIndex = 1;
            // 
            // btnMainManageUser
            // 
            this.btnMainManageUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.btnMainManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainManageUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainManageUser.ForeColor = System.Drawing.Color.White;
            this.btnMainManageUser.Image = global::Student_management_system.Properties.Resources.icons8_manage_50;
            this.btnMainManageUser.Location = new System.Drawing.Point(226, 90);
            this.btnMainManageUser.Name = "btnMainManageUser";
            this.btnMainManageUser.Padding = new System.Windows.Forms.Padding(2);
            this.btnMainManageUser.Size = new System.Drawing.Size(182, 90);
            this.btnMainManageUser.TabIndex = 5;
            this.btnMainManageUser.Text = "Manage Users";
            this.btnMainManageUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainManageUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMainManageUser.UseVisualStyleBackColor = false;
            this.btnMainManageUser.Click += new System.EventHandler(this.btnMainManageUser_Click);
            // 
            // btnMainAddUser
            // 
            this.btnMainAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.btnMainAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainAddUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainAddUser.ForeColor = System.Drawing.Color.White;
            this.btnMainAddUser.Image = global::Student_management_system.Properties.Resources.icons8_add_male_user_group_50;
            this.btnMainAddUser.Location = new System.Drawing.Point(38, 90);
            this.btnMainAddUser.Name = "btnMainAddUser";
            this.btnMainAddUser.Padding = new System.Windows.Forms.Padding(2);
            this.btnMainAddUser.Size = new System.Drawing.Size(182, 90);
            this.btnMainAddUser.TabIndex = 4;
            this.btnMainAddUser.Text = "Add Users";
            this.btnMainAddUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMainAddUser.UseVisualStyleBackColor = false;
            this.btnMainAddUser.Click += new System.EventHandler(this.btnMainAddUser_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 36);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(87, 37);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Users";
            // 
            // formUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 708);
            this.Controls.Add(this.lblPageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formUsers";
            this.lblPageTitle.ResumeLayout(false);
            this.lblPageTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblPageTitle;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button btnMainAddUser;
        private System.Windows.Forms.Button btnMainManageUser;
    }
}