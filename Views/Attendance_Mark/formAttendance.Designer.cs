namespace Student_management_system.Views.Attendance_Mark
{
    partial class formAttendance
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
            this.btnAddAttandance = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.lblPageTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.BackColor = System.Drawing.Color.White;
            this.lblPageTitle.Controls.Add(this.btnAddAttandance);
            this.lblPageTitle.Controls.Add(this.welcomeLabel);
            this.lblPageTitle.Location = new System.Drawing.Point(0, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(885, 696);
            this.lblPageTitle.TabIndex = 3;
            // 
            // btnAddAttandance
            // 
            this.btnAddAttandance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.btnAddAttandance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAttandance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAttandance.ForeColor = System.Drawing.Color.White;
            this.btnAddAttandance.Image = global::Student_management_system.Properties.Resources.icons8_add_50;
            this.btnAddAttandance.Location = new System.Drawing.Point(38, 90);
            this.btnAddAttandance.Name = "btnAddAttandance";
            this.btnAddAttandance.Padding = new System.Windows.Forms.Padding(2);
            this.btnAddAttandance.Size = new System.Drawing.Size(182, 90);
            this.btnAddAttandance.TabIndex = 4;
            this.btnAddAttandance.Text = "Add Attandance";
            this.btnAddAttandance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddAttandance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddAttandance.UseVisualStyleBackColor = false;
            this.btnAddAttandance.Click += new System.EventHandler(this.btnAddAttandance_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 36);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(164, 37);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Attandance";
            // 
            // formAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 708);
            this.Controls.Add(this.lblPageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAttendance";
            this.Text = "formAttendance";
            this.lblPageTitle.ResumeLayout(false);
            this.lblPageTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblPageTitle;
        private System.Windows.Forms.Button btnAddAttandance;
        private System.Windows.Forms.Label welcomeLabel;
    }
}