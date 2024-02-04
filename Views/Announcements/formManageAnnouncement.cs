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

namespace Student_management_system.Views.Announcements
{
    public partial class formManageAnnouncement : Form
    {
        private static formManageAnnouncement _instance;
        private readonly SqlConnection connection;
        public formManageAnnouncement()
        {
            InitializeComponent();
            connection = DbConnection.GetConnection();//DB initialize

        }
        public static formManageAnnouncement useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formManageAnnouncement();
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
        public List<NoticeboardModel> GetNotices()
        {
            List<NoticeboardModel> notices = new List<NoticeboardModel>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM Noticeboard " +
                               "WHERE ExpiredDate >= @Today";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Today", DateTime.Today);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NoticeboardModel notice = new NoticeboardModel()
                            {
                                NoticeID = (int)reader["NoticeID"],
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString(),
                                PostedBy = (int)reader["PostedBy"],
                                PostedDate = (DateTime)reader["PostedDate"],
                                ExpiredDate = (DateTime)reader["ExpiredDate"]
                            };

                            notices.Add(notice);
                        }
                    }
                }

                return notices;
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
        public void PopulateNoticeboardDataGridView()
        {
            try
            {
                // Get the list of notices without expired notices according to today's date
                List<NoticeboardModel> notices = GetNotices();

                // Clear existing rows in the DataGridView
                dgvAnnou.Rows.Clear();

                if (notices != null && notices.Count > 0)
                {
                    foreach (NoticeboardModel notice in notices)
                    {
                        // Add a new row to the DataGridView
                        int rowIndex = dgvAnnou.Rows.Add();

                        // Set cell values for each visible column
                        dgvAnnou.Rows[rowIndex].Cells["dgvAnnou_ID"].Value = notice.NoticeID;
                        dgvAnnou.Rows[rowIndex].Cells["dgvAnnou_Title"].Value = notice.Title;
                        dgvAnnou.Rows[rowIndex].Cells["dgvAnnou_Desc"].Value = notice.Description;
                        dgvAnnou.Rows[rowIndex].Cells["dgvAnnou_PubBy"].Value = notice.PostedBy;
                        dgvAnnou.Rows[rowIndex].Cells["dgvAnnou_PubDate"].Value = notice.PostedDate;
                        dgvAnnou.Rows[rowIndex].Cells["dgvAnnou_ExpireDate"].Value = notice.ExpiredDate;
                        dgvAnnou.Rows[rowIndex].Cells["dgvAnnou_ExpireDate"].Value = notice.ExpiredDate;
                        dgvAnnou.Rows[rowIndex].Cells["dgvAnnou_Delete"].Value = Properties.Resources.Delette;
                        dgvAnnou.Rows[rowIndex].Cells["dgvAnnou_Index"].Value = rowIndex;
                    }

                    dgvAnnou.Refresh();
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

        private void dgvAnnou_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAnnou_Delete.Index && e.RowIndex != -1)
            {
                //delete Product
                int noticeIO = Convert.ToInt32(dgvAnnou.Rows[e.RowIndex].Cells["dgvAnnou_ID"].Value);

                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Record? This cannot be reverted", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Constants.CurrentUser.UserType == "Admin")
                        {
                            if (DeleteNoticeByID(noticeIO))
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
        public bool DeleteNoticeByID(int noticeID)
        {
            try
            {
                OpenConnection();

                string query = "DELETE FROM Noticeboard WHERE NoticeID = @NoticeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NoticeID", noticeID);

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

        private void formManageAnnouncement_Load(object sender, EventArgs e)
        {
            PopulateNoticeboardDataGridView();
        }
    }
}
