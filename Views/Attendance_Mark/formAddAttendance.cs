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
    public partial class formAddAttendance : Form
    {
        private static formAddAttendance _instance;
        public formAddAttendance()
        {
            InitializeComponent();
        }
        public static formAddAttendance useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formAddAttendance();
                return _instance;
            }
            set { _instance = value; }
        }
    }
}
