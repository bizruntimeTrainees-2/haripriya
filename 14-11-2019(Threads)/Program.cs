using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread1");
            Method();
            Console.WriteLine("Main thread2");
            Console.ReadLine();
        }
        public static async void Method()
        {
            Console.WriteLine("New Thread1");
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread2");
        }
        public static void LongTask()
        {
            Thread.Sleep(2000);
            Console.WriteLine("New task");
        }
    }
}
/*
 * Main thread1                      
New Thread1
New Thread2
Main thread2
New task
===============================
Main thread1
New Thread1
Main thread2
New task
New Thread2
*/

