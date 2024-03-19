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
        public bool Selector(DateTime i_DateSelected, DateTime i_DateToCheck)
        {
            bool result = (i_DateSelected.Year == i_DateToCheck.Year);
            if (i_DateSelected.Month != 0)
            {
                result = (result && i_DateSelected.Month == i_DateToCheck.Month);
                if (i_DateSelected.Day != 0)
                {
                    result = (result && i_DateSelected.Month == i_DateToCheck.Month && i_DateSelected.Day == i_DateToCheck.Day);
                }
            }
            return result;
        }
    }     
}
