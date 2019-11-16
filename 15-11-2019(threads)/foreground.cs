using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Foreground_Thread
{
    //Lifespan of foreground threads does not depends on main thread
    class foreground
    {
        static void WorkThread()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Foreground Thread is in progress..!");
                Thread.Sleep(2000); 

            }
            Console.WriteLine("Foreground Thread Quits..!");

        }

        static void Main(string[] args)
        {
            
            Thread Th1 = new Thread(WorkThread);
            Th1.Start();
            Console.WriteLine("Main Thread Quits..!");
            Console.ReadKey();
        }
    }
}
