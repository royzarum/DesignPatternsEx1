namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UserBirthdayLabel = new System.Windows.Forms.Label();
            this.UserGenderLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonPages = new System.Windows.Forms.Button();
            this.ButtonFriends = new System.Windows.Forms.Button();
            this.ButtonAlbums = new System.Windows.Forms.Button();
            this.ButtonPosts = new System.Windows.Forms.Button();
            this.ButtonGroups = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 697);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButtonGroups);
            this.tabPage1.Controls.Add(this.ButtonPosts);
            this.tabPage1.Controls.Add(this.ButtonAlbums);
            this.tabPage1.Controls.Add(this.ButtonFriends);
            this.tabPage1.Controls.Add(this.ButtonPages);
            this.tabPage1.Controls.Add(this.UserBirthdayLabel);
            this.tabPage1.Controls.Add(this.UserGenderLabel);
            this.tabPage1.Controls.Add(this.GenderLabel);
            this.tabPage1.Controls.Add(this.BirthdayLabel);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 658);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UserBirthdayLabel
            // 
            this.UserBirthdayLabel.AutoSize = true;
            this.UserBirthdayLabel.Location = new System.Drawing.Point(735, 28);
            this.UserBirthdayLabel.Name = "UserBirthdayLabel";
            this.UserBirthdayLabel.Size = new System.Drawing.Size(96, 26);
            this.UserBirthdayLabel.TabIndex = 60;
            this.UserBirthdayLabel.Text = "1/1/2000";
            this.UserBirthdayLabel.Visible = false;
            // 
            // UserGenderLabel
            // 
            this.UserGenderLabel.AutoSize = true;
            this.UserGenderLabel.Location = new System.Drawing.Point(1067, 28);
            this.UserGenderLabel.Name = "UserGenderLabel";
            this.UserGenderLabel.Size = new System.Drawing.Size(140, 26);
            this.UserGenderLabel.TabIndex = 59;
            this.UserGenderLabel.Text = "GenderValue";
            this.UserGenderLabel.Visible = false;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(971, 28);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(90, 26);
            this.GenderLabel.TabIndex = 58;
            this.GenderLabel.Text = "Gender:";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(631, 28);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(98, 26);
            this.BirthdayLabel.TabIndex = 57;
            this.BirthdayLabel.Text = "Birthday:";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 96);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 658);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonPages
            // 
            this.ButtonPages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPages.Location = new System.Drawing.Point(610, 192);
            this.ButtonPages.Name = "ButtonPages";
            this.ButtonPages.Size = new System.Drawing.Size(133, 65);
            this.ButtonPages.TabIndex = 61;
            this.ButtonPages.Text = "Liked Pages";
            this.ButtonPages.UseVisualStyleBackColor = true;
            // 
            // ButtonFriends
            // 
            this.ButtonFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFriends.Location = new System.Drawing.Point(820, 192);
            this.ButtonFriends.Name = "ButtonFriends";
            this.ButtonFriends.Size = new System.Drawing.Size(133, 65);
            this.ButtonFriends.TabIndex = 62;
            this.ButtonFriends.Text = "Friends";
            this.ButtonFriends.UseVisualStyleBackColor = true;
            // 
            // ButtonAlbums
            // 
            this.ButtonAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAlbums.Location = new System.Drawing.Point(1030, 192);
            this.ButtonAlbums.Name = "ButtonAlbums";
            this.ButtonAlbums.Size = new System.Drawing.Size(133, 65);
            this.ButtonAlbums.TabIndex = 63;
            this.ButtonAlbums.Text = "Albums";
            this.ButtonAlbums.UseVisualStyleBackColor = true;
            // 
            // ButtonPosts
            // 
            this.ButtonPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPosts.Location = new System.Drawing.Point(425, 192);
            this.ButtonPosts.Name = "ButtonPosts";
            this.ButtonPosts.Size = new System.Drawing.Size(133, 65);
            this.ButtonPosts.TabIndex = 64;
            this.ButtonPosts.Text = "Posts";
            this.ButtonPosts.UseVisualStyleBackColor = true;
            this.ButtonPosts.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonGroups
            // 
            this.ButtonGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGroups.Location = new System.Drawing.Point(240, 192);
            this.ButtonGroups.Name = "ButtonGroups";
            this.ButtonGroups.Size = new System.Drawing.Size(133, 65);
            this.ButtonGroups.TabIndex = 65;
            this.ButtonGroups.Text = "Groups";
            this.ButtonGroups.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 697);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label UserBirthdayLabel;
        private System.Windows.Forms.Label UserGenderLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Button ButtonPages;
        private System.Windows.Forms.Button ButtonGroups;
        private System.Windows.Forms.Button ButtonPosts;
        private System.Windows.Forms.Button ButtonAlbums;
        private System.Windows.Forms.Button ButtonFriends;
    }
}