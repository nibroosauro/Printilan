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

            MessageBox.Show(Username, "Changes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOut_Click(object sender, EventArgs e)
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

        private void btnSetUpProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetUpStore SetUpProfileForm = new SetUpStore();
            SetUpProfileForm.Show();
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ini nanti page Wishlist", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDM_Click(object sender, EventArgs e)
        {
            this.Hide();
            DM DMForm = new DM();
            DMForm.Show();
        }

        private void Profile_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
