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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_management_system.Views.Users
{
    public partial class formAddUsers : Form
    {
        private static formAddUsers _instance;
        private readonly SqlConnection connection;
        public string userMode;
        public string userEnvioronment;
        public int userId;
        bool success;
        public formAddUsers()
        {
            InitializeComponent();
            connection = DbConnection.GetConnection();//DB initialize
        }
        public static formAddUsers useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formAddUsers();
                return _instance;
            }
            set { _instance = value; }
        }

        private void formAddUsers_Load(object sender, EventArgs e)
        {
            btnAdminReset.Visible = false;
            btnStudentReset.Visible = false;    
            btnTeacherReset.Visible = false;
            if (userEnvioronment!="Edit")
            {
                UIchange(false, false, false);
                LoadClassesIntoComboBox();
            }
            else
            {
                cmbUserType.Enabled = false;
                LoadClassesIntoComboBox();
            }
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
                userMode = "Admin";
            }
            else if (cmbUserType.SelectedIndex == 1)
            {
                UIchange(true, true, false);
                userMode = "Student";
            }
            else if (cmbUserType.SelectedIndex == 2)
            {
                UIchange(true, true, true);
                userMode = "Teacher";
            }
            else
            {
                UIchange(false, false, false);
            }
        }

        //Db Calling 
    
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

        // Create (Insert) User
        public bool CreateUser(UserModel user)
        {
            try
            {
                OpenConnection();

                string query = "INSERT INTO Users (Username, Password, UserType, FullName, Email, ContactNumber) " +
                               "VALUES (@Username, @Password, @UserType, @FullName, @Email, @ContactNumber)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@UserType", user.UserType);
                    command.Parameters.AddWithValue("@FullName", user.FullName);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@ContactNumber", user.ContactNumber);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        private void DynamicVarivbles()
        {
            if(userMode=="Admin")
            {
                UserModel user = new UserModel();
                user.Username = txtAdminUserName.Text;
                user.Password = txtAdminPassword.Text;
                user.UserType = cmbUserType.SelectedItem.ToString();
                user.FullName = txtAdminFullName.Text;
                user.Email = txtAdminEmail.Text;
                user.ContactNumber = txtAdminContact.Text;
                if(userEnvioronment!="Edit")
                {
                    success = CreateUser(user);
                }
                else
                {
                    success = UpdateUser(user);
                    if (success)
                    {
                        MessageBox.Show("Class created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to create class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
            else if(userMode == "Student")
            {
               StudentModel student = new StudentModel();
               
               student.FullName = txtStudentFullName.Text;
               student.Email = txtStudentEmail.Text;
               student.Contact = txtStudentContact.Text;
               student.RegNo=txtStudentRegisterNo.Text;
               student.Gender=cmbStudeentGender.SelectedItem.ToString();
               student.DOB = dtpStudentBirthDay.Value;
               student.Address=txtStudentAddress.Text;
               student.GuardianName=txtStudentGname.Text;
               student.GuardianContactNumber=txtStudentGcontact.Text;
               student.Class=txtStudentClass.SelectedItem.ToString();
                if (userEnvioronment != "Edit")
                {
                    success = CreateStudent(student);
                }
                else
                {
                    success = UpdateStudent(student);
                    if (success)
                    {
                        MessageBox.Show("Class created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to create class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
            else if(userMode == "Teacher")
            {
                TeacherModel teacher = new TeacherModel();

                teacher.FullName =txtTeacherFullname.Text;
                teacher.Email = txtTeacherEmail.Text;
                teacher.ContactNumber = txtTeacherContact.Text; 
                teacher.Gender = cmbTeacherGender.SelectedItem.ToString();
                teacher.DOB = dtpTeacherDob.Value;
                teacher.Address = txtTeacherAddress.Text;
                teacher.Subjects = txtTeacherSubject.Text;
                teacher.OwnedClass = cmbTeacherClass.SelectedItem.ToString();

                UserModel user = new UserModel();
                user.Username = txtTeacherUserName.Text;
                user.Password =txtTeacherPassword.Text;
                user.UserType = cmbUserType.SelectedItem.ToString();
                user.FullName = txtTeacherFullname.Text;
                user.Email = txtTeacherEmail.Text;
                user.ContactNumber = txtTeacherContact.Text;
                if (userEnvioronment != "Edit")
                {
                    CreateUser(user);
                    success = CreateTeacher(teacher);

                }
                else
                {
                    UpdateUser(user);
                    success = UpdateTeacher(teacher);
                    if (success)
                    {
                        MessageBox.Show("Class created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to create class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }            
            }
            else
            {

            }
            if (success)
            {
                MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to create user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
      
        private bool ValidateFormFill()
        {
            if (userMode == "Admin")
            {
                if (string.IsNullOrWhiteSpace(txtAdminUserName.Text) || string.IsNullOrWhiteSpace(txtAdminPassword.Text) ||
                    cmbUserType.SelectedItem == null || string.IsNullOrWhiteSpace(txtAdminFullName.Text) ||
                    string.IsNullOrWhiteSpace(txtAdminEmail.Text) || string.IsNullOrWhiteSpace(txtAdminContact.Text))
                {
                    MessageBox.Show("Please fill in all required fields for Admin.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (userMode == "Student")
            {
         
                if (string.IsNullOrWhiteSpace(txtStudentFullName.Text) || string.IsNullOrWhiteSpace(txtStudentEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtStudentContact.Text) || string.IsNullOrWhiteSpace(txtStudentRegisterNo.Text) ||
                    cmbStudeentGender.SelectedItem == null || string.IsNullOrWhiteSpace(txtStudentAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtStudentGname.Text) || string.IsNullOrWhiteSpace(txtStudentGcontact.Text) ||
                    txtStudentClass.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all required fields for Student.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (userMode == "Teacher")
            {
       

                if (string.IsNullOrWhiteSpace(txtTeacherFullname.Text) || string.IsNullOrWhiteSpace(txtTeacherEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtTeacherContact.Text) || cmbTeacherGender.SelectedItem == null ||
                    dtpTeacherDob.Value == null || string.IsNullOrWhiteSpace(txtTeacherAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtTeacherSubject.Text) || cmbTeacherClass.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtTeacherUserName.Text) || string.IsNullOrWhiteSpace(txtTeacherPassword.Text) ||
                    cmbUserType.SelectedItem == null || string.IsNullOrWhiteSpace(txtTeacherFullname.Text) ||
                    string.IsNullOrWhiteSpace(txtTeacherEmail.Text) || string.IsNullOrWhiteSpace(txtTeacherContact.Text))
                {
                    MessageBox.Show("Please fill in all required fields for Teacher.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                // Handle other cases
            }

            return true;
        }


        //create studentt

        public bool CreateStudent(StudentModel student)
        {
            try
            {
                OpenConnection();

                string query = "INSERT INTO Students (RegNo, FullName, Gender, DOB, Address, Contact, Email, GuardianName, GuardianContactNumber, Class) " +
                               "VALUES (@RegNo, @FullName, @Gender, @DOB, @Address, @Contact, @Email, @GuardianName, @GuardianContactNumber, @Class)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RegNo", student.RegNo);
                    command.Parameters.AddWithValue("@FullName", student.FullName);
                    command.Parameters.AddWithValue("@Gender", student.Gender);
                    command.Parameters.AddWithValue("@DOB", student.DOB);
                    command.Parameters.AddWithValue("@Address", student.Address);
                    command.Parameters.AddWithValue("@Contact", student.Contact);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@GuardianName", student.GuardianName);
                    command.Parameters.AddWithValue("@GuardianContactNumber", student.GuardianContactNumber);
                    command.Parameters.AddWithValue("@Class", student.Class);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        //create teacher
        public bool CreateTeacher(TeacherModel teacher)
        {
            try
            {
                OpenConnection();

                string query = "INSERT INTO Teachers (FullName, DOB, ContactNumber, Address, Gender, Email, Subjects, OwnedClass) " +
                               "VALUES (@FullName, @DOB, @ContactNumber, @Address, @Gender, @Email, @Subjects, @OwnedClass)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FullName", teacher.FullName);
                    command.Parameters.AddWithValue("@DOB", teacher.DOB);
                    command.Parameters.AddWithValue("@ContactNumber", teacher.ContactNumber);
                    command.Parameters.AddWithValue("@Address", teacher.Address);
                    command.Parameters.AddWithValue("@Gender", teacher.Gender);
                    command.Parameters.AddWithValue("@Email", teacher.Email);
                    command.Parameters.AddWithValue("@Subjects", teacher.Subjects);
                    command.Parameters.AddWithValue("@OwnedClass", teacher.OwnedClass);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        private void ResetFields()
        {
            if (userMode == "Admin")
            {
               
               txtAdminUserName.Clear();
               txtAdminPassword.Clear();
               cmbUserType.SelectedIndex = -1;
               txtAdminFullName.Clear();
               txtAdminEmail.Clear();
               txtAdminContact.Clear();
            }
            else if (userMode == "Student")
            {
               
              txtStudentFullName.Clear();
              txtStudentEmail.Clear();
              txtStudentContact.Clear();
              txtStudentRegisterNo.Clear();
              cmbStudeentGender.SelectedIndex = -1;
              dtpStudentBirthDay.Value = DateTime.Today;
              txtStudentAddress.Clear();
              txtStudentGname.Clear();
              txtStudentGcontact.Clear();
              txtStudentClass.SelectedIndex = -1; 

            }
            else if (userMode == "Teacher")
            {
               txtTeacherFullname.Clear();
               txtTeacherEmail.Clear();
               txtTeacherContact.Clear();
               cmbTeacherGender.SelectedItem.ToString();
               dtpTeacherDob.Value = DateTime.Today;
               txtTeacherAddress.Clear();
               txtTeacherSubject.Clear();
               cmbTeacherClass.SelectedIndex = -1;
               txtTeacherUserName.Clear();
               txtTeacherPassword.Clear();
               cmbUserType.SelectedIndex = -1;

            }
            else
            {

            }
        }

        private void btnStudentSave_Click(object sender, EventArgs e)
        {
            if (ValidateFormFill())
            {
                DynamicVarivbles();
            }
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
                        cmbTeacherClass.DisplayMember = "ClassName";
                        cmbTeacherClass.ValueMember = "ClassID";
                        txtStudentClass.DisplayMember = "ClassName";
                        txtStudentClass.ValueMember = "ClassID";


                        while (reader.Read())
                        {
                            int classID = reader.GetInt32(reader.GetOrdinal("ClassID"));
                            string className = reader.GetString(reader.GetOrdinal("ClassName"));

                            cmbTeacherClass.Items.Add(className);
                            txtStudentClass.Items.Add(className);
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

        private void btnAdminSave_Click(object sender, EventArgs e)
        {
            if (ValidateFormFill())
            {
                DynamicVarivbles();
            }
        }

        private void btnTeacherSave_Click(object sender, EventArgs e)
        {
            if (ValidateFormFill())
            {
                DynamicVarivbles();
            }
        }
        public void setToEdit(string userMode,string userEnvionment,int ID,int index)
        {
            btnAdminSave.Text = "Update";
            btnStudentSave.Text = "Update";
            btnTeacherSave.Text = "Update";
            welcomeLabel.Text = "Update User";
            this.userId = ID;
            this.userMode = userMode;
            this.userEnvioronment = userEnvionment;
            cmbUserType.SelectedIndex = index;
            if(userMode=="Teacher")
            {
                TeacherModel teacherModel = GetTeacherByID(ID);
                UserModel userModel = GetUserByID(ID);
                FillObject(teacherModel,null,userModel);
            }
            else if(userMode=="Student")
            {
                StudentModel studentModel = GetStudentByID(ID);
                FillObject(null, studentModel, null);
            }
            else if(userMode=="Admin")
            {
                UserModel userModel = GetUserByID(ID);
                FillObject(null, null, userModel);
            }          
        }
        private void FillObject(TeacherModel teacherModel,StudentModel studentModel, UserModel userModel)
        {
            if (userMode == "Admin")
            {
                // Load details for Admin
                txtAdminUserName.Text = userModel.Username;
                txtAdminPassword.Text = userModel.Password; // Assuming you have a password textbox
                cmbUserType.Text = userModel.UserType;
                txtAdminFullName.Text = userModel.FullName;
                txtAdminEmail.Text = userModel.Email;
                txtAdminContact.Text = userModel.ContactNumber;
                UIchange(true, false, false);
            }
            else if (userMode == "Student")
            {
                // Load details for Student
                txtStudentFullName.Text = studentModel.FullName;
                txtStudentEmail.Text = studentModel.Email;
                txtStudentContact.Text = studentModel.Contact;
                txtStudentRegisterNo.Text = studentModel.RegNo;
                cmbStudeentGender.Text = studentModel.Gender;
                dtpStudentBirthDay.Value = studentModel.DOB;
                txtStudentAddress.Text = studentModel.Address;
                txtStudentGname.Text = studentModel.GuardianName;
                txtStudentGcontact.Text = studentModel.GuardianContactNumber;
                txtStudentClass.SelectedValue = studentModel.Class;
                UIchange(true, true, false);

            }
            else if (userMode == "Teacher")
            {
                // Load details for Teacher
                txtTeacherFullname.Text = teacherModel.FullName;
                txtTeacherEmail.Text = teacherModel.Email;
                txtTeacherContact.Text = teacherModel.ContactNumber;
                cmbTeacherGender.Text = teacherModel.Gender;
                dtpTeacherDob.Value = teacherModel.DOB;
                txtTeacherAddress.Text = teacherModel.Address;
                txtTeacherSubject.Text = teacherModel.Subjects;
                cmbTeacherClass.Text = teacherModel.OwnedClass;
                txtTeacherUserName.Text = userModel.Username;
                UIchange(true, true, true);
            }
            else
            {
                UIchange(false, false, false);
            }
        }
        //update details
        public bool UpdateTeacher(TeacherModel teacher)
        {
            try
            {
                OpenConnection();

                string query = "UPDATE Teachers SET FullName = @FullName, DOB = @DOB, ContactNumber = @ContactNumber, " +
                               "Address = @Address, Gender = @Gender, Email = @Email, Subjects = @Subjects, OwnedClass = @OwnedClass " +
                               "WHERE TeacherID = @TeacherID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeacherID", userId);
                    command.Parameters.AddWithValue("@FullName", teacher.FullName);
                    command.Parameters.AddWithValue("@DOB", teacher.DOB);
                    command.Parameters.AddWithValue("@ContactNumber", teacher.ContactNumber);
                    command.Parameters.AddWithValue("@Address", teacher.Address);
                    command.Parameters.AddWithValue("@Gender", teacher.Gender);
                    command.Parameters.AddWithValue("@Email", teacher.Email);
                    command.Parameters.AddWithValue("@Subjects", teacher.Subjects);
                    command.Parameters.AddWithValue("@OwnedClass", teacher.OwnedClass);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool UpdateStudent(StudentModel student)
        {
            try
            {
                OpenConnection();

                string query = "UPDATE Students SET RegNo = @RegNo, FullName = @FullName, Gender = @Gender, " +
                               "DOB = @DOB, Address = @Address, Contact = @Contact, Email = @Email, " +
                               "GuardianName = @GuardianName, GuardianContactNumber = @GuardianContactNumber, " +
                               "Class = @Class WHERE StudentID = @StudentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", userId);
                    command.Parameters.AddWithValue("@RegNo", student.RegNo);
                    command.Parameters.AddWithValue("@FullName", student.FullName);
                    command.Parameters.AddWithValue("@Gender", student.Gender);
                    command.Parameters.AddWithValue("@DOB", student.DOB);
                    command.Parameters.AddWithValue("@Address", student.Address);
                    command.Parameters.AddWithValue("@Contact", student.Contact);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@GuardianName", student.GuardianName);
                    command.Parameters.AddWithValue("@GuardianContactNumber", student.GuardianContactNumber);
                    command.Parameters.AddWithValue("@Class", student.Class);

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
        public bool UpdateUser(UserModel user)
        {
            try
            {
                OpenConnection();

                string query = "UPDATE Users SET Username = @Username, Password = @Password, " +
                               "UserType = @UserType, FullName = @FullName, Email = @Email, " +
                               "ContactNumber = @ContactNumber WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@UserType", user.UserType);
                    command.Parameters.AddWithValue("@FullName", user.FullName);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@ContactNumber", user.ContactNumber);

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
        //get Data
            public TeacherModel GetTeacherByID(int teacherID)
        {
            try
            {
                OpenConnection();

                string query = "SELECT * FROM Teachers WHERE TeacherID = @TeacherID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeacherID", teacherID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a new TeacherModel and populate it with data from the reader
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
                                OwnedClass = reader["OwnedClass"].ToString()
                                // Add other properties as needed
                            };

                            return teacher;
                        }
                    }
                }

                return null; // Return null if the teacher with the specified ID is not found
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error Occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
        public StudentModel GetStudentByID(int studentID)
        {
            try
            {
                OpenConnection();

                string query = "SELECT * FROM Students WHERE StudentID = @StudentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a new StudentModel and populate it with data from the reader
                            StudentModel student = new StudentModel
                            {
                                StudentID = (int)reader["StudentID"],
                                RegNo = reader["RegNo"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                DOB = (DateTime)reader["DOB"],
                                Address = reader["Address"].ToString(),
                                Contact = reader["Contact"].ToString(),
                                Email = reader["Email"].ToString(),
                                GuardianName = reader["GuardianName"].ToString(),
                                GuardianContactNumber = reader["GuardianContactNumber"].ToString(),
                                Class = reader["Class"].ToString()
                                // Add other properties as needed
                            };

                            return student;
                        }
                    }
                }

                return null; // Return null if the student with the specified ID is not found
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error Occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
        public UserModel GetUserByID(int userID)
        {
            try
            {
                OpenConnection();

                string query = "SELECT * FROM Users WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a new UserModel and populate it with data from the reader
                            UserModel user = new UserModel
                            {
                                UserID = (int)reader["UserID"],
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                UserType = reader["UserType"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                Email = reader["Email"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString()
                                // Add other properties as needed
                            };

                            return user;
                        }
                    }
                }

                return null; // Return null if the user with the specified ID is not found
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error Occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            formMain.useForm.setPanel(formUsers.useForm);
        }
    }
}
