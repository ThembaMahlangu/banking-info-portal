using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class LoginScreen : Form
    {
        private string connectionString = "Data Source=VALTVSM016\\SQLEXPRESS;Initial Catalog=test_environment;Integrated Security=True;Encrypt=False;";

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            User user = ValidateUser(email, password);
            if (user != null)
            {
                MessageBox.Show("Login successful.");
                // Pass the user data to the Home form
                Home home = new Home(user);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private User ValidateUser(string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT userRole, UserName, usernameID, lastLogin, registrationDate FROM Users WHERE UserEmail = @UserEmail AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserEmail", email);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    UserRole = reader["userRole"].ToString(),
                                    UserName = reader["UserName"].ToString(),
                                    UsernameID = reader["usernameID"].ToString(),
                                    lastLogin = reader["lastLogin"].ToString(),
                                    registrationDate = reader["registrationDate"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return null;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
