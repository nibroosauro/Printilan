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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UIPrintilanApp
{
    public partial class Profile_Page : Form
    {
        public Profile_Page()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Username = txtboxNewUsername.Text;
            string Password = txtboxNewPassword.Text;
            string Email = txtboxNewEmail.Text;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Use UserSession.UserId to access the current user's ID
            int userId = UserSession.UserId;

            try
            {
                using (var connection = new NpgsqlConnection(AppSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE tb_user SET username = @username, password = @password, email = @email " +
                                   "WHERE userid = @userId";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", Username);
                        command.Parameters.AddWithValue("@password", Password);
                        command.Parameters.AddWithValue("@email", Email);
                        command.Parameters.AddWithValue("@userId", userId); // Use the userId to update the correct user

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //private void btnSetUpProfile_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    SetUpStore SetUpProfileForm = new SetUpStore();
        //    SetUpProfileForm.Show();
        //}

        private void btnSetUpProfile_Click(object sender, EventArgs e)
        {
            // Use UserSession.UserId to access the current user's ID
            int userId = UserSession.UserId;

            try
            {
                using (var connection = new NpgsqlConnection(AppSettings.ConnectionString))
                {
                    connection.Open();

                    // Query to check if the user has a corresponding seller record
                    string query = "SELECT sellerid FROM seller WHERE userid = @userId";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);

                        var result = command.ExecuteScalar(); // Fetch the sellerid (if any)

                        if (result != DBNull.Value && result != null)
                        {
                            // If sellerid exists, allow the user to go to the SetUpStore page
                            this.Hide();
                            SetUpStore SetUpProfileForm = new SetUpStore();
                            SetUpProfileForm.Show();
                        }
                        else
                        {
                            // If sellerid doesn't exist, show a message
                            MessageBox.Show("You must register as a seller before setting up your store.",
                                            "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking seller status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Profile_Page_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
            
        }

        private void LoadUserProfile()
        {
            // Use UserSession.UserId to fetch user data from database
            int userId = UserSession.UserId;

            try
            {
                using (var connection = new NpgsqlConnection(AppSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT username, email FROM tb_user WHERE userid = @userId";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtboxNewUsername.Text = reader["username"].ToString();
                                txtboxNewEmail.Text = reader["email"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWhsh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ini nanti page Wishlist", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDM_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ListDM ListDMForm = new ListDM();
            ListDMForm.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
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
    }
}
