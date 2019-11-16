using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace THREADS
{
    class BackGroundThread
    {
        public static void Main(string[] args)
        {

            Thread oThread = new Thread(WorkThread);
            oThread.Start();
            oThread.IsBackground = true;

            Console.WriteLine("Main Thread Quits..!");


        }

        static void WorkThread()
        {


            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Worker Thread is in progress..!");
                Thread.Sleep(2000);
            }

            Console.WriteLine("Worker Thread Quits..!");
            Console.ReadLine();

        }

    }
}
