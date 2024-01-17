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

namespace BasicFacebookFeatures
{
    public partial class AlbumsForm : FacebookTemplateForm
    {
        public AlbumsForm(FacebookWrapper.LoginResult i_LoginResult)
            :base (i_LoginResult)
        {
            //InitializeComponent();
        }
    }
}
