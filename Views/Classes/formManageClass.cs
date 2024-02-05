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

namespace Student_management_system.Views.Classes
{
    public partial class formManageClass : Form
    {
        private static formManageClass _instance;
        private readonly SqlConnection connection;
        public formManageClass()
        {
            InitializeComponent();
            connection = DbConnection.GetConnection();//DB initialize
        }
        public static formManageClass useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formManageClass();
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
        public List<ClassModel> GetClassesWithTeachers(string searchCriteria)
        {
            List<ClassModel> classes = new List<ClassModel>();

            try
            {
                OpenConnection();

                string query = "SELECT c.ClassID, c.ClassName, ISNULL(t.FullName, 'N/A') AS TeacherName, ISNULL(t.TeacherID, 0) AS TeacherID " +
                               "FROM Classes c " +
                               "LEFT JOIN Teachers t ON c.ClassName = t.OwnedClass " +
                               "WHERE c.ClassName LIKE @SearchCriteria OR t.FullName LIKE @SearchCriteria OR @SearchCriteria IS NULL";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchCriteria", "%" + searchCriteria + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClassModel classInfo = new ClassModel()
                            {
                                ClassID = (int)reader["ClassID"],
                                ClassName = reader["ClassName"].ToString(),
                                TeacherName = reader["TeacherName"].ToString(),
                                TeacherID = (int)reader["TeacherID"]
                            };

                            classes.Add(classInfo);
                        }
                    }
                }

                return classes;
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


        public void PopulateClassDataGridView(string searchCriteria)
        {
            try
            {
                // Get the list of classes with teachers
                List<ClassModel> classes = GetClassesWithTeachers(searchCriteria);

                // Clear existing rows in the DataGridView
                dgvClass.Rows.Clear();

                if (classes != null && classes.Count > 0)
                {
                    foreach (ClassModel classInfo in classes)
                    {
                        // Add a new row to the DataGridView
                        int rowIndex = dgvClass.Rows.Add();

                        // Set cell values for each visible column
                        dgvClass.Rows[rowIndex].Cells["dgvClass_ClassCode"].Value = classInfo.ClassID;
                        dgvClass.Rows[rowIndex].Cells["dgvClass_ClassName"].Value = classInfo.ClassName;
                        dgvClass.Rows[rowIndex].Cells["dgvClass_ClassTeacherName"].Value = classInfo.TeacherName;
                        dgvClass.Rows[rowIndex].Cells["dgvClass_ClassTeacherID"].Value = classInfo.TeacherID;
                        dgvClass.Rows[rowIndex].Cells["dgvClass_Delete"].Value = Properties.Resources.Delette;
                        dgvClass.Rows[rowIndex].Cells["dgvClass_Index"].Value = rowIndex;
                    }

                    dgvClass.Refresh();
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

        private void formManageClass_Load(object sender, EventArgs e)
        {
            PopulateClassDataGridView(null);
        }

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvClass_Delete.Index && e.RowIndex != -1)
            {
                //delete Product
                int classID = Convert.ToInt32(dgvClass.Rows[e.RowIndex].Cells["dgvClass_ClassCode"].Value);

                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Record? This cannot be reverted", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Constants.CurrentUser.UserType == "Admin")
                        {
                            if (DeleteClass(classID))
                            {
                                MessageBox.Show("Teacher deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete teacher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }



                    }
                }
            }
        }
        public bool DeleteClass(int classID)
        {
            try
            {
                OpenConnection();

                string query = "DELETE FROM Classes WHERE ClassID = @ClassID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassID", classID);

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

        private void btnSearchClass_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtSearchClass.Text))
            {
                PopulateClassDataGridView(txtSearchClass.Text);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            formMain.useForm.setPanel(formClasses.useForm);
        }
    }
}
