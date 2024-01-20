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
    public partial class LikedPagesForm : Form
    {
        private User m_LoggedInUser;
        private const string k_HeadLineComplition = "'s Liked Pages";


        public LikedPagesForm(LoginResult i_LoginResult)
        {

            InitializeComponent();
            m_LoggedInUser = i_LoginResult.LoggedInUser;
            initializeForm();



        }

        private void initializeForm()
        {
            System.Drawing.Size headlineSize;

            richTextBoxHeadLine.Text = m_LoggedInUser.FirstName + k_HeadLineComplition;
            headlineSize = TextRenderer.MeasureText(richTextBoxHeadLine.Text, richTextBoxHeadLine.Font);
            richTextBoxHeadLine.Size = headlineSize;
            Size = new Size(2 * headlineSize.Width + pictureBoxLogo.Width, 1000); // hard coded;
        }

    }
}
