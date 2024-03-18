using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class IsPostInRange: IPostsStrategy
    {
        public bool Selector(int i_Year, int i_Month, int i_Day, DateTime i_Date)
        {
            bool result = (i_Year == i_Date.Year);
            if (i_Month != 0)
            {
                result = (result && i_Month == i_Date.Month);
                if (i_Day != 0)
                {
                    result = (result && i_Month == i_Date.Month && i_Day == i_Date.Day);
                }
            }
            return result;
        }
    }     
}
