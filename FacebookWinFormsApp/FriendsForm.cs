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
        private bool m_Accessible = true;
        public User LoggedInUser { get; }
        private const string k_FormName = "Friends";
        private const int k_FriendsMaxChoice = 2;

        //private void generateDummyFriends()
        //{
        //    User friend1 = new User();
        //    friend1.Birthday = "27/03/1997";
        //    friend1.FirstName = "Eli";
        //    friend1.LastName = "Kopter";
        //    friend1.Name = "Eli Kopter";
        //    friend1.LikedPages = new FacebookObjectCollection<Page> { LoggedInUser.LikedPages[0], LoggedInUser.LikedPages[1] };
        //    LoggedInUser.Friends.Add(friend1);
        //}


        public FriendsForm()
        {
            InitializeComponent();
        }
        public FriendsForm(LoginResult i_LoginResulr)
        {
            InitializeComponent();
            LoggedInUser = i_LoginResulr.LoggedInUser;
        }

        private void initialzeData()
        {
            labelHeadline.Text = k_FormName;
            labelName.Text = LoggedInUser.Name;
            pictureBoxProfile.ImageLocation = LoggedInUser.PictureNormalURL;
            groupBoxCompetitionResult.Location = groupBoxStartCompetition.Location;
            try
            {
                labelActualNumber.Text = LoggedInUser.Friends.Count.ToString();
            }
            catch (Facebook.FacebookOAuthException oAuthExceotion)
            {
                m_Accessible = false;
                MessageBox.Show($"There is no access for {LoggedInUser.Name}'s friends");
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
            foreach (User friend in LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend);
                listBoxFriends.Items.Add("moshe");
                listBoxFriends.Items.Add("David");
                listBoxFriends.Items.Add("Haim");


            }
            if (listBoxFriends.Items.Count == 0)
            {
                MessageBox.Show($"No friends for {LoggedInUser.Name}");
            }


        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItems.Count > k_FriendsMaxChoice)
            {
                listBoxFriends.SelectedIndices.Remove(listBoxFriends.SelectedIndices[listBoxFriends.SelectedItems.Count - 1]);
            }

        }

        private void buttonStartCompare_Click(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItems.Count < k_FriendsMaxChoice)
            {
                MessageBox.Show($"You must choose {k_FriendsMaxChoice} friends from the list.");
                return;
            }

            groupBoxStartCompetition.Visible = false;

            FriendsCompetition competition = new FriendsCompetition(
                LoggedInUser,
                listBoxFriends.SelectedItems[0] as User,
                listBoxFriends.SelectedItems[1] as User,
                checkBoxLikedPages.Checked,
                checkBoxGroups.Checked,
                checkBoxFriends.Checked
                );

            labelWinnerName.Text = competition.Compete().Name;
            labelFriendAName.Text = competition.FriendA.Name;
            labelFriendAName.Text = competition.FriendB.Name;

            if (checkBoxFriends.Checked)
            {
                labelFriendsVal1.Text = competition.ClosenessOfUserAndA.MutualFriends.ToString();
                labelFriendsVal2.Text = competition.ClosenessOfUserAndB.MutualFriends.ToString();
            }

            if (checkBoxLikedPages.Checked)
            {
                labelLikedPagesVal1.Text = competition.ClosenessOfUserAndA.MutualLikedPages.ToString();
                labelLikedPagesVal2.Text = competition.ClosenessOfUserAndB.MutualLikedPages.ToString();
            }

            if (checkBoxGroups.Checked)
            {
                labelGroupsVal2.Text = competition.ClosenessOfUserAndB.MutualGroups.ToString();
                labelGroupsVal1.Text = competition.ClosenessOfUserAndA.MutualGroups.ToString();
            }

            groupBoxCompetitionResult.Visible = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            groupBoxCompetitionResult.Visible = false;
            groupBoxStartCompetition.Visible = true;
            listBoxFriends.SelectedItems.Clear();
        }
    }
}
