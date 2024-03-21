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
        public bool Selector(int i_Day, int i_Month, int i_Year, DateTime i_DateToCheck)
        {
            bool result = (i_Year == i_DateToCheck.Year);
            if (i_Month != 0)
            {
                result = (result && i_Month == i_DateToCheck.Month);
                if (i_Day != 0)
                {
                    result = (result && i_Month == i_DateToCheck.Month && i_Day == i_DateToCheck.Day);
                }
            }
            return result;
        }
    }     
}
