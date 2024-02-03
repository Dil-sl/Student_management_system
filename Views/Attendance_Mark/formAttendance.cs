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
    }
}
