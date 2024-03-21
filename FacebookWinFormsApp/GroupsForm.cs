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
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class GroupsForm : Form
    {
        private const string k_FormName = "Groups";
        private bool m_Accessible = true;
        public User LoggedInUser { get; }
        public GroupsForm()
        {
            InitializeComponent();
        }
        public GroupsForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            LoggedInUser = i_LoginResult.LoggedInUser;
        }
        private void initialzeData()
        {
            labelHeadline.Invoke(new Action(() => labelHeadline.Text = k_FormName));
            labelName.Invoke(new Action (() => labelName.Text = LoggedInUser.Name));
            pictureBoxProfile.Invoke(new Action(() =>pictureBoxProfile.ImageLocation = LoggedInUser.PictureNormalURL));
            try
            {
                labelActualNumber.Invoke(new Action(() => labelActualNumber.Text = LoggedInUser.Groups.Count.ToString()));
            }
            catch (Facebook.FacebookOAuthException oAuthExceotion)
            {
                m_Accessible = false;
                MessageBox.Show($"There is no access for {LoggedInUser.Name}'s groups");
            }
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchData).Start();
        }
        private void fetchData()
        {
            initialzeData();
            if (m_Accessible)
            {
                fetchGroupsListBox();
            }
            else
            {
                this.Close();
            }
        }
        private void fetchGroupsListBox()
        {
            listBoxGroups.Invoke(new Action(listBoxGroups.Items.Clear));
            foreach(Group group in LoggedInUser.Groups)
            {
                listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add(group)));
            }
            if(listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show($"No groups for {LoggedInUser.Name}");
            }
        }
    }
}
