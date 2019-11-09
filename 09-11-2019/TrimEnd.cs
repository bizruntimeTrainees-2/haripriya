using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class TrimEnd
    {
            static void Main(string[] args)
            {
                string s1 = " Hello C# ";
                char[] ch = { '#' };
                string s2 = s1.TrimEnd(ch);
                Console.WriteLine(s2);
                Console.ReadKey();
            }
        }
    }
}