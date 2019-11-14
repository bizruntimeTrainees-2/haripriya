using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace asynchronous_await_async_
{
    class DestroyThread
    {
            public static void CallToChildThread()
            {

                try
                {
                    Console.WriteLine("Child thread starts");

                    for (int counter = 0; counter <= 10; counter++)
                    {
                        //Thread.Sleep(500);
                        Console.WriteLine(counter);
                    }

                    Console.WriteLine("Child Thread Completed");
                }
                catch (ThreadAbortException e)
                {
                    Console.WriteLine("Thread Abort Exception");
                }
               
            }

            static void Main(string[] args)
            {
                ThreadStart childref = new ThreadStart(CallToChildThread);
                Console.WriteLine("In Main: Creating the Child thread");
                Thread childThread = new Thread(childref);
                childThread.Start();
                childThread.Join();

                //Thread.Sleep(2000);
                Console.WriteLine("In Main: Aborting the Child thread");
                childThread.Abort();
                Console.ReadKey();
            }
        }
    }