using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Student_management_system.Models;
using Student_management_system.Service;
using Student_management_system.Views;

namespace Student_management_system.Views
{
    public partial class formMain : Form
    {
        private static formMain _instance;
        public formMain()
        {
            InitializeComponent();
        }
        public static formMain useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formMain();
                return _instance;
            }
            set { _instance = value; }
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            
        }
        public void setPanel(Form obj)
        {
            pnlMainWindow.Controls.Clear();
            obj.TopLevel = false;
            obj.TopMost = true;
            obj.Dock = DockStyle.Fill;
            obj.Show();
            pnlMainWindow.Controls.Add(obj);
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rBtnDashboard_Click(object sender, EventArgs e)
        {
            if (rBtnDashboard.Checked)
            {
                formDashboard.useForm.Close();
                setPanel(formDashboard.useForm);
            }
        }

        /*

if (rBtnOverviewUser.Checked)
{
formRequests.useForm.Close();
setPanel(formOverview_User.useForm);
}
*/

    }
}
