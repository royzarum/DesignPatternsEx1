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
using System.Threading;


namespace BasicFacebookFeatures
{
    public partial class FriendsForm : Form
    {
        private bool m_Accessible = true;
        public User LoggedInUser { get; }
        private const string k_FormName = "Friends";
        private const int k_FriendsMaxChoice = 2;

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
            labelHeadline.Invoke(new Action(() => labelHeadline.Text = k_FormName));
            labelName.Invoke(new Action(() => labelName.Text = LoggedInUser.Name));
            pictureBoxProfile.Invoke(new Action(()=> pictureBoxProfile.ImageLocation = LoggedInUser.PictureNormalURL));
            groupBoxCompetitionResult.Invoke(new Action(() => groupBoxCompetitionResult.Location = groupBoxStartCompetition.Location));
            try
            {
                labelActualNumber.Invoke(new Action(() => labelActualNumber.Text = LoggedInUser.Friends.Count.ToString()));
            }
            catch (Facebook.FacebookOAuthException oAuthExceotion)
            {
                m_Accessible = false;
                MessageBox.Show($"There is no access for {LoggedInUser.Name}'s friends");
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            new Thread(fetchData).Start();
        }
        private void fetchData()
        {
            initialzeData();
            if (m_Accessible)
            {
                fetchFriendsListBox();
            }
            else
            {
                Invoke(new Action(() => this.Close()));
            }
        }

        private void fetchFriendsListBox()
        {
            listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Clear()));
            foreach (User friend in LoggedInUser.Friends)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));
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
