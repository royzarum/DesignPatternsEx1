﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing.Text;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        AppSettings m_AppSettings = AppSettings.LoadFromFile();
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;           
        }

        FacebookWrapper.LoginResult m_LoginResult;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("royzarum");
            m_AppSettings.RememberMe = checkBoxRememberMe.Checked;
            if (m_LoginResult == null)
            {
                login();
            }
            checkIfRememberMe();
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
                /// (This is Desig Patter's App ID. replace it with your own)
                "1551435755672177",
                /// requested permissions:
                "email",
                "public_profile",
                "user_photos",
                "user_birthday",
                "user_likes",
                "user_friends",
                "user_posts",
                "user_gender"
                //"user_groups"
                /// add any relevant permissions  
                );


            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                populateUIFromFacebookData();
            }
        }
        private void populateUIFromFacebookData()
        {
            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            buttonLogin.BackColor = Color.LightGreen;
            pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            changeVisibility();
            UserBirthdayLabel.Text = m_LoginResult.LoggedInUser.Birthday.ToString();
            UserGenderLabel.Text = m_LoginResult.LoggedInUser?.Gender.ToString();
        }

        private void changeVisibility()
        {
            BirthdayLabel.Visible = !BirthdayLabel.Visible;
            GenderLabel.Visible = !GenderLabel.Visible;
            UserBirthdayLabel.Visible = !UserBirthdayLabel.Visible;
            UserGenderLabel.Visible = !UserGenderLabel.Visible;
            pictureBoxProfile.Visible = !pictureBoxProfile.Visible;
            pictureBoxLogo.Visible = !pictureBoxLogo.Visible;
            buttonAlbums.Visible = !buttonAlbums.Visible;
            buttonFriends.Visible = !buttonFriends.Visible;
            buttonGroups.Visible = !buttonGroups.Visible;
            buttonPages.Visible = !buttonPages.Visible;
            buttonPosts.Visible = !buttonPosts.Visible;
            checkBoxRememberMe.Visible = !checkBoxRememberMe.Visible;
            buttonLogout.Visible = !buttonLogout.Visible;
        }
        private void checkIfRememberMe()
        {
            if (checkBoxRememberMe.Checked)
            {
                m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                m_AppSettings.LastAccessToken = null;
            }
            new Thread(m_AppSettings.SaveToFile).Start();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (m_AppSettings.RememberMe && !String.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                populateUIFromFacebookData();
            }
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            m_AppSettings.LastAccessToken = null;
            m_AppSettings.RememberMe = false;
            changeVisibility();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            m_AppSettings.SaveToFile();
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            PostsForm postsForm = new PostsForm(m_LoginResult);
            postsForm.Show();
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            AlbumsForm albumsForm = new AlbumsForm(m_LoginResult);
            albumsForm.Show();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            GroupsForm groupsForm = new GroupsForm(m_LoginResult);
            groupsForm.Show();
        }
        private void buttonFriends_Click(object sender, EventArgs e)
        {
            FriendsForm friendsForm = new FriendsForm(m_LoginResult);
            friendsForm.Show();
        }
        private void buttonPages_Click(object sender, EventArgs e)
        {
            LikedPagesForm pagesForm = new LikedPagesForm(m_LoginResult);
            pagesForm.Show();
        }
    }
}