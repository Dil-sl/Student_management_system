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
        private int classID;
        public formAddAttendance()
        {
            InitializeComponent();
            connection = DbConnection.GetConnection();//DB initialize
        }
        private class AttendanceButtonColumn : DataGridViewButtonColumn
        {
            public bool AttendanceStatus { get; set; } = false;
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

                            // Create ComboBoxItem and add to combo box
                            ClassModel item = new ClassModel { ClassID = classID, ClassName = className };
                            cmbClassName.Items.Add(item);
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
        private void LoadAttendanceData()
        {
            try
            {
                OpenConnection();

                if (cmbClassName.SelectedItem is ClassModel selectedClass)
                {
                    this.classID = selectedClass.ClassID;
                    bool attendanceExists = CheckAttendanceExists(selectedClass.ClassID, dtpAttDate.Value);
                    

                    if (!attendanceExists)
                    {
                        // Load student data for the selected class
                        students = GetStudentsForClass(selectedClass.ClassName);

                        // Bind students to the DataGridView (dgvUsers)
                        dgvUsers.DataSource = students;

                        // Clear existing columns
                        dgvUsers.Columns.Clear();

                        // Add a button column to mark attendance
                        AttendanceButtonColumn buttonColumn = new AttendanceButtonColumn();
                        buttonColumn.HeaderText = "Attendance";
                        buttonColumn.Name = "AttendanceColumn";
                        dgvUsers.Columns.Add(buttonColumn);

                        // Add other columns (StudentID, FullName)
                        DataGridViewTextBoxColumn studentIDColumn = new DataGridViewTextBoxColumn();
                        studentIDColumn.HeaderText = "Student ID";
                        studentIDColumn.Name = "StudentID";
                        dgvUsers.Columns.Add(studentIDColumn);

                        DataGridViewTextBoxColumn fullNameColumn = new DataGridViewTextBoxColumn();
                        fullNameColumn.HeaderText = "Full Name";
                        fullNameColumn.Name = "FullName";
                        dgvUsers.Columns.Add(fullNameColumn);

                        // Add your existing columns or customize as needed

                        // Set properties for DataGridView
                        dgvUsers.AutoGenerateColumns = false;
                        dgvUsers.AllowUserToAddRows = false;

                        // Fill data in the added columns
                        dgvUsers.Columns["StudentID"].DataPropertyName = "StudentID";
                        dgvUsers.Columns["FullName"].DataPropertyName = "FullName";

                    }
                    else
                    {
                        // If attendance records exist, load them and display in the DataGridView
                        List<AttendanceModel> attendance = GetAttendanceData(selectedClass.ClassID, dtpAttDate.Value);
                        
                        dgvUsers.DataSource = attendance;
                        dgvUsers.Columns.Clear();

                        // Add other columns (StudentID, FullName)
                        DataGridViewTextBoxColumn studentIDColumn = new DataGridViewTextBoxColumn();
                        studentIDColumn.HeaderText = "Student ID";
                        studentIDColumn.Name = "StudentID";
                        dgvUsers.Columns.Add(studentIDColumn);

                        DataGridViewTextBoxColumn ClassID = new DataGridViewTextBoxColumn();
                        ClassID.HeaderText = "Class ID";
                        ClassID.Name = "ClassID";
                        dgvUsers.Columns.Add(ClassID);

                        DataGridViewTextBoxColumn Date = new DataGridViewTextBoxColumn();
                        Date.HeaderText = "Date";
                        Date.Name = "Date";
                        dgvUsers.Columns.Add(Date);

                        DataGridViewTextBoxColumn Status = new DataGridViewTextBoxColumn();
                        Status.HeaderText = "Status";
                        Status.Name = "Status";
                        dgvUsers.Columns.Add(Status);
                  
                        // Set properties for DataGridView
                        dgvUsers.AutoGenerateColumns = false;
                        dgvUsers.AllowUserToAddRows = false;

                        // Fill data in the added columns
                        dgvUsers.Columns["StudentID"].DataPropertyName = "StudentID";
                        dgvUsers.Columns["ClassID"].DataPropertyName = "ClassID";
                        dgvUsers.Columns["Date"].DataPropertyName = "Date";
                        dgvUsers.Columns["Status"].DataPropertyName = "Status";
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

        private bool CheckAttendanceExists(int classID, DateTime date)
        {
            try
            {
                OpenConnection();

                string query = "SELECT COUNT(*) FROM Attendance WHERE ClassID = @ClassID AND Date = @Date";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassID", classID);
                    command.Parameters.AddWithValue("@Date", date);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        private List<AttendanceModel> GetAttendanceData(int classID, DateTime date)
        {
            List<AttendanceModel> attendanceData = new List<AttendanceModel>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM Attendance WHERE ClassID = @ClassID AND Date = @Date";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassID", classID);
                    command.Parameters.AddWithValue("@Date", date);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AttendanceModel attendanceModel = new AttendanceModel
                            {
                                AttendanceID = (int)reader["AttendanceID"],
                                ClassID = (int)reader["ClassID"],
                                Date = (DateTime)reader["Date"],
                                StudentID = (int)reader["StudentID"],
                                Status = reader["Status"].ToString()
                            };

                            attendanceData.Add(attendanceModel);
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

            return attendanceData;
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
                    int studentID = Convert.ToInt32(row.Cells["StudentID"].Value);
                    string attendanceStatus = row.Cells["AttendanceColumn"].Value as string;

                    // Check if the record already exists for the given date, class ID, and student ID
                    if (!AttendanceRecordExists(classID, dtpAttDate.Value, studentID))
                    {
                        AttendanceModel attendanceModel = new AttendanceModel
                        {
                            ClassID = classID,
                            Date = dtpAttDate.Value,
                            StudentID = studentID,
                            Status = attendanceStatus
                        };

                        attendanceData.Add(attendanceModel);
                    }
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

        // Other methods and event handlers...

        private List<StudentModel> GetStudentsForClass(string className)
        {
            List<StudentModel> students = new List<StudentModel>();

            try
            {
                OpenConnection();

                string query = "SELECT StudentID, FullName " +
                               "FROM Students " +
                               "WHERE Class = @ClassName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassName", className);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StudentModel student = new StudentModel
                            {
                                StudentID = (int)reader["StudentID"],
                                FullName = reader["FullName"].ToString()
                            };

                            students.Add(student);
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

            return students;
        }

        private void SaveAttendanceToDatabase(List<AttendanceModel> attendanceData)
        {
            try
            {
                OpenConnection();

                foreach (AttendanceModel attendanceModel in attendanceData)
                {
                    string query = "INSERT INTO Attendance (ClassID, Date, StudentID, Status) " +
                                   "VALUES (@ClassID, @Date, @StudentID, @Status)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassID", attendanceModel.ClassID);
                        command.Parameters.AddWithValue("@Date", attendanceModel.Date);
                        command.Parameters.AddWithValue("@StudentID", attendanceModel.StudentID);
                        command.Parameters.AddWithValue("@Status", attendanceModel.Status);

                        command.ExecuteNonQuery();
                    }
                }

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

        private void formAddAttendance_Load(object sender, EventArgs e)
        {
            LoadClassesIntoComboBox();
            dtpAttDate.Value = DateTime.Today;
            dtpAttDate.Enabled = false;
        }

        private void cmbClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendanceData();
        }

        private void btnAttSave_Click(object sender, EventArgs e)
        {
                SaveAttendanceData();  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            formMain.useForm.setPanel(formAttendance.useForm);
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvUsers.Columns["AttendanceColumn"].Index)
            {
                // Get the button cell and its current value
                DataGridViewButtonCell buttonCell = dgvUsers.Rows[e.RowIndex].Cells["AttendanceColumn"] as DataGridViewButtonCell;

                if (buttonCell != null)
                {
                    // Get the current value
                    string currentValue = buttonCell.Value as string;

                    // Toggle the value between "Present" and "Absent"
                    if (currentValue == "Present")
                    {
                        buttonCell.Value = "Absent";
                    }
                    else
                    {
                        buttonCell.Value = "Present";
                    }
                }
            }
        }
        private bool AttendanceRecordExists(int classID, DateTime date, int studentID)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Attendance WHERE ClassID = @ClassID AND Date = @Date AND StudentID = @StudentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassID", classID);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
