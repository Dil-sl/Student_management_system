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

namespace Student_management_system.Views.Classes
{
    public partial class formManageClass : Form
    {
        private static formManageClass _instance;
        public formManageClass()
        {
            InitializeComponent();
        }
        public static formManageClass useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formManageClass();
                return _instance;
            }
            set { _instance = value; }
        }
    }
}
