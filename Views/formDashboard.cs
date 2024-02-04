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
    public partial class formDashboard : Form
    {
        private static formDashboard _instance;
        private readonly SqlConnection connection;
        public formDashboard()
        {
            InitializeComponent();
            connection = DbConnection.GetConnection();//DB initialize
        }
        public static formDashboard useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formDashboard();
                return _instance;
            }
            set { _instance = value; }
        }
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public DashboardData GetAdminDashboardData()
        {
            try
            {
                OpenConnection(); // Open the connection here

                // Execute SQL queries
                SqlCommand command = new SqlCommand(@"
                    SELECT
                        (SELECT COUNT(*) FROM Classes) AS TotalClasses,
                        (SELECT COUNT(*) FROM Teachers) AS TotalTeachers,
                        (SELECT COUNT(*) FROM Students) AS TotalStudents,
                        (SELECT COUNT(*) FROM Users WHERE UserType = 'Student') AS TotalStudentUsers,
                        (SELECT COUNT(*) FROM Users WHERE UserType = 'Teacher') AS TotalTeacherUsers,
                        (SELECT COUNT(*) FROM Attendance WHERE Date = CONVERT(DATE, GETDATE())) AS TodayAttendance,
                        (SELECT COUNT(*) FROM Noticeboard) AS TotalAnnouncements,
                        (SELECT COUNT(DISTINCT ClassID) FROM Attendance WHERE Date = CONVERT(DATE, GETDATE())) AS ClassesWithAttendance,
                        (SELECT COUNT(DISTINCT ClassID) FROM Attendance WHERE Date = CONVERT(DATE, GETDATE()) AND Status = 'Completed') AS ClassesWithCompleteAttendance;
                ", connection);

                SqlDataReader reader = command.ExecuteReader();

                // Parse the results into a model
                DashboardData adminDashboardData = new DashboardData();

                if (reader.Read())
                {
                    adminDashboardData.TotalClasses = Convert.ToInt32(reader["TotalClasses"]);
                    adminDashboardData.TotalTeachers = Convert.ToInt32(reader["TotalTeachers"]);
                    adminDashboardData.TotalStudents = Convert.ToInt32(reader["TotalStudents"]);
                    adminDashboardData.TotalStudentUsers = Convert.ToInt32(reader["TotalStudentUsers"]);
                    adminDashboardData.TotalTeacherUsers = Convert.ToInt32(reader["TotalTeacherUsers"]);
                    adminDashboardData.TodayAttendance = Convert.ToInt32(reader["TodayAttendance"]);
                    adminDashboardData.TotalAnnouncements = Convert.ToInt32(reader["TotalAnnouncements"]);
                    adminDashboardData.ClassesWithAttendance = Convert.ToInt32(reader["ClassesWithAttendance"]);
                    adminDashboardData.ClassesWithCompleteAttendance = Convert.ToInt32(reader["ClassesWithCompleteAttendance"]);
                }

                return adminDashboardData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                CloseConnection(); // Close the connection here
            }
        }



        private void formDashboard_Load(object sender, EventArgs e)
        {
            DashboardData adminDashboardData = GetAdminDashboardData();

            if (adminDashboardData != null)
            {
                updateUI(adminDashboardData);
            }
        }
        private void updateUI(DashboardData adminDashboardData)
        {
            lblClassCount.Text = adminDashboardData.TotalClasses.ToString();
            lblStudentsCount.Text = adminDashboardData.TotalStudents.ToString();
            lblTeachersCount.Text = adminDashboardData.TotalTeachers.ToString();
            lblAllAttandance.Text = adminDashboardData.TodayAttendance.ToString();
            lblAnnounceCount.Text = adminDashboardData.TotalAnnouncements.ToString();
            lblMarkingComplete.Text = adminDashboardData.ClassesWithAttendance.ToString()+ " / " + adminDashboardData.TotalClasses.ToString();    
        }
    }
}

