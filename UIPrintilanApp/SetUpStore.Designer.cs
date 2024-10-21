namespace UIPrintilanApp
{
    partial class SetUpStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetUpStore));
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnSetUpStore = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnEditProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditProfile.Location = new System.Drawing.Point(123, 167);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(177, 39);
            this.btnEditProfile.TabIndex = 2;
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnSetUpStore
            // 
            this.btnSetUpStore.BackColor = System.Drawing.Color.Transparent;
            this.btnSetUpStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetUpStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUpStore.ForeColor = System.Drawing.Color.Transparent;
            this.btnSetUpStore.Location = new System.Drawing.Point(614, 797);
            this.btnSetUpStore.Name = "btnSetUpStore";
            this.btnSetUpStore.Size = new System.Drawing.Size(209, 82);
            this.btnSetUpStore.TabIndex = 3;
            this.btnSetUpStore.UseVisualStyleBackColor = false;
            this.btnSetUpStore.Click += new System.EventHandler(this.btnSetUpStore_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuit.Location = new System.Drawing.Point(1334, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(55, 82);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // SetUpProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 1024);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSetUpStore);
            this.Controls.Add(this.btnEditProfile);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetUpProfile";
            this.Text = "SetUpProfile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnSetUpStore;
        private System.Windows.Forms.Button btnQuit;
    }
}