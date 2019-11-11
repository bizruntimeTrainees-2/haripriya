using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class SortedSet
    {
        static void Main(string[] args)
        {
            var elements = new SortedSet<string>() { "helo", "BIZruntime", "hai", "BIZruntime" };  // Create a set of strings
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

        }
    }
}
