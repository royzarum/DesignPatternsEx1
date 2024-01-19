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
        public GroupsForm()
        {
            InitializeComponent();
        }
        public GroupsForm(LoginResult i_LoginResult) : this() 
        {
            m_LoggedInUser = i_LoginResult.LoggedInUser;
            initialzeData();
        }
        private void initialzeData()
        {
            headLine.Text = k_FormName;
            labelName.Text = m_LoggedInUser.Name;
            pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureNormalURL;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchGroupsListBox();
        }
        private void fetchGroupsListBox()
        {
            foreach(Group group in m_LoggedInUser.Groups)
            {
                listBoxGroups.Items.Add(group);
            }
            if(listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups");
            }
        }
    }
}
