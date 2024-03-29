﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        public delegate R DateSelector<T1, T2, T3, T4, R>(T1 i_Param1, T2 i_Param2, T3 i_Param3, T4 i_Param4);
        private PostsDatesSaved m_DatesSavedInFile;
        private List<AppPost> m_Posts;
        private List<Tuple<string, DateTime>> m_DatesSaved;
        private const string k_FormName = "Posts";
        private const string k_Zero = "0";
        private const string k_NoPostInAvailable = "No posts available";
        private const string k_ComboBoxDefaultText = "Select Date";
        private bool m_Accessible = true;
        private bool m_Load = true;
        public User LoggedInUser { get; }
        private IPostsStrategy m_DatesStrategy = new IsPostInRange();
        private DateSelector<int, int, int, DateTime, bool> m_SelectorStrategy;
        public PostsForm()
        {
            InitializeComponent();
        }
        public PostsForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            LoggedInUser = i_LoginResult.LoggedInUser;
            m_Posts = new List<AppPost>();
            m_DatesSaved = new List<Tuple<string, DateTime>>();
            this.MinimumSize = new System.Drawing.Size(pictureBoxLogo.Right + 10, labelDayIsZero.Bottom + 50);
        }
        private void initialzeData()
        {
            m_DatesSavedInFile = PostsDatesSaved.LoadFromFile(LoggedInUser.Id);
            loadDateInformation();
            labelHeadline.Invoke(new Action(() =>labelHeadline.Text = k_FormName));
            labelName.Invoke(new Action(() => labelName.Text = LoggedInUser.Name));
            pictureBoxProfile.Invoke(new Action(() =>pictureBoxProfile.ImageLocation = LoggedInUser.PictureNormalURL));
            try
            {
                labelActualNumber.Invoke(new Action(() => labelActualNumber.Text = LoggedInUser.Posts.Count.ToString()));
            }
            catch (Facebook.FacebookOAuthException oAuthExceotion)
            {
                m_Accessible = false;
                MessageBox.Show($"There is no access for {LoggedInUser.Name}'s posts");
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
                fetchPostsListBox();
            }
            else
            {
                this.Close();
            }
            labelLoading.Invoke(new Action(() =>labelLoading.Visible = false));
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            saveDateInformation();
            new Thread(m_DatesSavedInFile.SaveToFile).Start();
        }
        private void saveDateInformation()
        {
            m_DatesSavedInFile.LastDay = numericUpDownDay.Value;
            m_DatesSavedInFile.LastMonth = numericUpDownMonth.Value;
            m_DatesSavedInFile.LastYear = numericUpDownYear.Value;
            m_DatesSavedInFile.UserId = LoggedInUser.Id;
            m_DatesSavedInFile.NamesSaved.Clear();
            m_DatesSavedInFile.DatesSaved.Clear();
            foreach (Tuple<string, DateTime> dateSaved in m_DatesSaved)
            {
                m_DatesSavedInFile.NamesSaved.Add(dateSaved.Item1);
                m_DatesSavedInFile.DatesSaved.Add(dateSaved.Item2);
            }
        }
        private void loadDateInformation()
        {
            if(m_DatesSavedInFile.LastDay >= numericUpDownDay.Minimum && m_DatesSavedInFile.LastDay <= numericUpDownDay.Maximum)
            {
                numericUpDownDay.Invoke(new Action(() => numericUpDownDay.Value = m_DatesSavedInFile.LastDay));
            }
            else
            {
                numericUpDownDay.Invoke(new Action(() => numericUpDownDay.Value -= numericUpDownDay.Minimum));
            }
            if (m_DatesSavedInFile.LastMonth >= numericUpDownMonth.Minimum && m_DatesSavedInFile.LastMonth <= numericUpDownMonth.Maximum)
            {
                numericUpDownMonth.Invoke(new Action(() => numericUpDownMonth.Value = m_DatesSavedInFile.LastMonth));
            }
            else
            {
                numericUpDownMonth.Invoke(new Action(() => numericUpDownMonth.Value -= numericUpDownMonth.Minimum));
            }
            if (m_DatesSavedInFile.LastYear >= numericUpDownYear.Minimum && m_DatesSavedInFile.LastYear <= numericUpDownYear.Maximum)
            {
                numericUpDownYear.Invoke(new Action(() => numericUpDownYear.Value = m_DatesSavedInFile.LastYear));
            }
            else
            {
                numericUpDownYear.Invoke(new Action(() => numericUpDownYear.Value = numericUpDownYear.Minimum));
            }
            if (m_DatesSavedInFile.DatesSaved != null && m_DatesSavedInFile.NamesSaved != null)
            {
                comboBoxSavedDates.Invoke(new Action(() => comboBoxSavedDates.Items.Clear()));
                for (int i = 0; i < m_DatesSavedInFile.NamesSaved.Count; i++)
                {
                    Tuple<string, DateTime> dateSaved = Tuple.Create(m_DatesSavedInFile.NamesSaved[i], m_DatesSavedInFile.DatesSaved[i]);
                    comboBoxSavedDates.Invoke(new Action(() => comboBoxSavedDates.Items.Add(dateSaved.Item1)));
                    m_DatesSaved.Add(dateSaved);
                }
            }
            m_Load = false;
        }
        private void fetchPostsListBox()
        {
            listBoxPosts.Invoke(new Action(listBoxPosts.Items.Clear));
            foreach (Post post in LoggedInUser.Posts)
            {
                AppPost postProxy = new AppPost(post.Message, (DateTime)post.CreatedTime);
                m_Posts.Add(postProxy);
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(postProxy)));
            }
            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show($"No posts for {LoggedInUser.Name}");
            }
        }
        private void selectDates(int i_Day, int i_Month, int i_Year)
        {
            listBoxPosts.Items.Clear();
            var filteredPostsByDate = from post in m_Posts
                                      where m_SelectorStrategy(i_Day, i_Month, i_Year, post.CreatedIn)
                                      select post;
            foreach (var post in filteredPostsByDate)
            {
                listBoxPosts.Items.Add(post);
            }
            updateListBoxPosts(k_NoPostInAvailable);
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
        private void buttonPost_Click(object sender, EventArgs e)
        {
            if(textBoxPost.Text != "")
            {
                AppPost post = new AppPost(textBoxPost.Text, DateTime.Now);
                listBoxPosts.Items.Add(post);
                m_Posts.Add(post);
                labelActualNumber.Text = (int.Parse(labelActualNumber.Text) + 1).ToString();
                textBoxPost.Clear();
                cancelFilter();
                listBoxPosts.TopIndex = m_Posts.Count - 1;
            }
        }
        private void buttonFilterByDate_Click(object sender, EventArgs e)
        {
            m_DatesStrategy = new IsPostInRange();
            activateSelector();
        }
        private void buttonOlderPosts_Click(object sender, EventArgs e)
        {
            m_DatesStrategy = new IsPostOlder();
            activateSelector();
        }
        private void activateSelector()
        {
            int year = int.Parse(numericUpDownYear.Value.ToString());
            int month = int.Parse(numericUpDownMonth.Value.ToString());
            int day = int.Parse(numericUpDownDay.Value.ToString());
            m_SelectorStrategy = m_DatesStrategy.Selector;
            selectDates(day, month, year);
        }
        private void numericUpDownMonth_ValueChanged(object sender, EventArgs e)
        {
            if(!m_Load)
            {
                ifMonthIsZeroDayIsZero();
            }
        }
        private void numericUpDownDay_ValueChanged(object sender, EventArgs e)
        {
            if(!m_Load)
            {
                ifMonthIsZeroDayIsZero();
            }
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
            comboBoxSavedDates.Text = k_ComboBoxDefaultText;
        }
        private void cancelFilter()
        {
            listBoxPosts.Items.Clear();
            foreach (AppPost post in m_Posts)
            {
                listBoxPosts.Items.Add(post);
            }
            labelActualNumber.Text = m_Posts.Count.ToString();
        }
        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxPosts.SelectedIndex != -1)
            {
                string selectedItem = listBoxPosts.SelectedItem.ToString();
                MessageBox.Show(selectedItem);
            }
            
        }

        private void buttonSaveDate_Click(object sender, EventArgs e)
        {
            string dateName = textBoxDateToSave.Text;
            int day = int.Parse(numericUpDownDay.Value.ToString());
            int month = int.Parse(numericUpDownMonth.Value.ToString());
            int year = int.Parse(numericUpDownYear.Value.ToString());
            DateTime savedDate = new DateTime(year, month, day);
            bool dateTaken = false;
            foreach (Tuple<string, DateTime> dateSaved in m_DatesSaved)
            {
                if(dateSaved.Item2.Date == savedDate.Date)
                {
                    dateTaken = true;
                    break;
                }
            }
            if(dateTaken)
            {
                MessageBox.Show($"{day}\\{month}\\{year} is already saved");
            }
            else if (string.IsNullOrEmpty(dateName))
            {
                MessageBox.Show("Invalid name");
            }
            else if(comboBoxSavedDates.Items.Contains(dateName))
            {
                MessageBox.Show($"{dateName} is already taken");
            }
            else if (day == 0 || month == 0)
            {
                MessageBox.Show("Can't save this date");
            }
            else
            {
                Tuple<string, DateTime> dateTuple = Tuple.Create(dateName, savedDate);
                comboBoxSavedDates.Items.Add(dateName);
                m_DatesSaved.Add(dateTuple);
                textBoxDateToSave.Clear();
                MessageBox.Show($"{day}\\{month}\\{year} saved as {dateName}");
            }
        }

        private void comboBoxSavedDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBoxSavedDates.SelectedItem.ToString();
            m_SelectorStrategy = new IsPostInRange().Selector;
            foreach(Tuple<string, DateTime> savedDate in m_DatesSaved)
            {
                if(savedDate.Item1 == name)
                {
                    m_DatesStrategy = new IsPostInRange();
                    int day = savedDate.Item2.Day;
                    int month = savedDate.Item2.Month;
                    int year = savedDate.Item2.Year;
                    numericUpDownDay.Value = day;
                    numericUpDownMonth.Value = month;
                    numericUpDownYear.Value = year;
                    selectDates(day, month, year);
                }
            }
        }

        private void buttonDeleteDate_Click(object sender, EventArgs e)
        {
            string nameToRemove = textBoxDateToSave.Text;
            if(comboBoxSavedDates.Items.Contains(nameToRemove))
            {
                comboBoxSavedDates.Items.Remove(nameToRemove);
                foreach(Tuple<string, DateTime> dataToRemove in m_DatesSaved)
                {
                    if (dataToRemove.Item1 == nameToRemove)
                    {
                        m_DatesSaved.Remove(dataToRemove);
                        break;
                    }
                }
                comboBoxSavedDates.Text = k_ComboBoxDefaultText;
                MessageBox.Show($"{nameToRemove} was removed");
            }
            else
            {
                MessageBox.Show($"{nameToRemove} is not saved");
            }
        }
    }
}
