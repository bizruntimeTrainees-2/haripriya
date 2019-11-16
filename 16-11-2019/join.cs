using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace THREADS
{
    class join
    {
            static void Main(string[] args)
            {
                Thread thread1 = new Thread(Method1);
                thread1.Start();

                Thread thread2 = new Thread(Method2);
                thread2.Start();

                thread1.Join();
                Console.WriteLine("After Thread1");

                thread2.Join();
                Console.WriteLine("After Thread2");
                Console.ReadKey();

            }

            private static void Method2(object obj)
            {
                Console.WriteLine("Thread1 Executed.");
            }

            private static void Method1(object obj)
            {
                Console.WriteLine("Thread2 Executed");
            }


        }
    }
