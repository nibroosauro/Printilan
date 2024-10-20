namespace UIPrintilanApp
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.btnOffer = new System.Windows.Forms.Button();
            this.btnWishlist = new System.Windows.Forms.Button();
            this.btnWhsh = new System.Windows.Forms.Button();
            this.btnDM = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOffer
            // 
            this.btnOffer.BackColor = System.Drawing.Color.Transparent;
            this.btnOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffer.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnOffer.Location = new System.Drawing.Point(284, 1031);
            this.btnOffer.Name = "btnOffer";
            this.btnOffer.Padding = new System.Windows.Forms.Padding(4);
            this.btnOffer.Size = new System.Drawing.Size(214, 84);
            this.btnOffer.TabIndex = 2;
            this.btnOffer.UseVisualStyleBackColor = false;
            this.btnOffer.Click += new System.EventHandler(this.btnOffer_Click);
            // 
            // btnWishlist
            // 
            this.btnWishlist.BackColor = System.Drawing.Color.Transparent;
            this.btnWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWishlist.ForeColor = System.Drawing.Color.Transparent;
            this.btnWishlist.Location = new System.Drawing.Point(685, 1031);
            this.btnWishlist.Name = "btnWishlist";
            this.btnWishlist.Padding = new System.Windows.Forms.Padding(4);
            this.btnWishlist.Size = new System.Drawing.Size(246, 84);
            this.btnWishlist.TabIndex = 2;
            this.btnWishlist.UseVisualStyleBackColor = false;
            this.btnWishlist.Click += new System.EventHandler(this.btnWishlist_Click);
            // 
            // btnWhsh
            // 
            this.btnWhsh.BackColor = System.Drawing.Color.Transparent;
            this.btnWhsh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWhsh.FlatAppearance.BorderSize = 0;
            this.btnWhsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhsh.ForeColor = System.Drawing.Color.Transparent;
            this.btnWhsh.Location = new System.Drawing.Point(1386, 20);
            this.btnWhsh.Margin = new System.Windows.Forms.Padding(0);
            this.btnWhsh.Name = "btnWhsh";
            this.btnWhsh.Size = new System.Drawing.Size(65, 69);
            this.btnWhsh.TabIndex = 8;
            this.btnWhsh.UseVisualStyleBackColor = false;
            this.btnWhsh.Click += new System.EventHandler(this.btnWish_Click);
            // 
            // btnDM
            // 
            this.btnDM.BackColor = System.Drawing.Color.Transparent;
            this.btnDM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDM.FlatAppearance.BorderSize = 0;
            this.btnDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDM.ForeColor = System.Drawing.Color.Transparent;
            this.btnDM.Location = new System.Drawing.Point(1471, 32);
            this.btnDM.Margin = new System.Windows.Forms.Padding(0);
            this.btnDM.Name = "btnDM";
            this.btnDM.Size = new System.Drawing.Size(66, 53);
            this.btnDM.TabIndex = 7;
            this.btnDM.UseVisualStyleBackColor = false;
            this.btnDM.Click += new System.EventHandler(this.btnDM_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnProfile.Location = new System.Drawing.Point(1554, 29);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(59, 56);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuit.Location = new System.Drawing.Point(1630, 27);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(70, 62);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1760, 1229);
            this.Controls.Add(this.btnWhsh);
            this.Controls.Add(this.btnDM);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnWishlist);
            this.Controls.Add(this.btnOffer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1760, 1229);
            this.MinimumSize = new System.Drawing.Size(1760, 1229);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOffer;
        private System.Windows.Forms.Button btnWishlist;
        private System.Windows.Forms.Button btnWhsh;
        private System.Windows.Forms.Button btnDM;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnQuit;
    }
}