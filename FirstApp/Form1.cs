using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=VALTVSM016\\SQLEXPRESS;Initial Catalog=test_environment;Integrated Security=True;Encrypt=False;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = textBox1.Text;
            string email = textBox2.Text;
            string password = maskedTextBox1.Text;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            User user = InsertUser(fullName, email, password);
            if (user != null)
            {
                MessageBox.Show("Registration successful.");
                Home home = new Home(user);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration failed.");
            }
        }

        private User InsertUser(string fullName, string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (UserName, UserEmail, Password, RegistrationDate) OUTPUT INSERTED.UserRole, INSERTED.UsernameID, INSERTED.lastLogin, INSERTED.registrationDate VALUES (@UserName, @UserEmail, @Password, @RegistrationDate)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", fullName);
                        command.Parameters.AddWithValue("@UserEmail", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    UserRole = (string)reader["userRole"],
                                    UserName = (string)reader["UserName"],
                                    UsernameID = (string)reader["UsernameID"],
                                    lastLogin = (string)reader["lastLogin"],
                                    registrationDate = (string)reader["registrationDate"]
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
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
