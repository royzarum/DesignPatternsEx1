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
    public partial class PostsForm : Form
    {
        private User m_LoggedInUser;
        private Post[] m_Posts;
        private const string k_FormName = "Posts";
        public PostsForm()
        {
            InitializeComponent();
        }
        public PostsForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
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
            if(listBoxPosts.Items.Count == 0)
            {
                fetchPostsListBox();
            }
        }

        private void fetchPostsListBox()
        {
            listBoxPosts.Items.Clear();
            foreach (Post post in m_LoggedInUser.Posts)
            {
                listBoxPosts.Items.Add(post.CreatedTime.ToString() + "\t" + post.ToString());
            }
            if(listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No posts");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if(textBoxPost.Text != "")
            {
                listBoxPosts.Items.Add(DateTime.Now.ToString() + "\t" + textBoxPost.Text);
            }
        }
    }
}
