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
            UIchange(false,false, false);
            LoadClassesIntoComboBox();
        }
        private void UIchange(bool isAdminUI,bool isStudentuI,bool isTeacherUI)
        {
            pnlAdminForm.Visible = isAdminUI;
            pnlStudentForm.Visible = isStudentuI; 
            pnlTeacherForm.Visible = isTeacherUI;
            if(isAdminUI||isStudentuI||isTeacherUI)
            {

            }
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
                success = CreateUser(user);
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
               success = CreateStudent(student);

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
                CreateUser(user);
                success = CreateTeacher(teacher);  

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
            if(ValidateFormFill())
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

                            cmbTeacherClass.Items.Add(new { ClassName = className });
                            txtStudentClass.Items.Add(new { ClassName = className });
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
    }
}
