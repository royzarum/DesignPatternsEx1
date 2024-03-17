using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IDateFilterStrategy
    {
        bool DateSelection(int i_Day, int i_Month, int i_Year, DateTime i_Date);
    }
}
