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
    public partial class formManageAttendance : Form
    {
        private static formManageAttendance _instance;
        public formManageAttendance()
        {
            InitializeComponent();
        }
        public static formManageAttendance useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formManageAttendance();
                return _instance;
            }
            set { _instance = value; }
        }
    }
}
