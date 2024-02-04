using Student_management_system.Views.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_management_system.Models;
using Student_management_system.Service;
using Student_management_system.Views;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Student_management_system.Views.Attendance_Mark
{
    public partial class formAddAttendance : Form
    {
        private static formAddAttendance _instance;
        private readonly SqlConnection connection;
        private List<StudentModel> students;
        public formAddAttendance()
        {
            InitializeComponent();
            connection = DbConnection.GetConnection();//DB initialize
        }
        public static formAddAttendance useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formAddAttendance();
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
        private void LoadClassesIntoComboBox()
        {
            try
            {
                OpenConnection();

                string query = "SELECT ClassID, ClassName FROM Classes";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        cmbClassName.DisplayMember = "ClassName";
                        cmbClassName.ValueMember = "ClassID";

                        while (reader.Read())
                        {
                            int classID = reader.GetInt32(reader.GetOrdinal("ClassID"));
                            string className = reader.GetString(reader.GetOrdinal("ClassName"));

                            cmbClassName.Items.Add(new { ClassID = classID, ClassName = className });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void formAddAttendance_Load(object sender, EventArgs e)
        {
            LoadClassesIntoComboBox();
            dtpAttDate.Value = DateTime.Today;
            dtpAttDate.Enabled = false;
        }
        private void LoadAttendanceData()
        {
            try
            {
                OpenConnection();

                // Assuming you have a method to check if attendance records exist for the selected date and class
                bool attendanceExists = CheckAttendanceExists((int)cmbClassName.SelectedValue, dtpAttDate.Value);

                if (!attendanceExists)
                {
                    // If no attendance records exist, load student data for the selected class
                    students = GetStudentsForClass((int)cmbClassName.SelectedValue);

                    // Bind students to the DataGridView (dgvAttendance)
                    dgvUsers.DataSource = students;

                    // Add a checkbox column to mark attendance
                    DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                    checkboxColumn.HeaderText = "Attendance";
                    checkboxColumn.Name = "AttendanceColumn";
                    dgvUsers.Columns.Insert(0, checkboxColumn);
                }
                else
                {
                    // If attendance records exist, load them and display in the DataGridView
                    List<AttendanceModel> attendance = GetAttendanceData((int)cmbClassName.SelectedValue, dtpAttDate.Value);

                    dgvUsers.DataSource = attendance;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }
        private bool CheckAttendanceExists(int classID, DateTime date)
        {
            // Implement logic to check if attendance records exist for the selected date and class
            throw new NotImplementedException();
        }

        private List<StudentModel> GetStudentsForClass(int classID)
        {
            // Implement logic to get student data for the selected class
            throw new NotImplementedException();
        }

        private List<AttendanceModel> GetAttendanceData(int classID, DateTime date)
        {
            // Implement logic to get attendance data for the selected date and class
            throw new NotImplementedException();
        }

        private void SaveAttendanceToDatabase(List<AttendanceModel> attendanceData)
        {
            // Implement logic to save attendance data to the database
            throw new NotImplementedException();
        }

        private void cmbClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendanceData();
        }

        private void btnAttSave_Click(object sender, EventArgs e)
        {
            SaveAttendanceData();
        }
        private void SaveAttendanceData()
        {
            try
            {
                OpenConnection();

                // Assuming you have a method to save attendance data
                List<AttendanceModel> attendanceData = new List<AttendanceModel>();

                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    int studentID = (int)row.Cells["StudentID"].Value;
                    bool attendanceStatus = (bool)row.Cells["AttendanceColumn"].Value;

                    // Determine the status based on checkbox
                    string status = attendanceStatus ? "Present" : "Absent";

                    // Create an AttendanceModel object
                    AttendanceModel attendanceModel = new AttendanceModel
                    {
                        ClassID = (int)cmbClassName.SelectedValue,
                        Date = dtpAttDate.Value,
                        StudentID = studentID,
                        Status = status
                    };

                    attendanceData.Add(attendanceModel);
                }

                // Save attendance data to the database
                SaveAttendanceToDatabase(attendanceData);

                MessageBox.Show("Attendance saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
