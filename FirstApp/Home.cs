using Microsoft.VisualBasic.Logging;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Home : Form
    {
        private string connectionString = "Data Source=VALTVSM016\\SQLEXPRESS;Initial Catalog=test_environment;Integrated Security=True;Encrypt=False;";
        private User currentUser;
        public Home(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadCustomerData();

            // Wire up the events
            customerTable.CellClick += customerTable_CellClick;
            searchButton.Click += searchButton_Click;
            updateButton.Click += updateButton_Click;
            deleteButton.Click += deleteButton_Click;
            logoutButton.Click += logoutButton_Click;

            // Populate labels with user data
            NameLabel.Text = currentUser.UserName;
            roleLabel.Text = currentUser.UserRole;
            usernameLabel.Text = currentUser.UsernameID;
            lastLoginLabel.Text = currentUser.lastLogin.ToString();
            registrationDateLabel.Text = currentUser.registrationDate.ToString();
        }

        private void LoadCustomerData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT firstName,lastName,email,phone,address,city,accountType,dateJoined,balance,accountNumber FROM customers"; // Adjust table name accordingly
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                customerTable.DataSource = dataTable;
            }
        }

        private void customerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customerTable.Rows[e.RowIndex];
                firstName.Text = row.Cells["firstName"].Value.ToString();
                lastName.Text = row.Cells["lastName"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
                phone.Text = row.Cells["phone"].Value.ToString();
                address.Text = row.Cells["address"].Value.ToString();
                city.Text = row.Cells["city"].Value.ToString();
                accountNumber.Text = row.Cells["accountNumber"].Value.ToString();
                accountType.Text = row.Cells["accountType"].Value.ToString();
                dateJoined.Text = row.Cells["dateJoined"].Value.ToString();
                customerBalance.Text = "R" + row.Cells["balance"].Value.ToString();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM customers WHERE accountNumber LIKE @searchText OR firstName LIKE @searchText OR lastName LIKE @searchText";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchField.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                customerTable.DataSource = dataTable;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE customers SET firstName = @firstName, lastName = @lastName, email = @email, phone = @phone, address = @address, city = @city, accountType = @accountType, dateJoined = @dateJoined, balance = @balance WHERE accountNumber = @accountNumber";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstName", firstName.Text);
                cmd.Parameters.AddWithValue("@lastName", lastName.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@city", city.Text);
                cmd.Parameters.AddWithValue("@accountType", accountType.Text);

                // Ensure balance is converted to a decimal
                if (decimal.TryParse(customerBalance.Text.Replace("R", ""), out decimal balance))
                {
                    cmd.Parameters.AddWithValue("@balance", balance);
                }
                else
                {
                    MessageBox.Show("Invalid balance value.");
                    return;
                }

                // Ensure dateJoined is converted to DateTime
                if (DateTime.TryParse(dateJoined.Text, out DateTime date))
                {
                    cmd.Parameters.AddWithValue("@dateJoined", date);
                }
                else
                {
                    MessageBox.Show("Invalid date value.");
                    return;
                }

                cmd.Parameters.AddWithValue("@accountNumber", accountNumber.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer data updated successfully!");
                    LoadCustomerData(); // Refresh the data grid
                }
                else
                {
                    MessageBox.Show("Failed to update customer data.");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM customers WHERE accountNumber = @accountNumber";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accountNumber", accountNumber.Text);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer deleted successfully!");
                        ClearFields();
                        LoadCustomerData(); // Refresh the data grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete customer.");
                    }
                }
            }
        }

        private void ClearFields()
        {
            firstName.Text = string.Empty;
            lastName.Text = string.Empty;
            email.Text = string.Empty;
            phone.Text = string.Empty;
            address.Text = string.Empty;
            city.Text = string.Empty;
            accountNumber.Text = string.Empty;
            accountType.Text = string.Empty;
            dateJoined.Text = string.Empty;
            customerBalance.Text = string.Empty;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide(); // Hide the current form
                LoginScreen loginForm = new LoginScreen(); // Assuming Login is the name of your login form
                loginForm.Show(); // Show the login form
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
