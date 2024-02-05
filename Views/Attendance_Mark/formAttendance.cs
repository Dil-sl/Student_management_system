using Student_management_system.Views.Announcements;
using Student_management_system.Views.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management_system.Views.Attendance_Mark
{
    public partial class formAttendance : Form
    {
        private static formAttendance _instance;
        private formMain _formMainIns = formMain.useForm;
        public formAttendance()
        {
            InitializeComponent();
        }
        public static formAttendance useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formAttendance();
                return _instance;
            }
            set { _instance = value; }
        }

        private void btnAddAttandance_Click(object sender, EventArgs e)
        {
            formAddAttendance.useForm.Dispose();
            _formMainIns.setPanel(formAddAttendance.useForm);
            this.Dispose();
        }

        private void btnManageAttandance_Click(object sender, EventArgs e)
        {
            formManageAttendance.useForm.Dispose();
            _formMainIns.setPanel(formManageAttendance.useForm);
            this.Dispose();
        }
    }
}
