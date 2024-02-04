using Student_management_system.Views.Classes;
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

namespace Student_management_system.Views.Announcements
{
    public partial class formAnnouncement : Form
    {
        private static formAnnouncement _instance;
        private formMain _formMainIns = formMain.useForm;

        public formAnnouncement()
        {
            InitializeComponent();
        }
        public static formAnnouncement useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formAnnouncement();
                return _instance;
            }
            set { _instance = value; }
        }

        private void btnAddAnnouMain_Click(object sender, EventArgs e)
        {
            formAddAnnoncement.useForm.Dispose();
            _formMainIns.setPanel(formAddAnnoncement.useForm);
            this.Dispose();
        }

        private void btnManageAnnouMain_Click(object sender, EventArgs e)
        {
            formManageAnnouncement.useForm.Dispose();
            _formMainIns.setPanel(formManageAnnouncement.useForm);
            this.Dispose();
        }


       

    }
}
