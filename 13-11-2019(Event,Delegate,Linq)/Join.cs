using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Join
    {
        public static void Main()
        {
            IList<string> strList1 = new List<string>() {
            "One",
            "Two",
            "Three",
            "Four"
            };

            IList<string> strList2 = new List<string>() {
            "One",
            "Two",
            "Five",
            "Six"
            };

            var innerJoinResult = strList1.Join( 
                          strList2,  
                          str1 => str1,  
                          str2 => str2,  
                          (str1, str2) => str1);

            foreach (var str in innerJoinResult)
            {
                Console.WriteLine("{0} ", str);
            }

        }
    }

}
