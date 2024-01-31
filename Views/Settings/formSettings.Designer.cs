namespace Student_management_system.Views.Settings
{
    partial class formSettings
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
            this.pnlDashboardMain = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pnlDashboardMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDashboardMain
            // 
            this.pnlDashboardMain.BackColor = System.Drawing.Color.White;
            this.pnlDashboardMain.Controls.Add(this.welcomeLabel);
            this.pnlDashboardMain.Location = new System.Drawing.Point(0, 12);
            this.pnlDashboardMain.Name = "pnlDashboardMain";
            this.pnlDashboardMain.Size = new System.Drawing.Size(885, 696);
            this.pnlDashboardMain.TabIndex = 3;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 36);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(157, 37);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Dashboard";
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 708);
            this.Controls.Add(this.pnlDashboardMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSettings";
            this.Text = "formSettings";
            this.pnlDashboardMain.ResumeLayout(false);
            this.pnlDashboardMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboardMain;
        private System.Windows.Forms.Label welcomeLabel;
    }
}