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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonPages = new System.Windows.Forms.Button();
            this.UserBirthdayLabel = new System.Windows.Forms.Label();
            this.UserGenderLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formsButtonsPanel = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.formsButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(586, 358);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(86, 31);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMainPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 431);
            this.tabControl1.TabIndex = 54;
            // 
            // tabMainPage
            // 
            this.tabMainPage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabMainPage.Controls.Add(this.checkBoxRememberMe);
            this.tabMainPage.Controls.Add(this.pictureBoxLogo);
            this.tabMainPage.Controls.Add(this.UserBirthdayLabel);
            this.tabMainPage.Controls.Add(this.UserGenderLabel);
            this.tabMainPage.Controls.Add(this.GenderLabel);
            this.tabMainPage.Controls.Add(this.BirthdayLabel);
            this.tabMainPage.Controls.Add(this.pictureBoxProfile);
            this.tabMainPage.Controls.Add(this.buttonLogout);
            this.tabMainPage.Controls.Add(this.buttonLogin);
            this.tabMainPage.Controls.Add(this.formsButtonsPanel);
            this.tabMainPage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabMainPage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMainPage.Location = new System.Drawing.Point(4, 31);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainPage.Size = new System.Drawing.Size(686, 396);
            this.tabMainPage.TabIndex = 0;
            this.tabMainPage.Text = "Main Page";
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(79, 56);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(165, 26);
            this.checkBoxRememberMe.TabIndex = 67;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo_20231;
            this.pictureBoxLogo.Location = new System.Drawing.Point(572, 6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 66;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Visible = false;
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGroups.Location = new System.Drawing.Point(205, 76);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(179, 52);
            this.buttonGroups.TabIndex = 65;
            this.buttonGroups.Text = "Groups";
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Visible = false;
            // 
            // buttonPosts
            // 
            this.buttonPosts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPosts.Location = new System.Drawing.Point(20, 20);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Size = new System.Drawing.Size(179, 48);
            this.buttonPosts.TabIndex = 64;
            this.buttonPosts.Text = "Posts";
            this.buttonPosts.UseVisualStyleBackColor = false;
            this.buttonPosts.Visible = false;
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAlbums.Location = new System.Drawing.Point(20, 74);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(179, 51);
            this.buttonAlbums.TabIndex = 63;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.UseVisualStyleBackColor = false;
            this.buttonAlbums.Visible = false;
            // 
            // buttonFriends
            // 
            this.buttonFriends.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFriends.Location = new System.Drawing.Point(111, 134);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(179, 48);
            this.buttonFriends.TabIndex = 62;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = false;
            this.buttonFriends.Visible = false;
            // 
            // buttonPages
            // 
            this.buttonPages.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPages.Location = new System.Drawing.Point(205, 20);
            this.buttonPages.Name = "buttonPages";
            this.buttonPages.Size = new System.Drawing.Size(179, 50);
            this.buttonPages.TabIndex = 61;
            this.buttonPages.Text = "Liked Pages";
            this.buttonPages.UseVisualStyleBackColor = false;
            this.buttonPages.Visible = false;
            // 
            // UserBirthdayLabel
            // 
            this.UserBirthdayLabel.AutoSize = true;
            this.UserBirthdayLabel.Location = new System.Drawing.Point(93, 72);
            this.UserBirthdayLabel.Name = "UserBirthdayLabel";
            this.UserBirthdayLabel.Size = new System.Drawing.Size(86, 22);
            this.UserBirthdayLabel.TabIndex = 60;
            this.UserBirthdayLabel.Text = "1/1/2000";
            this.UserBirthdayLabel.Visible = false;
            // 
            // UserGenderLabel
            // 
            this.UserGenderLabel.AutoSize = true;
            this.UserGenderLabel.Location = new System.Drawing.Point(93, 90);
            this.UserGenderLabel.Name = "UserGenderLabel";
            this.UserGenderLabel.Size = new System.Drawing.Size(130, 22);
            this.UserGenderLabel.TabIndex = 59;
            this.UserGenderLabel.Text = "GenderValue";
            this.UserGenderLabel.Visible = false;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(21, 90);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(86, 22);
            this.GenderLabel.TabIndex = 58;
            this.GenderLabel.Text = "Gender:";
            this.GenderLabel.Visible = false;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(21, 72);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(96, 22);
            this.BirthdayLabel.TabIndex = 57;
            this.BirthdayLabel.Text = "Birthday:";
            this.BirthdayLabel.Visible = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.NullProfileImage;
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 141);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(207, 204);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Visible = false;
            // 
            // formsButtonsPanel
            // 
            this.formsButtonsPanel.Controls.Add(this.buttonPosts);
            this.formsButtonsPanel.Controls.Add(this.buttonPages);
            this.formsButtonsPanel.Controls.Add(this.buttonGroups);
            this.formsButtonsPanel.Controls.Add(this.buttonFriends);
            this.formsButtonsPanel.Controls.Add(this.buttonAlbums);
            this.formsButtonsPanel.Location = new System.Drawing.Point(256, 132);
            this.formsButtonsPanel.Name = "formsButtonsPanel";
            this.formsButtonsPanel.Size = new System.Drawing.Size(398, 213);
            this.formsButtonsPanel.TabIndex = 68;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 431);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Desktop";
            this.tabControl1.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            this.tabMainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.formsButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMainPage;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label UserBirthdayLabel;
        private System.Windows.Forms.Label UserGenderLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Button buttonPages;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Panel formsButtonsPanel;
    }
}