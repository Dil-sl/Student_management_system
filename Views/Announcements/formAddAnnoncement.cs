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

namespace Student_management_system.Views.Announcements
{
    
    public partial class formAddAnnoncement : Form
    {
        private readonly SqlConnection connection;
        private static formAddAnnoncement _instance;
        private string userEnvioronment;
        private bool success;
        public formAddAnnoncement()
        {
            InitializeComponent();
            connection = DbConnection.GetConnection();//DB initialize

        }
        public static formAddAnnoncement useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formAddAnnoncement();
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
        private void fillObject()
        {
            NoticeboardModel announcement = new NoticeboardModel();
            announcement.Title = txtAnnouTitle.Text;
            announcement.Description = txtAnnoDesc.Text;
            announcement.PostedBy = Constants.CurrentUser.UserID; // Assuming UserID is used for identification
            announcement.PostedDate = DateTime.Today;
            announcement.ExpiredDate = dtpAnnouExpireDate.Value;

            if (userEnvioronment != "Edit")
            {
                success = CreateAnnouncement(announcement);

                if (success)
                {
                    MessageBox.Show("Announcement created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to create announcement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool CreateAnnouncement(NoticeboardModel announcement)
        {
            try
            {
                OpenConnection();

                string query = "INSERT INTO Noticeboard (Title, Description, PostedBy, PostedDate, ExpiredDate) " +
                               "VALUES (@Title, @Description, @PostedBy, @PostedDate, @ExpiredDate)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", announcement.Title);
                    command.Parameters.AddWithValue("@Description", announcement.Description);
                    command.Parameters.AddWithValue("@PostedBy", announcement.PostedBy);
                    command.Parameters.AddWithValue("@PostedDate", announcement.PostedDate);
                    command.Parameters.AddWithValue("@ExpiredDate", announcement.ExpiredDate);

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

        private void btnAnnouSave_Click(object sender, EventArgs e)
        {
            if(ValidateFormFill())
            {
                fillObject();
            }
        }
        private bool ValidateFormFill()
        {
            if (string.IsNullOrWhiteSpace(txtAnnouTitle.Text) || string.IsNullOrWhiteSpace(txtAnnoDesc.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the expiration date is in the future
            if (dtpAnnouExpireDate.Value < DateTime.Today)
            {
                MessageBox.Show("Please select a valid expiration date in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
