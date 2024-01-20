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
    public partial class GroupsForm : Form
    {
        private User m_LoggedInUser;
        private const string k_FormName = "Groups";
        private bool m_Accessible = true;
        public GroupsForm()
        {
            InitializeComponent();
        }
        public GroupsForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoginResult.LoggedInUser;
        }
        private void initialzeData()
        {
            headLine.Text = k_FormName;
            labelName.Text = m_LoggedInUser.Name;
            pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureNormalURL;
            try
            {
                labelActualNumber.Text = m_LoggedInUser.Groups.Count.ToString();
            }
            catch (Exception ex)
            {
                m_Accessible = false;
                MessageBox.Show($"There is no access for {m_LoggedInUser.Name}'s groups");
            }
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            initialzeData();
            if(m_Accessible)
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
            listBoxGroups.Items.Clear();
            foreach(Group group in m_LoggedInUser.Groups)
            {
                listBoxGroups.Items.Add(group);
            }
            if(listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show($"No groups for {m_LoggedInUser.Name}");
            }
        }
    }
}
