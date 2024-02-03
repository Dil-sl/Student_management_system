﻿using Student_management_system.Views.Users;
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
    }
}
