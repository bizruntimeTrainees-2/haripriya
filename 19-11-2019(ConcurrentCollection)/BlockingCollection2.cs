using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace ConcurrentCollection
{
    class BlockingCollection2
    {
            static void Main(string[] args)
            {
                BlockingCollection<int> b = new BlockingCollection<int>(boundedCapacity: 10);
                Task producerThread = Task.Run(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        b.Add(i);
                    }
                    b.CompleteAdding();         //by producer thread
                });
                Task consumerThread = Task.Run(() =>//task.factorysession.startnew
                {
                    while (!b.IsCompleted)
                    {
                        int item = b.Take();
                        Console.WriteLine(item);
                    }
                });
                Task.WaitAll(producerThread, consumerThread);

            }
        }
    }