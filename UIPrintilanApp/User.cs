using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrintilanApp
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }

    // Class Employee
    public class Employee
    {
        // Properties LoginName, Password, dan EmployeeID
        public string LoginName { get; set; }
        public string Password { get; set; }
        public int EmployeeID { get; set; }

        // Constructor default
        public Employee() { }

        // Constructor dengan parameter loginName dan password
        public Employee(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
        }

        // Method login
        public bool Login()
        {

            // Check if ConnectionString is initialized
            if (string.IsNullOrEmpty(AppSettings.ConnectionString))
            {
                MessageBox.Show("Connection string is not set. Please check your environment variable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Proceed with the database connection using Npgsql
            using (var connection = new NpgsqlConnection(AppSettings.ConnectionString))
            {
                try
                {
                    connection.Open();
                   // string query = "SELECT userid FROM tb_user WHERE username = @username AND password = @password";
                    string query = "SELECT verify_user(@username, @password)";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", LoginName);
                        command.Parameters.AddWithValue("@password", Password);

                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            EmployeeID = Convert.ToInt32(result);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
