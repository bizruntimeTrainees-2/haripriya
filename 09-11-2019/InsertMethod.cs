using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class InsertMethod
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = s1.Insert(3, "l");
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
