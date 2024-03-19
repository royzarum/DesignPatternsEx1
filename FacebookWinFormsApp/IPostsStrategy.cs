using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IPostsStrategy
    {
        bool Selector(DateTime i_DateSelected, DateTime i_DateToCheck);
    }
}
