using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    public partial class FriendsForm : Form
    {
        private User m_LoggedInUser;
        private const string k_FormName = "Friends";
        private bool m_Accessible = true;
        public FriendsForm()
        {
            InitializeComponent();
        }
        public FriendsForm(LoginResult i_LoginResulr)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoginResulr.LoggedInUser;
            InitializeFormAppearance();
        }

        private void InitializeFormAppearance()
        {
            labelHeadline.Location = new System.Drawing.Point(ClientSize.Width / 2 - labelHeadline.Size.Width / 2 + 1, 100);
            labelNumberOfFriends.Top = labelHeadline.Bottom + 10;
            listBoxFriends.Location = new System.Drawing.Point(ClientSize.Width / 2 - listBoxFriends.Size.Width / 2 + 1, labelNumberOfFriends.Bottom + 1);
            labelNumberOfFriends.Left = listBoxFriends.Left;
            labelActualNumber.Left = labelNumberOfFriends.Right;
            labelActualNumber.Top = labelNumberOfFriends.Top;
        }

        private void initialzeData()
        {
            labelHeadline.Text = k_FormName;
            labelName.Text = m_LoggedInUser.Name;
            pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureNormalURL;
            try
            {
                labelActualNumber.Text = m_LoggedInUser.FriendLists.Count.ToString();
            }
            catch (Exception ex)
            {
                m_Accessible = false;
                MessageBox.Show($"There is no access for {m_LoggedInUser.Name}'s friends");
            }
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            initialzeData();
            if (m_Accessible)
            {
                fetchFriendsListBox();
            }
            else
            {
                this.Close();
            }
        }
        private void fetchFriendsListBox()
        {
            listBoxFriends.Items.Clear();
            foreach (FriendList friend in m_LoggedInUser.FriendLists)
            {
                listBoxFriends.Items.Add(friend);
            }
            if (listBoxFriends.Items.Count == 0)
            {
                MessageBox.Show($"No friends for {m_LoggedInUser.Name}");
            }
        }
    }
}
