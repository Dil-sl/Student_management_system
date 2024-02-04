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
        private formMain _formMainIns = formMain.useForm;
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

        private void btnMainAddUser_Click(object sender, EventArgs e)
        {
            formAddUsers.useForm.Dispose();
            _formMainIns.setPanel(formAddUsers.useForm);
            this.Dispose();
        }

        private void btnMainManageUser_Click(object sender, EventArgs e)
        {
            formManageUsers.useForm.Dispose();
            _formMainIns.setPanel(formManageUsers.useForm);
            this.Dispose();
        }
    }
}
