namespace UIPrintilanApp
{
    partial class Profile_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_Page));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSetUpProfile = new System.Windows.Forms.Button();
            this.txtboxNewUsername = new System.Windows.Forms.TextBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.txtboxNewPassword = new System.Windows.Forms.TextBox();
            this.txtboxNewEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(1162, 665);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 65);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSetUpProfile
            // 
            this.btnSetUpProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnSetUpProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetUpProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUpProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnSetUpProfile.Location = new System.Drawing.Point(328, 150);
            this.btnSetUpProfile.Name = "btnSetUpProfile";
            this.btnSetUpProfile.Size = new System.Drawing.Size(177, 39);
            this.btnSetUpProfile.TabIndex = 1;
            this.btnSetUpProfile.UseVisualStyleBackColor = false;
            this.btnSetUpProfile.Click += new System.EventHandler(this.btnSetUpProfile_Click);
            // 
            // txtboxNewUsername
            // 
            this.txtboxNewUsername.Location = new System.Drawing.Point(330, 282);
            this.txtboxNewUsername.Name = "txtboxNewUsername";
            this.txtboxNewUsername.Size = new System.Drawing.Size(352, 26);
            this.txtboxNewUsername.TabIndex = 2;
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.Transparent;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnOut.Location = new System.Drawing.Point(1338, 23);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(68, 39);
            this.btnOut.TabIndex = 3;
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // txtboxNewPassword
            // 
            this.txtboxNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxNewPassword.Location = new System.Drawing.Point(328, 376);
            this.txtboxNewPassword.Name = "txtboxNewPassword";
            this.txtboxNewPassword.Size = new System.Drawing.Size(354, 26);
            this.txtboxNewPassword.TabIndex = 4;
            // 
            // txtboxNewEmail
            // 
            this.txtboxNewEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxNewEmail.Location = new System.Drawing.Point(328, 461);
            this.txtboxNewEmail.Name = "txtboxNewEmail";
            this.txtboxNewEmail.Size = new System.Drawing.Size(354, 26);
            this.txtboxNewEmail.TabIndex = 5;
            // 
            // Profile_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 922);
            this.Controls.Add(this.txtboxNewEmail);
            this.Controls.Add(this.txtboxNewPassword);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.txtboxNewUsername);
            this.Controls.Add(this.btnSetUpProfile);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1440, 1024);
            this.MinimumSize = new System.Drawing.Size(1440, 838);
            this.Name = "Profile_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSetUpProfile;
        private System.Windows.Forms.TextBox txtboxNewUsername;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.TextBox txtboxNewPassword;
        private System.Windows.Forms.TextBox txtboxNewEmail;
    }
}