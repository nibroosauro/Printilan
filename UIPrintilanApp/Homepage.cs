using System;
using System.Windows.Forms;

namespace UIPrintilanApp
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            InitializeHomepage();
        }

        private void InitializeHomepage()
        {
            // Atur properti Panel untuk mendukung scroll
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Logika yang diperlukan saat PictureBox diklik (jika ada)
        }

        private void pbHomepage_Click(object sender, EventArgs e)
        {

        }

        private void btnChair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product ProductForm = new Product();
            ProductForm.Show();
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile_Page profileForm = new Profile_Page();
            profileForm.Show();
        }


        private void btnDM_Click(object sender, EventArgs e)
        {
            this.Hide();
            DM DMForm = new DM(); 
            DMForm.Show();
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ini nanti page Wishlist", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}