using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Student_management_system.Models;
using Student_management_system.Service;
using Student_management_system.Views;
using Student_management_system.Views.Users;
using Student_management_system.Views.Attendance_Mark;
using Student_management_system.Views.Classes;
using Student_management_system.Views.Announcements;
using Student_management_system.Views.Settings;

namespace Student_management_system.Views
{
    public partial class formMain : Form
    {
        private static formMain _instance;
        public formMain()
        {
            InitializeComponent();
        }
        public static formMain useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formMain();
                return _instance;
            }
            set { _instance = value; }
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Constants.CurrentUser.Username;
            rBtnDashboard.Checked = true;
            rBtnUsers.Checked = false;
            rBtnAnnounce.Checked = false;
            rBtnAttendance.Checked = false;
            rBtnClass.Checked = false;
            rBtnSettings.Checked = false;
            if (rBtnDashboard.Checked)
            {
                formDashboard.useForm.Close();
                setPanel(formDashboard.useForm);
            }
        }
        public void setPanel(Form obj)
        {
            pnlMainWindow.Controls.Clear();
            obj.TopLevel = false;
            obj.TopMost = true;
            obj.Dock = DockStyle.Fill;
            obj.Show();
            pnlMainWindow.Controls.Add(obj);
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rBtnDashboard_Click(object sender, EventArgs e)
        {
            rBtnDashboard.Checked = true;
            rBtnUsers.Checked = false;
            rBtnAnnounce.Checked = false;
            rBtnAttendance.Checked = false;
            rBtnClass.Checked = false;
            rBtnSettings.Checked = false;
            if (rBtnDashboard.Checked)
            {
                formDashboard.useForm.Close();
                setPanel(formDashboard.useForm);
            }
        }

        private void rBtnUsers_Click(object sender, EventArgs e)

        {
            rBtnDashboard.Checked = false;
            rBtnUsers.Checked = true;
            rBtnAnnounce.Checked = false;
            rBtnAttendance.Checked = false;
            rBtnClass.Checked = false;
            rBtnSettings.Checked = false;
            if (rBtnUsers.Checked)
            {
                formUsers.useForm.Close();
                setPanel(formUsers.useForm);
            }
        }

        private void rBtnAttendance_Click(object sender, EventArgs e)
        {
            rBtnDashboard.Checked = false;
            rBtnUsers.Checked = false;
            rBtnAnnounce.Checked = false;
            rBtnAttendance.Checked = true;
            rBtnClass.Checked = false;
            rBtnSettings.Checked = false;
            if (rBtnAttendance.Checked)
            {
                formAttendance.useForm.Close();
                setPanel(formAttendance.useForm);
            }
        }

        private void rBtnClass_Click(object sender, EventArgs e)
        {
            rBtnDashboard.Checked = false;
            rBtnUsers.Checked = false;
            rBtnAnnounce.Checked = false;
            rBtnAttendance.Checked = false;
            rBtnClass.Checked = true;
            rBtnSettings.Checked = false;
            if (rBtnClass.Checked)
            {
                formClasses.useForm.Close();
                setPanel(formClasses.useForm);
            }
        }

        private void rBtnAnnounce_Click(object sender, EventArgs e)
        {
            rBtnDashboard.Checked = false;
            rBtnUsers.Checked = false;
            rBtnAnnounce.Checked = true;
            rBtnAttendance.Checked = false;
            rBtnClass.Checked = false;
            if (rBtnAnnounce.Checked)
            {
                formAnnouncement.useForm.Close();
                setPanel(formAnnouncement.useForm);
            }
        }
 

    }
}
