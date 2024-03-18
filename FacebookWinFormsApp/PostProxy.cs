using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PostProxy
    {
        public Post post { get; }
        public string Text { get; }
        public DateTime CreatedIn { get; }
        public PostProxy(Post i_Post, string i_Text, DateTime i_CreatedIn)
        {
            post = i_Post;
            Text = i_Text;
            CreatedIn = i_CreatedIn;
        }

    }
}
