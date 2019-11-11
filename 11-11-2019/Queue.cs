using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Queue
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<String>();
            names.Enqueue("H");
            names.Enqueue("A");
            names.Enqueue("R");
            names.Enqueue("I");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(names.Peek());
            Console.WriteLine(names.Dequeue());
            Console.ReadLine();
        }
    }
}
