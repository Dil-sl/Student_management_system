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
using System.Windows.Forms;
using Student_management_system.Models;
using Student_management_system.Service;
using Student_management_system.Views;

namespace Student_management_system.Views.Classes
{
    public partial class formAddClass : Form
    {
        private static formAddClass _instance;
        private readonly SqlConnection connection;
        private string userEnvioronment;
        private bool success;
        private int teacherID;
        private string teacherName;
        private List<(int TeacherID, string FullName)> teacherList = new List<(int TeacherID, string FullName)>();
        public formAddClass()
        {
            InitializeComponent();
            connection = DbConnection.GetConnection();//DB initialize
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
        public static formAddClass useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formAddClass();
                return _instance;
            }
            set { _instance = value; }
        }
        private void LoadTeachersIntoComboBox()
        {
            try
            {
                OpenConnection();

                string query = "SELECT TeacherID, FullName FROM Teachers";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        cmbClassTeacherID.DisplayMember = "TeacherID";
                        cmbClassTeacherID.ValueMember = "TeacherID";

                        while (reader.Read())
                        {
                            int teacherID = reader.GetInt32(reader.GetOrdinal("TeacherID"));
                            string teacherName = reader.GetString(reader.GetOrdinal("FullName"));

                            teacherList.Add((teacherID, teacherName));

                            cmbClassTeacherID.Items.Add(new { teacherID });
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
        private void cmbClassTeacherID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClassTeacherID.SelectedValue != null && int.TryParse(cmbClassTeacherID.SelectedValue.ToString(), out int selectedTeacherID))
            {
                // Find the teacher based on the selected teacher ID
                var selectedTeacher = teacherList.Find(t => t.TeacherID == selectedTeacherID);

                // Check if the tuple is not null
                if (selectedTeacher != default)
                {
                    this.teacherID = selectedTeacher.TeacherID;
                    this.teacherName = selectedTeacher.FullName;

                    // Update the TextBox with the selected teacher's name
                    txtClassname.Text = this.teacherName;
                }
                else
                {
                    MessageBox.Show("Teacher not found for the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle the case where the selected value is null or not a valid integer
                MessageBox.Show("Invalid Class Teacher ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fillObject()
        {
            ClassModel user = new ClassModel();
            user.ClassName = txtClassname.Text;
            user.ClassTeacherID = teacherID;

            if (userEnvioronment != "Edit")
            {
                success = CreateClass(user);
            }
        }
        public bool CreateClass(ClassModel classModel)
        {
            try
            {
                OpenConnection();

                string query = "INSERT INTO Classes (ClassName, ClassTeacherID) " +
                               "VALUES (@ClassName, @ClassTeacherID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassName", classModel.ClassName);
                    command.Parameters.AddWithValue("@ClassTeacherID", classModel.ClassTeacherID);
                    
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
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

        private void btnClassSave_Click(object sender, EventArgs e)
        {
            fillObject();
        }

        private void formAddClass_Load(object sender, EventArgs e)
        {
            LoadTeachersIntoComboBox();
        }
    }
}
