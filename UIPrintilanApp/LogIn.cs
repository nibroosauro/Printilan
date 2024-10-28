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
using UIPrintilanApp;

namespace UIPrintilanApp
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Buat objek Employee dengan username dan password dari input (misal dari TextBox)
            Employee employee = new Employee(tbUsername.Text, tbPassword.Text);

            // Cek login
            if (employee.Login())
            {
                // Jika login berhasil, tampilkan pesan
                MessageBox.Show("Login Berhasil, ID anda adalah " + employee.EmployeeID.ToString(), "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sembunyikan form login
                this.Hide();

                // Tampilkan form homepage
                Homepage homePage = new Homepage(); // Pastikan menggunakan nama yang benar
                homePage.Show(); // Tampilkan Homepage
            }
            else
            {
                // Jika login gagal, tampilkan pesan error
                MessageBox.Show("Login Gagal, Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide(); // Sembunyikan form sign-up
            SignUp SignUpForm = new SignUp(); // Asumsikan kamu punya form login
            SignUpForm.Show();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
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
                string query = "SELECT userid FROM tb_user WHERE username = @username AND password = @password";

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


        //// PAKE DUMMY YA KAK YA buat username n password
        //var users = new Dictionary<string, string>
        //{
        //    { "Barbara", "BarbaraCantiq" },
        //    { "Elin", "Elinrawr" },
        //    { "Rore", "Rorenihboz" }
        //};

        //// Cek kombinasi username dan password ada di Dictionary
        //if (users.TryGetValue(LoginName, out string correctPassword) && correctPassword == Password)
        //{
        //    if (LoginName == "Barbara")
        //        EmployeeID = 4;
        //    else if (LoginName == "Elin")
        //        EmployeeID = 5;
        //    else if (LoginName == "Rore")
        //        EmployeeID = 6;
        //    else
        //        EmployeeID = 0; // Default ID

        //    return true;
        //}
        //else
        //{
        //    return false;
        //}
    }
}

