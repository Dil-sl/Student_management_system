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
    public partial class formClasses : Form
    {
        private static formClasses _instance;
        public formClasses()
        {
            InitializeComponent();
        }
        public static formClasses useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formClasses();
                return _instance;
            }
            set { _instance = value; }
        }
    }
}
