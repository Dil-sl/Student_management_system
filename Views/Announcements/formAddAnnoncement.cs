using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management_system.Views.Announcements
{
    
    public partial class formAddAnnoncement : Form
    {
        private static formAddAnnoncement _instance;
        public formAddAnnoncement()
        {
            InitializeComponent();
        }
        public static formAddAnnoncement useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formAddAnnoncement();
                return _instance;
            }
            set { _instance = value; }
        }
    }
}
