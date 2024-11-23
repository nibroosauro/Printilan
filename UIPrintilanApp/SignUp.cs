using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrintilanApp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to quit Printilan App?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnToLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn loginForm = new LogIn();
            loginForm.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            // input dari TextBox
            string username = tbUserName.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generate random UserID
            Random rand = new Random();
            int userId = rand.Next(1000, 9999);  // Generates a random 4-digit number for UserID

            // Full name = username as per your request
            string fullName = username;

            // Insert data into the tb_user table
            try
            {
                using (var connection = new NpgsqlConnection(AppSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO tb_user (userid, username, email, full_name, password) " +
                                   "VALUES (@userId, @username, @email, @fullName, @password)";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@email", email);
                        // command.Parameters.AddWithValue("@phoneNumber", phoneNumber ?? (object)DBNull.Value); // Handle null value
                        command.Parameters.AddWithValue("@fullName", fullName);
                        command.Parameters.AddWithValue("@password", password);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Sign-up berhasil! Silakan login dengan username dan password Anda.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sembunyikan form sign-up
                this.Hide();
                // Tampilkan form login
                LogIn loginForm = new LogIn(); // Create instance of LogIn form
                loginForm.Show();
            }
            catch (Exception ex) // Added the 'ex' parameter for the exception handling
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
