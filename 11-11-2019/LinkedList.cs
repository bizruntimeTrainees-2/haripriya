using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<string> names = new LinkedList<string>();
            names.AddLast("X");
            names.AddLast("Y");
            names.AddFirst("Z");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
