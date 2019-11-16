using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace THREADS
{
    class Thread2
    {
        static void Main(string[] args)
        {
            Thread Threadone = new Thread(Work1);
            Thread Threadtwo = new Thread(Work2);
            Threadone.Start();
            Threadtwo.Start();
            void Work1()
            {
                for (int i = 1; i <= 10; i++)
                {

                    Console.WriteLine("Work 1 is called " + i.ToString());

                }

            }

            void Work2()

            {
                for (int i = 1; i <= 10; i++)
                {

                    Console.WriteLine("Work 2 is called " + i.ToString());

                }             
            }
            Console.ReadLine();
        }
    }
}