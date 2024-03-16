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
using CefSharp.DevTools.SystemInfo;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class AlbumsForm : Form
    {
        private PictureBox[] m_CurrentAlbumDisplay;
        private const string k_FormName = "Albums";
        private const int k_PictureBoxSize = 300;
        private const int k_SpaceSize = 10;
        private bool m_Accessible = true;
        public User LoggedInUser { get; }

        public AlbumsForm()
        {
            InitializeComponent();
        }
        public AlbumsForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            LoggedInUser = i_LoginResult.LoggedInUser;
            initialzeData();
            initializeFormAppearance();
            
        }

        private void initializeFormAppearance()
        {
            this.Size = new System.Drawing.Size(2 * labelName.Left + 2 * k_PictureBoxSize + 10 * k_SpaceSize, labelNumberOfAlbums.Bottom + k_PictureBoxSize + 4 * k_SpaceSize);
            labelHeadline.Location = new System.Drawing.Point(ClientSize.Width / 2 - labelHeadline.Size.Width / 2 + 1, 10 * k_SpaceSize);
            listBoxAlbums.Location = new System.Drawing.Point(ClientSize.Width / 2 - listBoxAlbums.Size.Width / 2 + 1, labelHeadline.Bottom + k_SpaceSize);
            labelNumberOfAlbums.Top = listBoxAlbums.Bottom;
            labelNumberOfAlbums.Left = listBoxAlbums.Left;
            labelNumberOfAlbumsValue.Top = labelNumberOfAlbums.Top;
            labelNumberOfAlbumsValue.Left = labelNumberOfAlbums.Right;
            this.MinimumSize = new System.Drawing.Size(2 * labelName.Left + k_PictureBoxSize + 9 * k_SpaceSize, labelNumberOfAlbums.Bottom + 2 * k_SpaceSize);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            adjustPictureBoxesPosition();
        }

        private void initialzeData()
        {
            labelHeadline.Text = k_FormName;
            labelName.Text = LoggedInUser.Name;
            pictureBoxProfile.ImageLocation = LoggedInUser.PictureNormalURL;
            try
            {
                labelNumberOfAlbumsValue.Text = LoggedInUser.Albums.Count.ToString();
            }
            catch(Facebook.FacebookOAuthException oAuthExceotion)
            {
                m_Accessible = false;
                MessageBox.Show($"There is no access to {LoggedInUser.Name}'s Albums");
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            new Thread(fetchData).Start();
        }
        private void fetchData()
        {
            if (m_Accessible)
            {
                fetchAlbumsToListBox();
            }
            else
            {
                this.Close();
            }
        }

        private void fetchAlbumsToListBox()
        {
            if (LoggedInUser.Albums != null)
            {
                labelNumberOfAlbumsValue.Text = LoggedInUser.Albums.Count.ToString();
                listBoxAlbums.Items.Clear();
                listBoxAlbums.DisplayMember = "Name";
                foreach (Album album in LoggedInUser.Albums)
                {
                    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album)));
                }

                if (listBoxAlbums.Items.Count == 0)
                {
                    MessageBox.Show("No Albums to retrieve :(");
                }
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }
        
        private void displaySelectedAlbum()
        {
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;

            if (selectedAlbum != null && selectedAlbum.Photos.Count > 0)
            {
                removeScreenCurrentPictureBoxes();
                m_CurrentAlbumDisplay = new PictureBox[selectedAlbum.Photos.Count];
                int index = 0;
                foreach (Photo photo in selectedAlbum.Photos)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Visible = false;
                    m_CurrentAlbumDisplay[index] = pictureBox;
                    pictureBox.Image = photo.ImageNormal;
                    initializePictureBoxProperties(pictureBox);
                    pictureBox.Click += pictureBox_OnClick;
                    Controls.Add(pictureBox);
                    index++;
                }

                adjustPictureBoxesPosition();
            }

        }

        private void removeScreenCurrentPictureBoxes()
        {
            if (m_CurrentAlbumDisplay != null)
            {
                foreach (PictureBox pictureBox in m_CurrentAlbumDisplay)
                {
                    Controls.Remove(pictureBox);
                }
            }
        }

        private void initializePictureBoxProperties(PictureBox pictureBox)
        {
            pictureBox.Width = pictureBox.Height = k_PictureBoxSize;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void adjustPictureBoxesPosition()
        {
            if (m_CurrentAlbumDisplay == null)
            {
                return;
            }
            // Calculate the new position based on the form size
            int spacing = k_SpaceSize;
            int pictureBoxWidth = m_CurrentAlbumDisplay[0].Width;
            int pictureBoxHeight = m_CurrentAlbumDisplay[0].Height;
            int picturesInRow = ClientSize.Width / (2 * spacing + pictureBoxWidth);

            for (int i = 0; i < m_CurrentAlbumDisplay.Length; i++)
            {
                int row = i / picturesInRow;
                int col = i % picturesInRow;
                int positionFromLeftOnClientScreen = labelName.Left + 3 * spacing + col * (pictureBoxWidth + spacing);
                int positionFromTopOnClientScreen = labelNumberOfAlbums.Bottom + spacing + row * (pictureBoxHeight + spacing);
                m_CurrentAlbumDisplay[i].Location = new Point(positionFromLeftOnClientScreen, positionFromTopOnClientScreen);
                m_CurrentAlbumDisplay[i].Visible = true;
            }

        }

        private void pictureBox_OnClick(object sender, EventArgs e)
        {
            
        }
    }
}
