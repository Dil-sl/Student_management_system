namespace Student_management_system.Views.Announcements
{
    partial class formAnnouncement
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
            this.btnManageAnnouMain = new System.Windows.Forms.Button();
            this.btnAddAnnouMain = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.lblPageTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.BackColor = System.Drawing.Color.White;
            this.lblPageTitle.Controls.Add(this.btnManageAnnouMain);
            this.lblPageTitle.Controls.Add(this.btnAddAnnouMain);
            this.lblPageTitle.Controls.Add(this.welcomeLabel);
            this.lblPageTitle.Location = new System.Drawing.Point(0, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(885, 696);
            this.lblPageTitle.TabIndex = 4;
            // 
            // btnManageAnnouMain
            // 
            this.btnManageAnnouMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.btnManageAnnouMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAnnouMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAnnouMain.ForeColor = System.Drawing.Color.White;
            this.btnManageAnnouMain.Image = global::Student_management_system.Properties.Resources.icons8_renew_50;
            this.btnManageAnnouMain.Location = new System.Drawing.Point(226, 90);
            this.btnManageAnnouMain.Name = "btnManageAnnouMain";
            this.btnManageAnnouMain.Padding = new System.Windows.Forms.Padding(2);
            this.btnManageAnnouMain.Size = new System.Drawing.Size(182, 90);
            this.btnManageAnnouMain.TabIndex = 5;
            this.btnManageAnnouMain.Text = "Announcements";
            this.btnManageAnnouMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageAnnouMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnManageAnnouMain.UseVisualStyleBackColor = false;
            this.btnManageAnnouMain.Click += new System.EventHandler(this.btnManageAnnouMain_Click);
            // 
            // btnAddAnnouMain
            // 
            this.btnAddAnnouMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.btnAddAnnouMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnnouMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnnouMain.ForeColor = System.Drawing.Color.White;
            this.btnAddAnnouMain.Image = global::Student_management_system.Properties.Resources.icons8_add_50;
            this.btnAddAnnouMain.Location = new System.Drawing.Point(38, 90);
            this.btnAddAnnouMain.Name = "btnAddAnnouMain";
            this.btnAddAnnouMain.Padding = new System.Windows.Forms.Padding(2);
            this.btnAddAnnouMain.Size = new System.Drawing.Size(182, 90);
            this.btnAddAnnouMain.TabIndex = 4;
            this.btnAddAnnouMain.Text = "Add Announcements";
            this.btnAddAnnouMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddAnnouMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddAnnouMain.UseVisualStyleBackColor = false;
            this.btnAddAnnouMain.Click += new System.EventHandler(this.btnAddAnnouMain_Click);
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
            this.welcomeLabel.Text = "Announcements";
            // 
            // formAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 708);
            this.Controls.Add(this.lblPageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAnnouncement";
            this.Text = "formAnnouncement";
            this.lblPageTitle.ResumeLayout(false);
            this.lblPageTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblPageTitle;
        private System.Windows.Forms.Button btnManageAnnouMain;
        private System.Windows.Forms.Button btnAddAnnouMain;
        private System.Windows.Forms.Label welcomeLabel;
    }
}