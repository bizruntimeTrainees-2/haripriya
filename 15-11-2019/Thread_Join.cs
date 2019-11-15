using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Join
{
    // join is used other calling threads will be haltes till the current thread(join) complets its task
    class Thread_Join
    {
        static void Work1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Work-1 is running" + " " + i.ToString());
            }
        }

        static void Work2()
        {
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Work-2 is running" + " " + i.ToString());
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Work1);
            Thread t2 = new Thread(Work2);

            Console.WriteLine("Work-2 in Progress");
            t2.Start();
            t2.Join();

            Console.WriteLine("Work-1 in Progress");
            t1.Start();
            Console.ReadKey();


        }
    }
}
