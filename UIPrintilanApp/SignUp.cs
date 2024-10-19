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
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // input dari TextBox
            string username = tbUserName.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            // Validasi kl ada field kosong
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // objek User baru
            User newUser = new User(username, email, password);

            // Sign-up berhasil
            MessageBox.Show("Sign-up berhasil! Selamat datang, " + newUser.Username, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Sembunyikan form login
            this.Hide();

            // Tampilkan form homepage
            Homepage homePage = new Homepage(); // Pastikan menggunakan nama yang benar
            homePage.Show(); // Tampilkan Homepage
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
    }
}
