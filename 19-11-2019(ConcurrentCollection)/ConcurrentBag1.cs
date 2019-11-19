using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;
using System.Collections.Concurrent;


namespace ConcurrentCollection
{
    class ConcurrentBag1
    {
            static void Main(string[] args)
            {
                ConcurrentBag<int> bag = new ConcurrentBag<int>();//ConcurrentBag-store the elements in unorded way,stores duplicate also.
                bag.Add(4);
                bag.Add(6);
                bag.Add(8);
                bag.Add(10);
                bag.Add(12);

                int result;
                if (bag.TryPeek(out result))     //it returns the most recently added element
                {
                    Console.WriteLine("TryPeek: " + result);
                }
                if (bag.TryTake(out result))     //it returns and removes the most recently added element
                {
                    Console.WriteLine("TryTake: " + result);
                }
                if (bag.TryPeek(out result))
                {
                    Console.WriteLine("TryPeek: " + result);
                }

            }
        }
    }