using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Dictionary
    {
        static void Main(String[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            names.Add(1, "R");
            names.Add(2, "A");
            names.Add(3, "J");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
