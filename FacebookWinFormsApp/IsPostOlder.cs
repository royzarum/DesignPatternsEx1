using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class IsPostOlder : IPostsStrategy
    {
        public bool Selector(DateTime i_DateSelected, DateTime i_DateToCheck)
        {
            return i_DateToCheck < i_DateSelected;
        }
    }
}
