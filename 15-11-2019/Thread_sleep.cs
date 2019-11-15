using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Sleep
{
    class Thread_sleep
    {
        static void Work1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Work-1 is running" + " " + i.ToString());
            }

          // Thread.Sleep(4000);
        }

        static void Work2()
        {
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Work-2 is running" + " " + i.ToString());
            }
            Thread.Sleep(3000);
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Work1);
            Thread t2 = new Thread(Work2);

          
            t2.Start();
            //t2.Join();

            t1.Start();


            Console.ReadKey();
        }
    }
}
