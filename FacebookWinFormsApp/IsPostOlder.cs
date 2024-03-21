using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class IsPostOlder : IPostsStrategy
    {
        public bool Selector(int i_Day, int i_Month, int i_Year, DateTime i_DateToCheck)
        {
            bool result = false;
            if(i_Year < i_DateToCheck.Year)
            {
                result = false;
            }
            else if (i_Year > i_DateToCheck.Year)
            {
                result = true;
            }
            else
            {
                if(i_Month < i_DateToCheck.Month)
                {
                    result = false;
                }
                else if (i_Month > i_DateToCheck.Month)
                {
                    result = true;
                }
                else
                {
                    result = i_Day < i_DateToCheck.Day;
                }
            }
            return result;
        }
    }
}
