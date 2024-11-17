namespace UIPrintilanApp
{
    partial class ListDM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListDM));
            this.btnDM = new System.Windows.Forms.Button();
            this.btnWishlist = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnBackHomepage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDM
            // 
            this.btnDM.BackColor = System.Drawing.Color.Transparent;
            this.btnDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDM.ForeColor = System.Drawing.Color.Transparent;
            this.btnDM.Location = new System.Drawing.Point(44, 146);
            this.btnDM.Margin = new System.Windows.Forms.Padding(2);
            this.btnDM.Name = "btnDM";
            this.btnDM.Size = new System.Drawing.Size(1353, 118);
            this.btnDM.TabIndex = 1;
            this.btnDM.UseVisualStyleBackColor = false;
            this.btnDM.Click += new System.EventHandler(this.btnDM_Click);
            // 
            // btnWishlist
            // 
            this.btnWishlist.BackColor = System.Drawing.Color.Transparent;
            this.btnWishlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWishlist.FlatAppearance.BorderSize = 0;
            this.btnWishlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWishlist.ForeColor = System.Drawing.Color.Transparent;
            this.btnWishlist.Location = new System.Drawing.Point(1137, 19);
            this.btnWishlist.Margin = new System.Windows.Forms.Padding(0);
            this.btnWishlist.Name = "btnWishlist";
            this.btnWishlist.Size = new System.Drawing.Size(53, 58);
            this.btnWishlist.TabIndex = 9;
            this.btnWishlist.UseVisualStyleBackColor = false;
            this.btnWishlist.Click += new System.EventHandler(this.btnWhsh_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnProfile.Location = new System.Drawing.Point(1271, 25);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(48, 47);
            this.btnProfile.TabIndex = 10;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click_1);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuit.Location = new System.Drawing.Point(1329, 19);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(57, 52);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnBackHomepage
            // 
            this.btnBackHomepage.BackColor = System.Drawing.Color.Transparent;
            this.btnBackHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackHomepage.FlatAppearance.BorderSize = 0;
            this.btnBackHomepage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBackHomepage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBackHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackHomepage.ForeColor = System.Drawing.Color.Transparent;
            this.btnBackHomepage.Location = new System.Drawing.Point(530, 854);
            this.btnBackHomepage.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackHomepage.Name = "btnBackHomepage";
            this.btnBackHomepage.Size = new System.Drawing.Size(381, 91);
            this.btnBackHomepage.TabIndex = 12;
            this.btnBackHomepage.UseVisualStyleBackColor = false;
            this.btnBackHomepage.Click += new System.EventHandler(this.btnBackHomepage_Click);
            // 
            // ListDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 1024);
            this.Controls.Add(this.btnBackHomepage);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnWishlist);
            this.Controls.Add(this.btnDM);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1440, 1024);
            this.MinimumSize = new System.Drawing.Size(1440, 1024);
            this.Name = "ListDM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListDM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDM;
        private System.Windows.Forms.Button btnWishlist;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnBackHomepage;
    }
}