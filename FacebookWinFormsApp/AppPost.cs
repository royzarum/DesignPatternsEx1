using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AppPost
    {
        public string Text { get; }
        public DateTime CreatedIn { get; }
        public AppPost(string i_Text, DateTime i_CreatedIn)
        {
            Text = i_Text;
            CreatedIn = i_CreatedIn;
        }
        public override string ToString()
        {
            return $"{CreatedIn.ToString()}\t{Text}";
        }
    }
}
