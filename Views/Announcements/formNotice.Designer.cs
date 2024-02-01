namespace Student_management_system.Views.Announcements
{
    partial class formNotice
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.lblPageTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.BackColor = System.Drawing.Color.White;
            this.lblPageTitle.Controls.Add(this.button1);
            this.lblPageTitle.Controls.Add(this.button2);
            this.lblPageTitle.Controls.Add(this.welcomeLabel);
            this.lblPageTitle.Location = new System.Drawing.Point(0, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(885, 696);
            this.lblPageTitle.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Student_management_system.Properties.Resources.icons8_renew_50;
            this.button1.Location = new System.Drawing.Point(226, 90);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(182, 90);
            this.button1.TabIndex = 5;
            this.button1.Text = "Manage Notice";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Student_management_system.Properties.Resources.icons8_add_50;
            this.button2.Location = new System.Drawing.Point(38, 90);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(2);
            this.button2.Size = new System.Drawing.Size(182, 90);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Notice";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 36);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(186, 37);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Notice Board";
            // 
            // formNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 708);
            this.Controls.Add(this.lblPageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formNotice";
            this.Text = "formNotice";
            this.lblPageTitle.ResumeLayout(false);
            this.lblPageTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblPageTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label welcomeLabel;
    }
}