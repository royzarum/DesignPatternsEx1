using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class LikedPagesForm : Form
    {
        private const string k_HeadLineComplition = "'s Liked Pages";
        private bool m_Accesible = true;
        public User LoggedInUser { get; }
        public LikedPagesForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            LoggedInUser = i_LoginResult.LoggedInUser;
            initializeFormAppearance();
        }

        private void initalizeData()
        {
            try
            {
                labelNumberOfPagesValue.Invoke(new Action(() =>labelNumberOfPagesValue.Text = LoggedInUser.LikedPages.Count.ToString()));
            }
            catch (Facebook.FacebookOAuthException oAuthExceotion)
            {
                m_Accesible = false;
                MessageBox.Show($"There is no access to {LoggedInUser.Name}'s liked pages");
            }
        }

        private void initializeFormAppearance()
        {
            labelHeadline.Text = LoggedInUser.FirstName + k_HeadLineComplition;
            labelNumberOfPages.Location = new System.Drawing.Point(
                labelHeadline.Right + 20,
                labelHeadline.Bottom - labelNumberOfPages.Height
                );
            labelNumberOfPagesValue.Location = new System.Drawing.Point(
                labelNumberOfPages.Right,
                labelNumberOfPages.Bottom - labelNumberOfPages.Height
                );
            listBoxLikedPages.Width = labelHeadline.Left + labelNumberOfPagesValue.Right;
            panelLikedPageDetails.Left = listBoxLikedPages.Right + 15;  
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchData).Start();
        }
        private void fetchData() 
        {
            initalizeData();
            if (m_Accesible)
            {
                pageBindingNavigator.Invoke(new Action(
                 () => pageBindingSource.DataSource = LoggedInUser.LikedPages)
                 );
            }
            else
            {
                this.Invoke(new Action(Close));
            }
        }
    }
}
