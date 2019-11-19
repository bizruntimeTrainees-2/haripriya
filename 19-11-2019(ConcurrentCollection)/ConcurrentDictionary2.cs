﻿using System;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace ConcurrentDictionary2
{
    class ConcurrentDictionary2
    {
        static ConcurrentDictionary<string, int> cd = new ConcurrentDictionary<string, int>();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(A);
            Thread t2 = new Thread(A);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine("Average{0}", cd.Values.Average());
        }
        static void A()
        {
            for (int i = 0; i <= 25; i++)
            {
                cd.TryAdd(i.ToString(), i);
            }
        }
    }
}
