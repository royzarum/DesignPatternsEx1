using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FacebookTemplateForm : Form
    {
        private LoginResult m_LoginResult = new LoginResult();

        public FacebookTemplateForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            m_LoginResult = i_LoginResult;
            initialzeData();
            
        }
        private void initialzeData()
        {
            labelName.Text = m_LoginResult.LoggedInUser.Name;
            pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
            // Initialize logo picture
        }

       
    }
}
