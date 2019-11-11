using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class HashSet
    {
        static void Main(string[] args)
        {
            var elements = new HashSet<string>() { "helo", "BIZruntime", "hai", "BIZruntime" };  // Create a set of strings
            foreach (var element in elements)
            {
                Console.WriteLine(element); 
            }
            Console.WriteLine();
           // elements.Remove("helo");
            foreach (var element1 in elements)
            {
                Console.WriteLine(element1);
            }
            Console.WriteLine();
            var elements1 = new HashSet<string>() { "helo", "time", "run", "c#" };
            elements.UnionWith(elements1);
            foreach(var ele in elements)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine();
           elements.IntersectWith(elements1);
            foreach (var ele1 in elements)
            {
                Console.WriteLine("IntersectWith:"+ele1);
            }
            Console.WriteLine();

            elements.ExceptWith(elements1);
            Console.WriteLine("ExceptWith:");
            foreach (var ele2 in elements)
            {
                Console.WriteLine(ele2);
            }
            Console.ReadLine();

        }
    }
}
