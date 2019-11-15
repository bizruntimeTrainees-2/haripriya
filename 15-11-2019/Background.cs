using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Background_Thread
{
    class Background
    {
        static void WorkThread()
        {


            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Background Thread is in progress..!");
                Thread.Sleep(2000); 

            }

            Console.WriteLine("Background Worker Thread Quits..!");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Starts..!");
            Thread.Sleep(3000);
            Thread t1 = new Thread(WorkThread);
            t1.Start();

            t1.IsBackground = true;

            Console.WriteLine("Main Thread Quits..!");
        }
    }
}
