using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;


namespace ConcurrentCollection
{
    class BlockingCollection //thread-safe,producer-consumer pattern(data exchange)
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> b = new BlockingCollection<int>(boundedCapacity: 5);//fixed size
            b.Add(1);
            b.Add(2);
            b.Add(3);
            b.Add(4);
            b.Add(5);
            int item = b.Take();//it will print remove element
            Console.WriteLine(item);
            int item1 = b.Take();
            Console.WriteLine(item1);
            Console.ReadLine();
        }
    }
}

//types of Blocking Collection:
//1.blocking
//2.bounding