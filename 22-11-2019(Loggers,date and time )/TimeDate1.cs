using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
public class Datetime1
    {
        public static void Main()
        {
            DateTimeOffset dateOffSet1, dateOffSet2;
            TimeSpan difference;
            dateOffSet1 = DateTime.Now;
            dateOffSet2 = DateTime.UtcNow;
            difference = dateOffSet1 - dateOffSet2;
            Console.WriteLine("DateTime: " + dateOffSet1.ToString() + "   " + dateOffSet2.ToString());
            Console.WriteLine("TimeSpan: " + difference.ToString());
            Console.ReadLine();
        }
    }

}
