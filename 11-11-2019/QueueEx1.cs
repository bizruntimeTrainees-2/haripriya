using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class QueueEx1
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<String>();
            names.Enqueue("H");
            names.Enqueue("A");
            names.Enqueue("R");
            names.Enqueue("I");
            Console.WriteLine(names.Count);
            Console.WriteLine(names.Peek());
            Console.ReadLine();
        }
    }
}
