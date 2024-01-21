using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class LikedPagesForm : Form
    {
        private LoginResult m_LogginResult;
        private User m_LoggedInUser;
        private const string k_HeadLineComplition = "'s Liked Pages";
        private const string k_UnknownValueString = "Unknown";
        private const string k_TextBoxDefaultText = "Search Here";
        private const string k_TextBoxNotAccessible = "No access to pages categories";
        private bool m_Accesible = true;
        private bool m_TextBoxHasBeenChecked = false;


        public LikedPagesForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            m_LogginResult = i_LoginResult;
            m_LoggedInUser = i_LoginResult.LoggedInUser;
            try
            {
                labelNumberOfPagesValue.Text = m_LoggedInUser.LikedPages.Count.ToString();
            }
            catch (Exception ex)
            {
                m_Accesible = false;
                MessageBox.Show($"There is no access to {m_LoggedInUser.Name}'s liked pages");
            }

            initializeFormAppearance();
        }

        private void initializeFormAppearance()
        {

            labelHeadline.Text = m_LoggedInUser.FirstName + k_HeadLineComplition;
            labelNumberOfPages.Location = new System.Drawing.Point(
                labelHeadline.Right + 20,
                labelHeadline.Bottom - labelNumberOfPages.Height
                );
            labelNumberOfPagesValue.Location = new System.Drawing.Point(
                labelNumberOfPages.Right,
                labelNumberOfPages.Bottom - labelNumberOfPages.Height
                );
            listBoxLikedPages.Width = labelHeadline.Left + labelNumberOfPagesValue.Right;
            labelInformationTitle.Left =
                 labelName.Left =
                 labelLikes.Left =
                 labelCategory.Left =
                 labelPhoneNumber.Left = listBoxLikedPages.Right + 15;
            labelLikedPageName.Left = labelName.Right;
            labelLikesCount.Left = labelLikes.Right;
            labelPageCategoryValue.Left = labelCategory.Right;
            labelPhoneValue.Left = labelPhoneNumber.Right;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (m_Accesible)
            {
                fetchLikedPages();
            }
            else
            {
                this.Close();
            }
        }

        private void fetchLikedPages()
        {
            bool categoryAccessible = false;
            if (m_LoggedInUser != null)
            {
                labelNumberOfPagesValue.Text = m_LoggedInUser.LikedPages.Count.ToString();
                foreach (Page likedPage in m_LoggedInUser.LikedPages)
                {
                    fetchPage(likedPage);
                    if(likedPage.Category != null)
                    {
                        categoryAccessible = true;
                    }
                }
                if(!categoryAccessible)
                {
                    textBoxSearchByCategory.Text = k_TextBoxNotAccessible;
                    textBoxSearchByCategory.Enabled = false;
                }
            }
        }
        private void fetchPage(Page i_Page)
        {
            listBoxLikedPages.Items.Add(i_Page);
            listBoxLikedPages.DisplayMember = "Name";
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page selectedLikedPage = listBoxLikedPages.SelectedItem as Page;
            if (selectedLikedPage != null)
            {
                labelLikedPageName.Text = selectedLikedPage.Name;
                labelLikesCount.Text = selectedLikedPage.LikesCount != null ? selectedLikedPage.LikesCount.ToString() : k_UnknownValueString;
                labelPageCategoryValue.Text = selectedLikedPage.Category != null ? selectedLikedPage.Category : k_UnknownValueString;
                labelPhoneValue.Text = selectedLikedPage.Phone != null ? selectedLikedPage.Phone : k_UnknownValueString;
                pictureBoxLikedPageLogo.Image = selectedLikedPage.ImageNormal;
            }

        }

        private void textBoxSearchByCategory_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchByCategory.Text != string.Empty && textBoxSearchByCategory.Text != k_TextBoxNotAccessible)
            {
                listBoxLikedPages.Items.Clear();
                foreach (Page likedPage in m_LoggedInUser.LikedPages)
                {
                    if (likedPage.Category.TrimStart().ToLower().Contains(textBoxSearchByCategory.Text.ToLower()))
                    {
                        fetchPage(likedPage);
                    }
                }
            }
        }
        private void textBoxSearchByCategory_Enter(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            box.Text = box.Text.TrimStart();
            if (!m_TextBoxHasBeenChecked)
            { 
                box.Text = string.Empty;
                m_TextBoxHasBeenChecked = true;
            }
        }
        private void textBoxSearchByCategory_Leave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            box.Text = box.Text.TrimStart();
            if (textBoxSearchByCategory.Text == string.Empty)
            {
                box.Text = k_TextBoxDefaultText;
                m_TextBoxHasBeenChecked = false;
            }
        }
    }
}
