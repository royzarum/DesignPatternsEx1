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
        private bool m_Accesible = true;


        public LikedPagesForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            m_LogginResult = i_LoginResult;
            m_LoggedInUser = i_LoginResult.LoggedInUser;
            labelHeadline.Text = m_LoggedInUser.FirstName + k_HeadLineComplition;
            try
            {
                
            }
            catch(Exception ex)
            {
                m_Accesible = false;
                MessageBox.Show($"No access to {m_LoggedInUser.Name} liked pages");
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            if (m_LoggedInUser != null)
            {
                labelNumberOfPagesValue.Text = m_LoggedInUser.LikedPages.Count.ToString();
                foreach (Page likedPage in m_LoggedInUser.LikedPages)
                {
                    listBoxLikedPages.Items.Add(likedPage);
                    listBoxLikedPages.DisplayMember = "Name";
                }
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page selectedLikedPage = listBoxLikedPages.SelectedItem as Page;
            if (selectedLikedPage != null)
            {
                labelLikedPageName.Text = selectedLikedPage.Name;
                labelLikesCount.Text = selectedLikedPage.LikesCount != null ? selectedLikedPage.LikesCount.ToString() : k_UnknownValueString;
                labelPageCategoryValue.Text = selectedLikedPage.Category != null ? selectedLikedPage.Category : k_UnknownValueString;
                lablePhoneValue.Text = selectedLikedPage.Phone != null ? selectedLikedPage.Phone : k_UnknownValueString;
                pictureBoxLikedPageLogo.Image = selectedLikedPage.ImageNormal;
            }

        }

    }
}
