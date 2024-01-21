using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class PostsForm : Form
    {
        private User m_LoggedInUser;
        private List<Tuple<DateTime, String>> m_PostsCreatedTimeAndText;
        private const string k_FormName = "Posts";
        private const string k_Zero = "0";
        private const string k_NoPostInDate = "No posts in this date";
        private const string k_NoPostInMonth = "No posts in this year and month";
        private const string k_NoPostInYear = "No posts in this year";
        private bool m_Accessible = true;
        public PostsForm()
        {
            InitializeComponent();
        }
        public PostsForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoginResult.LoggedInUser;
            m_PostsCreatedTimeAndText = new List<Tuple<DateTime, String>>();
            this.MinimumSize = new System.Drawing.Size(pictureBoxLogo.Right + 10, labelDayIsZero.Bottom + 50);
        }
        private void initialzeData()
        {
            labelHeadline.Text = k_FormName;
            labelName.Text = m_LoggedInUser.Name;
            pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureNormalURL;
            try
            {
                labelActualNumber.Text = m_LoggedInUser.Posts.Count.ToString();
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
            if (m_Accessible)
            {
                fetchPostsListBox();
            }
            else
            {
                this.Close();
            }
        }
        private void fetchPostsListBox()
        {
            listBoxPosts.Items.Clear();
            foreach (Post post in m_LoggedInUser.Posts)
            {
                Tuple<DateTime, String> tuplePost = Tuple.Create(post.CreatedTime.Value, post.Message);
                m_PostsCreatedTimeAndText.Add(tuplePost);
                addPostToListBox(tuplePost);
            }
            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show($"No posts for {m_LoggedInUser.Name}");
            }
        }
        private void fetchPostsByDate() //first feature we add
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
                foreach (Tuple<DateTime, String> post in m_PostsCreatedTimeAndText)
                {
                    if (post.Item1.Day == numericUpDownDay.Value && post.Item1.Month == numericUpDownMonth.Value
                        && post.Item1.Year == numericUpDownYear.Value)
                    {
                        addPostToListBox(post);
                    }
                }
                updateListBoxPosts(k_NoPostInDate);
            }
        }
        private void fetchPostsIfDayIsZero()
        {

            foreach (Tuple<DateTime, String> post in m_PostsCreatedTimeAndText)
            {
                if (post.Item1.Month == numericUpDownMonth.Value && post.Item1.Year == numericUpDownYear.Value)
                {
                    addPostToListBox(post);
                }
            }
            updateListBoxPosts(k_NoPostInMonth);
        }
        private void fetchPostsIfMonthIsZero()
        {
            foreach (Tuple<DateTime, String> post in m_PostsCreatedTimeAndText)
            {
                if (post.Item1.Year == numericUpDownYear.Value)
                {
                    addPostToListBox(post);
                }
            }
            updateListBoxPosts(k_NoPostInYear);
        }
        private void updateListBoxPosts(string i_Message)
        {
            if (listBoxPosts.Items.Count == 0)
            {
                labelActualNumber.Text = k_Zero;
                MessageBox.Show(i_Message);
            }
            else
            {
                labelActualNumber.Text = listBoxPosts.Items.Count.ToString();
            }
        }
        private void addPostToListBox(Tuple<DateTime, String> i_Post)
        {

            listBoxPosts.Items.Add($"{i_Post.Item1.ToString()}\t{i_Post.Item2}");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void buttonPost_Click(object sender, EventArgs e)
        {
            if(textBoxPost.Text != "")
            {
                Tuple<DateTime, String> post = Tuple.Create(DateTime.Now, textBoxPost.Text);
                addPostToListBox(post);
                m_PostsCreatedTimeAndText.Add(post);
                labelActualNumber.Text = (int.Parse(labelActualNumber.Text) + 1).ToString();
                textBoxPost.Clear();
                cancelFilter();
                listBoxPosts.TopIndex = m_PostsCreatedTimeAndText.Count - 1;
            }
        }
        private void buttonFilterByDate_Click(object sender, EventArgs e) //first feature we add
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
        private void buttonCancelFilter_Click(object sender, EventArgs e)
        {
            cancelFilter();
        }
        private void cancelFilter()
        {
            listBoxPosts.Items.Clear();
            foreach (Tuple<DateTime, String> post in m_PostsCreatedTimeAndText)
            {
                addPostToListBox(post);
            }
            labelActualNumber.Text = m_PostsCreatedTimeAndText.Count.ToString();
        }
        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxPosts.SelectedIndex != -1)
            {
                string selectedItem = listBoxPosts.SelectedItem.ToString();
                MessageBox.Show(selectedItem);
            }
            
        }
    }
}
