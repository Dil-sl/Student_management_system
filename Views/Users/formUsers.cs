using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management_system.Views.Users
{
   
    public partial class formUsers : Form
    {
        private static formUsers _instance;
        public formUsers()
        {
            InitializeComponent();
        }
        public static formUsers useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formUsers();
                return _instance;
            }
            set { _instance = value; }
        }
    }
}
