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
        private Timer clockTimer;
        public formMain()
        {
            InitializeComponent();
            InitializeClockTimer();
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
                rbtnCheckedState(true,false,false,false,false);
                formDashboard.useForm.Close();
                setPanel(formDashboard.useForm);
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
            rbtnCheckedState(true, false, false, false, false);
            if (rBtnDashboard.Checked)
            {
                formDashboard.useForm.Close();
                setPanel(formDashboard.useForm);
            }
        }

        private void rBtnUsers_Click(object sender, EventArgs e)

        {
            rbtnCheckedState(false, true, false, false, false);
            if (rBtnUsers.Checked)
            {
                formUsers.useForm.Close();
                setPanel(formUsers.useForm);
            }
        }

        private void rBtnAttendance_Click(object sender, EventArgs e)
        {
            rbtnCheckedState(false, false, false, true, false);
            if (rBtnAttendance.Checked)
            {
                formAttendance.useForm.Close();
                setPanel(formAttendance.useForm);
            }
        }

        private void rBtnClass_Click(object sender, EventArgs e)
        {
            rbtnCheckedState(false, false, false, false, true);
            if (rBtnClass.Checked)
            {
                formClasses.useForm.Close();
                setPanel(formClasses.useForm);
            }
        }

        private void rBtnAnnounce_Click(object sender, EventArgs e)
        {
            rbtnCheckedState(false, false, true, false, false);
            if (rBtnAnnounce.Checked)
            {
                formAnnouncement.useForm.Close();
                setPanel(formAnnouncement.useForm);
            }
        }
        private void rbtnCheckedState(bool isDashboard,bool isUser,bool isAnnounce,bool isAttendance,bool isClass)
        {
            rBtnDashboard.Checked = isDashboard;
            rBtnUsers.Checked = isUser;
            rBtnAnnounce.Checked = isAnnounce;
            rBtnAttendance.Checked = isAttendance;
            rBtnClass.Checked = isClass;
        }
        //clock and clender
        private void InitializeClockTimer()
        {
            clockTimer = new Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += ClockTimer_Tick;

            clockTimer.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblTimeAndDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            clockTimer.Stop();
        }
    }
}
