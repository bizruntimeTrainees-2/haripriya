using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class CopyTo
    {
        public static void Main(string[] args)
        {
            string s1 = "Hello C#, How are you?";
            char[] ch = new char[15];
            s1.CopyTo(10, ch, 0, 12);
            Console.WriteLine(ch);
            Console.ReadKey();
        }
    }
}
//public void CopyTo(int index, char[] ch, int start, int end)
