using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace ConcurrentCollection
{
    class BlockingCollection1
    {
            static void Main(string[] args)
            {
                BlockingCollection<int> b = new BlockingCollection<int>(boundedCapacity: 6);
                b.Add(1);
                b.Add(2);
                b.Add(3);
                int item = b.Take();
                item = b.Take();
                if (b.TryTake(out item, TimeSpan.FromSeconds(3)))
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine("No item removed");
                }
            }
        }
    }
//out:which is used for the passing the arguments to methods as a reference type. It is generally used when a method returns multiple values.
