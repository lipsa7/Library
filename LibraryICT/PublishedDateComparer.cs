using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryICT
{
    public class PublishedDateComparer:IComparer<DateTime>
    {
        public int Compare(DateTime x, DateTime y)
        {
            //if (x == 0 || y == 0)
            //{
            //    return DateTime;
            //}

            return x.CompareTo(y);
        }
    }
}
