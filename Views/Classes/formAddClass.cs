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
       
        private void cmbClassTeacherID_SelectedIndexChanged(object sender, EventArgs e)
        {
              
              
        }
        private void fillObject()
        {
            ClassModel user = new ClassModel();
            user.ClassName = txtClassname.Text;

            if (userEnvioronment != "Edit")
            {
                success = CreateClass(user);

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

        public bool CreateClass(ClassModel classModel)
        {
            try
            {
                OpenConnection();

                string query = "INSERT INTO Classes (ClassName) " +
                               "VALUES (@ClassName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassName", classModel.ClassName);

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
            if (!string.IsNullOrWhiteSpace(txtClassname.Text))
            {
                fillObject();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formAddClass_Load(object sender, EventArgs e)
        {
          
        }
    }
}
