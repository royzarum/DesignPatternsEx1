using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IPostsStrategy
    {
        bool Selector(int i_Year, int i_Month, int i_Day, DateTime i_Date);
    }
}
