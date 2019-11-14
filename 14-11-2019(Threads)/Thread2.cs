using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace asynchronous_await_async_
{
    class Thread2
    {

        public static void Main()
        {

            var th = new Thread(ExecuteInForeground);//no arg type,arg type
            th.Start();
            Thread.Sleep(10);

            Console.WriteLine("from Main thread: " + Thread.CurrentThread.ManagedThreadId);

            Console.WriteLine("main thread ends.");
        }
        static void ExecuteInForeground()
        {
            Console.WriteLine("foreground thread status: " +
            Thread.CurrentThread.ManagedThreadId + " " +
            Thread.CurrentThread.ThreadState + " " +
            Thread.CurrentThread.Priority);

        }
    }

}

