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

namespace LoginForm
{
    public partial class btnChangePassword2 : Form
    {
        public btnChangePassword2()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // Create a connection to the SQL Server database
            string connectionString = "Data Source=DESKTOP-OQ7MM4J;Initial Catalog=LoginFormTest;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Create a SQL statement to check if the user with the given username exists
            string sql = "SELECT COUNT(*) FROM tbluserRegistration WHERE username = @Username";

            // Create a SqlCommand object to execute the SQL statement and pass the connection and the SQL statement as arguments
            SqlCommand command = new SqlCommand(sql, connection);

            // Set the value of the username in the SQL statement's parameter collection
            string username = txtUser.Text;
            command.Parameters.AddWithValue("@Username", username);

            // Open the database connection
            connection.Open();

            // Execute the SQL command using the ExecuteScalar method of the SqlCommand object
            int count = (int)command.ExecuteScalar();

            // Close the database connection
            connection.Close();
            if (count > 0)
            {

                MessageBox.Show("User exists.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string newpass = txtNewPassword.Text;
                string confirmnewpass = txtConfirmNewPassword.Text;

                if (newpass != confirmnewpass)
                {
                    MessageBox.Show("Passwords not matched.", "Not Matched", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Create a SQL statement to update the user's password in the database
                    string query = "UPDATE tblUserRegistration SET password = @password WHERE username = @username";

                    SqlCommand command2 = new SqlCommand(query, connection);
                    command2.Parameters.AddWithValue("@password", Cryptography.Encrypt(txtNewPassword.Text));
                    command2.Parameters.AddWithValue("@username", username);

                    // Set the Connection property of the command to the connection object
                    command2.Connection = connection;

                    // Open the database connection
                    connection.Open();

                    // Execute the SQL command using the ExecuteNonQuery method of the SqlCommand object
                    int rowsAffected = command2.ExecuteNonQuery();

                    // Close the database connection
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Password update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

            }
            else
            {
                MessageBox.Show("User does not exist.", "No user exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
