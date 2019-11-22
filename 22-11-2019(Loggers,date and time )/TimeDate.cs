using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class TimeDate
    {
        public static void Main()
        {
            DateTime date1, date2;
            TimeSpan difference;
            date1 = DateTime.Now;
            date2 = DateTime.UtcNow;
            difference = date1 - date2;
            Console.WriteLine("DateTime: " + date1.ToString() + ' ' + date2.ToString());
            Console.WriteLine("TimeSpan: " + difference.ToString());
        }
    }
}
