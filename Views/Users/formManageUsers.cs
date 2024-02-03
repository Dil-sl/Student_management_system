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
                PopulateTeachersDataGridView(txtUserName.Text.ToString());
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
                // Handle exceptions
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
                dgvUsers.Columns["dgvUser_Edit"].Visible = false;
                dgvUsers.Columns["dgvUser_Delete"].Visible = false;
                dgvUsers.Columns["dgvUser_Index"].Visible = false;
                dgvUsers.Columns["dgvUser_Reg"].Visible = false;
                dgvUsers.Columns["dgvUser_Gname"].Visible = false;
                dgvUsers.Columns["dgvUser_Gcontact"].Visible = false;
                dgvUsers.Columns["dgvUser_Date"].Visible = false;

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
                        //dgvUsers.Rows[rowIndex].Cells["dgvUser_Edit"].Value = "Edit"; // Add your edit button logic here
                        //dgvUsers.Rows[rowIndex].Cells["dgvUser_Delete"].Value = "Delete"; // Add your delete button logic here
                        //dgvUsers.Rows[rowIndex].Cells["dgvUser_Index"].Value = rowIndex + 1; // Assuming you want to display an index

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

    }
}
