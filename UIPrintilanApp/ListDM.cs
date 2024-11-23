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
    public partial class ListDM : Form
    {
        public ListDM()
        {
            InitializeComponent();
        }

        private void ListDM_Load(object sender, EventArgs e)
        {

        }

        private void btnBackHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage HomepageForm = new Homepage();
            HomepageForm.Show();
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDM_Click(object sender, EventArgs e)
        {
            this.Hide();
            DM dmForm = new DM();
            dmForm.Show();
        }

        private void btnWhsh_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ini nanti page Wishlist", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Profile_Page profileForm = new Profile_Page();
            profileForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
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