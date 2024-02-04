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
using System.Dynamic;

namespace Student_management_system.Views.Users
{
    public partial class formManageUsers : Form
    {
        private static formManageUsers _instance;
        private readonly SqlConnection connection;
        public string userMode;
        public string userEnvioronment;
        public formManageUsers()
        {
            InitializeComponent();
            connection = DbConnection.GetConnection();//DB initialize
        }
        public static formManageUsers useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formManageUsers();
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

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text!="")
            { 
                if(cmbUserType.SelectedIndex==0)//admin
                {
                    PopulateUsersDataGridView(txtUserName.Text.ToString());
                }
                else if(cmbUserType.SelectedIndex == 1)//student
                {
                    PopulateStudentsDataGridView(txtUserName.Text.ToString());
                }
                else if (cmbUserType.SelectedIndex == 2)//teacher
                {
                    PopulateTeachersDataGridView(txtUserName.Text.ToString());
                }
                else
                {

                }
            }
        }
        //Get DATA 
        public List<TeacherModel> GetTeachers(string searchCriteria)
        {
            List<TeacherModel> teachers = new List<TeacherModel>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM Teachers WHERE " +
                               "FullName LIKE @SearchCriteria OR " +
                               "ContactNumber LIKE @SearchCriteria OR " +
                               "OwnedClass LIKE @SearchCriteria";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchCriteria", "%" + searchCriteria + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TeacherModel teacher = new TeacherModel
                            {
                                TeacherID = (int)reader["TeacherID"],
                                FullName = reader["FullName"].ToString(),
                                DOB = (DateTime)reader["DOB"],
                                ContactNumber = reader["ContactNumber"].ToString(),
                                Address = reader["Address"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Email = reader["Email"].ToString(),
                                Subjects = reader["Subjects"].ToString(),
                                Username= "N/A",
                                OwnedClass = reader["OwnedClass"].ToString()
                            };

                            teachers.Add(teacher);
                        }
                    }
                }

                return teachers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
            finally
            {
                CloseConnection();
            }
        
        }
        //populate DGV 
        public void PopulateTeachersDataGridView(string searchCriteria)
        {
            try
            {
                // Get the list of teachers
                List<TeacherModel> teachers = GetTeachers(searchCriteria);

                // Clear existing rows in the DataGridView
                dgvUsers.Rows.Clear();
                resetDgvOriginalMode(true, false, true,false);
                

                if (teachers != null && teachers.Count > 0)
                {
                    foreach (TeacherModel teacher in teachers)
                    {
                      
                        // Add a new row to the DataGridView
                        int rowIndex = dgvUsers.Rows.Add();

                        // Set cell values for each visible column
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_UserCode"].Value = teacher.TeacherID;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_FullName"].Value = teacher.FullName;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_DOB"].Value = teacher.DOB;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Contact"].Value = teacher.ContactNumber;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Address"].Value = teacher.Address;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Gender"].Value = teacher.Gender;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Email"].Value = teacher.Email;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Subjects"].Value = teacher.Subjects;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_UserName"].Value = teacher.Username;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Class"].Value = teacher.OwnedClass;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_UserType"].Value ="Teacher";
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Edit"].Value = Properties.Resources.Edit;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Delete"].Value = Properties.Resources.Delette;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Index"].Value = rowIndex;

                        // Add other custom column assignments if needed
                    }

                    dgvUsers.Refresh();
                }
                else
                {
                    MessageBox.Show("No records found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //get students data
        public List<StudentModel> GetStudents(string searchCriteria)
        {
            List<StudentModel> students = new List<StudentModel>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM Students WHERE " +
                               "FullName LIKE @SearchCriteria OR " +
                               "RegNo LIKE @SearchCriteria OR " +
                               "Class LIKE @SearchCriteria";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchCriteria", "%" + searchCriteria + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StudentModel student = new StudentModel
                            {
                                StudentID = (int)reader["StudentID"],
                                FullName = reader["FullName"].ToString(),
                                DOB = (DateTime)reader["DOB"],
                                Contact = reader["Contact"].ToString(),
                                Address = reader["Address"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Email = reader["Email"].ToString(),
                                RegNo = reader["RegNo"].ToString(),
                                GuardianName= reader["GuardianName"].ToString(),
                                GuardianContactNumber = reader["GuardianContactNumber"].ToString(),
                                Class = reader["Class"].ToString()
                            };

                            students.Add(student);
                        }
                    }
                }

                return students;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
        //populate DGV
        public void PopulateStudentsDataGridView(string searchCriteria)
        {
            try
            {
                // Get the list of students
                List<StudentModel> students = GetStudents(searchCriteria);

                // Clear existing rows in the DataGridView
                dgvUsers.Rows.Clear();
                resetDgvOriginalMode(false, true, false, true);
                dgvUsers.Columns["dgvUser_Class"].Visible = true;
                //dgvUsers.Columns["dgvUsers_Reg"].Visible = false;//
                //dgvUsers.Columns["dgvUsers_Gname"].Visible = false;//
                //dgvUsers.Columns["dgvUsers_Gcontact"].Visible = false;//


                if (students != null && students.Count > 0)
                {
                    foreach (StudentModel student in students)
                    {
                        // Add a new row to the DataGridView
                        int rowIndex = dgvUsers.Rows.Add();

                        // Set cell values for each visible column
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_UserCode"].Value = student.StudentID;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_FullName"].Value = student.FullName;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_DOB"].Value = student.DOB;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Contact"].Value = student.Contact;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Address"].Value = student.Address;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Gender"].Value = student.Gender;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Email"].Value = student.Email;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Class"].Value = student.Class;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_UserType"].Value = "Student";
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Reg"].Value = student.RegNo;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Gname"].Value = student.GuardianName;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Gcontact"].Value = student.GuardianContactNumber;

                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Edit"].Value = Properties.Resources.Edit;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Delete"].Value = Properties.Resources.Delette;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Index"].Value = rowIndex;

                        // Add other custom column assignments if needed
                    }

                    dgvUsers.Refresh();
                }
                else
                {
                    MessageBox.Show("No records found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<UserModel> GetUsers(string searchCriteria)
        {
            List<UserModel> users = new List<UserModel>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM Users WHERE " +
                               "FullName LIKE @SearchCriteria OR " +
                               "Username LIKE @SearchCriteria OR " +
                               "UserType LIKE @SearchCriteria";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchCriteria", "%" + searchCriteria + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserModel user = new UserModel
                            {
                                UserID = (int)reader["UserID"],
                                FullName = reader["FullName"].ToString(),
                                Username = reader["Username"].ToString(),
                                UserType = reader["UserType"].ToString(),
                                ContactNumber= reader["ContactNumber"].ToString(),
                                Email= reader["Email"].ToString()
                            };

                            users.Add(user);
                        }
                    }
                }

                return users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void PopulateUsersDataGridView(string searchCriteria)
        {
            try
            {
                // Get the list of users
                List<UserModel> users = GetUsers(searchCriteria);

                // Clear existing rows in the DataGridView
                dgvUsers.Rows.Clear();
                resetDgvOriginalMode(false, true, true,false);

                if (users != null && users.Count > 0)
                {
                    foreach (UserModel user in users)
                    {
                        // Add a new row to the DataGridView
                        int rowIndex = dgvUsers.Rows.Add();

                        // Set cell values for each visible column
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_UserCode"].Value = user.UserID;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_FullName"].Value = user.FullName;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_UserName"].Value = user.Username;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_UserType"].Value = user.UserType;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Email"].Value = user.Email;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Contact"].Value = user.ContactNumber;

                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Edit"].Value = Properties.Resources.Edit;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Delete"].Value = Properties.Resources.Delette;
                        dgvUsers.Rows[rowIndex].Cells["dgvUser_Index"].Value = rowIndex; 

                        // Add other custom column assignments if needed
                    }

                    dgvUsers.Refresh();
                }
                else
                {
                    MessageBox.Show("No records found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void resetDgvOriginalMode(bool isUser,bool isTeacher,bool isStudent,bool both)
        {

            dgvUsers.Columns["dgvUser_Subjects"].Visible = isStudent;

            dgvUsers.Columns["dgvUser_Reg"].Visible = isTeacher;
            dgvUsers.Columns["dgvUser_Gname"].Visible = isTeacher;
            dgvUsers.Columns["dgvUser_Gcontact"].Visible = isTeacher;

            dgvUsers.Columns["dgvUser_Subjects"].Visible = isUser;
            dgvUsers.Columns["dgvUser_Reg"].Visible = both;
            dgvUsers.Columns["dgvUser_Gname"].Visible = both;
            dgvUsers.Columns["dgvUser_Gcontact"].Visible = both;
            dgvUsers.Columns["dgvUser_DOB"].Visible = isUser;
            dgvUsers.Columns["dgvUser_Class"].Visible = isUser;
            dgvUsers.Columns["dgvUser_Address"].Visible = isUser;
            dgvUsers.Columns["dgvUser_Gender"].Visible = isUser;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            formMain.useForm.setPanel(formUsers.useForm);
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUser_Edit.Index && e.RowIndex != -1)
            {
                int userID = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["dgvUser_UserCode"].Value);
                formAddUsers.useForm.Close();
                formAddUsers.useForm.setToEdit(cmbUserType.SelectedItem.ToString(),"Edit", userID,cmbUserType.SelectedIndex);
                formMain.useForm.setPanel(formAddUsers.useForm);

            }
            else if (e.ColumnIndex == dgvUser_Delete.Index && e.RowIndex != -1)
            {
                //delete Product
                int userID = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["dgvUser_UserCode"].Value);

                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Record? This cannot be reverted", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (cmbUserType.SelectedIndex == 2 && Constants.CurrentUser.UserType == "Admin")
                        {
                            if (DeleteTeacher(userID))
                            {
                                MessageBox.Show("Teacher deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete teacher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (cmbUserType.SelectedIndex == 1 && Constants.CurrentUser.UserType == "Admin")
                        {
                            if (DeleteStudent(userID))
                            {
                                MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (cmbUserType.SelectedIndex == 0 && Constants.CurrentUser.UserType == "Admin")
                        {
                            if (DeleteUser(userID))
                            {
                                MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }


            }
        }
        public bool DeleteTeacher(int teacherID)
        {
            try
            {
                OpenConnection();

                string query = "DELETE FROM Teachers WHERE TeacherID = @TeacherID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeacherID", teacherID);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool DeleteStudent(int studentID)
        {
            try
            {
                OpenConnection();

                string query = "DELETE FROM Students WHERE StudentID = @StudentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error Occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool DeleteUser(int userID)
        {
            try
            {
                OpenConnection();

                string query = "DELETE FROM Users WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error Occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvUsers.Rows.Clear();
        }
    }
}
