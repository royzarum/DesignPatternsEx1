using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class IsPostOlder : IPostsStrategy
    {
        public bool Selector(int i_Year, int i_Month, int i_Day, DateTime i_Date)
        {
            bool result;
            if (i_Year < i_Date.Year)
            {
                result = false;
            }
            else if (i_Year == i_Date.Year)
            {
                if (i_Month < i_Date.Month)
                {
                    result = false;
                }
                else if (i_Month == i_Date.Month)
                {
                    result = i_Day > i_Date.Day;
                }
                else
                {
                    result = true;
                }
            }
            else
            {
                result = true;
            }
            return result;
        }
    }
}
