using Student_management_system.Views;
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

namespace Student_management_system
{
    public partial class formLogin : Form
    {
        private readonly SqlConnection connection;
        private static formLogin _instance;
        private readonly string connectionString;
        public formLogin()
        {
            InitializeComponent();
            connection = DbConnection.GetConnection();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\source\repos\Student_management_system\SMS_SIS.mdf;Integrated Security=True";
        }
        public static formLogin useForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new formLogin();
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
        public bool CheckCredentials(string username, string password, out UserModel user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // User found, retrieve details
                            user = new UserModel
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                Username = Convert.ToString(reader["Username"]),
                                UserType = Convert.ToString(reader["UserType"]),
                                FullName = Convert.ToString(reader["FullName"]),
                                Email = Convert.ToString(reader["Email"]),
                                ContactNumber = Convert.ToString(reader["ContactNumber"])
                                // Include other properties as needed
                            };

                            return true;
                        }
                    }
                }
            }

            // No matching user found
            user = null;
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string enteredUsername = txtUserName.Text;
            string enteredPassword = txtPassword.Text;

            // Check credentials
            if (CheckCredentials(enteredUsername, enteredPassword, out UserModel authenticatedUser))
            {
                Constants.CurrentUser = authenticatedUser;
                formMain.useForm.ShowDialog();
                this.Visible = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoginClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
