using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public static class FormsFactory
    {
        public static Form CreateForm(Button i_ButtonClicked, LoginResult i_LoggedInResult)
        {
            Form newForm;
            if(i_ButtonClicked.Name == "buttonFriends")
            {
                newForm = new FriendsForm(i_LoggedInResult);
            }
            else if(i_ButtonClicked.Name == "buttonGroups")
            {
                newForm = new GroupsForm(i_LoggedInResult);
            }
            else if(i_ButtonClicked.Name == "buttonAlbums")
            {
                newForm = new AlbumsForm(i_LoggedInResult);
            }
            else if(i_ButtonClicked.Name == "buttonPosts")
            {
                newForm = new PostsForm(i_LoggedInResult);
            }
            else
            {
                newForm = new LikedPagesForm(i_LoggedInResult);
            }
        return newForm;
        }
    }
}
