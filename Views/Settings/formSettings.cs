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

namespace Student_management_system.Views.Settings
{
    public partial class formSettings : Form
    {
        private static formSettings _instance;
        public formSettings()
        {
            InitializeComponent();
        }
        public static formSettings useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formSettings();
                return _instance;
            }
            set { _instance = value; }

        }
    }
   
}
