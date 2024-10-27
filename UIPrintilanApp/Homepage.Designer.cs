namespace UIPrintilanApp
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.btnKursi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelHomepage = new System.Windows.Forms.Panel();
            this.btnWishlist = new System.Windows.Forms.Button();
            this.btnDM = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnChair = new System.Windows.Forms.Button();
            this.pbHomepage = new System.Windows.Forms.PictureBox();
            this.panelHomepage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomepage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKursi
            // 
            this.btnKursi.Location = new System.Drawing.Point(0, 0);
            this.btnKursi.Name = "btnKursi";
            this.btnKursi.Size = new System.Drawing.Size(75, 23);
            this.btnKursi.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            // 
            // panelHomepage
            // 
            this.panelHomepage.AutoScroll = true;
            this.panelHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHomepage.Controls.Add(this.btnWishlist);
            this.panelHomepage.Controls.Add(this.btnDM);
            this.panelHomepage.Controls.Add(this.btnProfile);
            this.panelHomepage.Controls.Add(this.btnQuit);
            this.panelHomepage.Controls.Add(this.btnChair);
            this.panelHomepage.Controls.Add(this.pbHomepage);
            this.panelHomepage.Location = new System.Drawing.Point(1, 1);
            this.panelHomepage.Name = "panelHomepage";
            this.panelHomepage.Size = new System.Drawing.Size(1440, 1024);
            this.panelHomepage.TabIndex = 0;
            // 
            // btnWishlist
            // 
            this.btnWishlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.btnWishlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWishlist.BackgroundImage")));
            this.btnWishlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWishlist.FlatAppearance.BorderSize = 0;
            this.btnWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWishlist.ForeColor = System.Drawing.Color.Transparent;
            this.btnWishlist.Location = new System.Drawing.Point(1070, 24);
            this.btnWishlist.Margin = new System.Windows.Forms.Padding(0);
            this.btnWishlist.Name = "btnWishlist";
            this.btnWishlist.Size = new System.Drawing.Size(62, 64);
            this.btnWishlist.TabIndex = 4;
            this.btnWishlist.UseVisualStyleBackColor = false;
            this.btnWishlist.Click += new System.EventHandler(this.btnWishlist_Click);
            // 
            // btnDM
            // 
            this.btnDM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.btnDM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDM.BackgroundImage")));
            this.btnDM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDM.FlatAppearance.BorderSize = 0;
            this.btnDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDM.ForeColor = System.Drawing.Color.Transparent;
            this.btnDM.Location = new System.Drawing.Point(1148, 31);
            this.btnDM.Margin = new System.Windows.Forms.Padding(0);
            this.btnDM.Name = "btnDM";
            this.btnDM.Size = new System.Drawing.Size(54, 44);
            this.btnDM.TabIndex = 3;
            this.btnDM.UseVisualStyleBackColor = false;
            this.btnDM.Click += new System.EventHandler(this.btnDM_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.btnProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProfile.BackgroundImage")));
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnProfile.Location = new System.Drawing.Point(1224, 28);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(48, 47);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.BackgroundImage")));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuit.Location = new System.Drawing.Point(1296, 30);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(57, 52);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnChair
            // 
            this.btnChair.BackColor = System.Drawing.Color.Transparent;
            this.btnChair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChair.BackgroundImage")));
            this.btnChair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChair.FlatAppearance.BorderSize = 0;
            this.btnChair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChair.ForeColor = System.Drawing.Color.Transparent;
            this.btnChair.Location = new System.Drawing.Point(98, 416);
            this.btnChair.Margin = new System.Windows.Forms.Padding(0);
            this.btnChair.Name = "btnChair";
            this.btnChair.Size = new System.Drawing.Size(287, 456);
            this.btnChair.TabIndex = 0;
            this.btnChair.UseVisualStyleBackColor = false;
            this.btnChair.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // pbHomepage
            // 
            this.pbHomepage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHomepage.BackgroundImage")));
            this.pbHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHomepage.Location = new System.Drawing.Point(0, 0);
            this.pbHomepage.Name = "pbHomepage";
            this.pbHomepage.Size = new System.Drawing.Size(1440, 2778);
            this.pbHomepage.TabIndex = 0;
            this.pbHomepage.TabStop = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1440, 1024);
            this.Controls.Add(this.panelHomepage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1440, 1024);
            this.MinimumSize = new System.Drawing.Size(1440, 1024);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHomepage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHomepage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKursi;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelHomepage;
        private System.Windows.Forms.PictureBox pbHomepage;
        private System.Windows.Forms.Button btnChair;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnDM;
        private System.Windows.Forms.Button btnWishlist;
    }
}