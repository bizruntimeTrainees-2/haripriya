using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class IndexOf
    {
        static void Main(string[] args)
        {
            string s1 = "Helo c#";
            int index = s1.IndexOf('o');
            Console.WriteLine(index);
            Console.ReadKey();
        }
    }
}
