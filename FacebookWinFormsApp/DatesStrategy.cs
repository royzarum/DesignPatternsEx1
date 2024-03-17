using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class DatesStrategy
    {
        public delegate R DateArranger<T1, T2, T3, T4, R>(T1 i_Param1, T2 i_Param2, T3 i_Param3, T4 i_Param4);
        public DateArranger<int, int, int, DateTime, bool> DateFilter {  get; set; }
        public DatesStrategy(DateArranger<int, int, int, DateTime, bool> dateFilter)
        {
            DateFilter = dateFilter;
        }

        public List<Tuple<DateTime, string>> Selector(int i_Year, int i_Month, int i_Day, List<Tuple<DateTime, string>> i_Posts)
        {
            List<Tuple<DateTime, string>> result = new List<Tuple<DateTime, string>>();
            foreach(Tuple<DateTime, string> post in i_Posts)
            {
                if (DateFilter(i_Year, i_Month, i_Day, post.Item1))
                {
                    result.Add(post);
                }
            }
            return result;
        }
    }
}
