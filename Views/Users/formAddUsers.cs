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
    public partial class formAddUsers : Form
    {
        public formAddUsers()
        {
            InitializeComponent();
        }

        private void formAddUsers_Load(object sender, EventArgs e)
        {
            UIchange(false,false, false);
        }
        private void UIchange(bool isAdminUI,bool isStudentuI,bool isTeacherUI)
        {
            pnlAdminForm.Visible = isAdminUI;
            pnlStudentForm.Visible = isStudentuI; 
            pnlTeacherForm.Visible = isTeacherUI;
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserType.SelectedIndex == 0) 
            {
                UIchange(true, false, false);
            }
            else if (cmbUserType.SelectedIndex == 1)
            {
                UIchange(false, true, false);
            }
            else if (cmbUserType.SelectedIndex == 2)
            {
                UIchange(false, false, true);
            }
            else
            {
                UIchange(false, false, false);
            }
        }
    }
}
