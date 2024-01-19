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
        private List<Post> m_Posts;
        private const string k_FormName = "Posts";
        public PostsForm()
        {
            InitializeComponent();
        }
        public PostsForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoginResult.LoggedInUser;
            m_Posts = new List<Post>();
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
            fetchPostsListBox();
        }

        private void fetchPostsListBox()
        {
            listBoxPosts.Items.Clear();
            foreach (Post post in m_LoggedInUser.Posts)
            {
                m_Posts.Add(post);
                addPost(post);
            }
            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No posts");
            }
        }

        private void fetchPostsByDate()
        {
            listBoxPosts.Items.Clear();
            if (numericUpDownMonth.Value == 0)
            {
                fetchPostsIfMonthIsZero();
            }
            else if (numericUpDownDay.Value == 0)
            {
                fetchPostsIfDayIsZero();
            }
            else
            {
                foreach (Post post in m_Posts)
                {
                    if (post.CreatedTime.Value.Day == numericUpDownDay.Value && post.CreatedTime.Value.Month == numericUpDownMonth.Value
                        && post.CreatedTime.Value.Year == numericUpDownYear.Value)
                    {
                        addPost(post);
                    }
                }
                if (listBoxPosts.Items.Count == 0)
                {
                    MessageBox.Show("No posts in this date");
                }
            }
        }
        private void fetchPostsIfDayIsZero()
        {

            foreach (Post post in m_Posts)
            {
                if (post.CreatedTime.Value.Month == numericUpDownMonth.Value && post.CreatedTime.Value.Year == numericUpDownYear.Value)
                {
                    addPost(post);
                }
            }
            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No posts in this month and year");
            }
        }
        private void fetchPostsIfMonthIsZero()
        {
            foreach (Post post in m_Posts)
            {
                if (post.CreatedTime.Value.Year == numericUpDownYear.Value)
                {
                    addPost(post);
                }
            }
            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No posts in this year");
            }
        }
        private void addPost(Post i_Post)
        { 
        
            listBoxPosts.Items.Add(i_Post.CreatedTime.ToString() + "\t" + i_Post.ToString());
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

        private void buttonFilterByDate_Click(object sender, EventArgs e)
        {
            fetchPostsByDate();
        }

        private void numericUpDownMonth_ValueChanged(object sender, EventArgs e)
        {
            ifMonthIsZeroDayIsZero();
        }
        private void numericUpDownDay_ValueChanged(object sender, EventArgs e)
        {
            ifMonthIsZeroDayIsZero();
        }
        private void ifMonthIsZeroDayIsZero()
        {
            if (numericUpDownMonth.Value == 0)
            {
                numericUpDownDay.Value = 0;
            }
        }
    }
}
