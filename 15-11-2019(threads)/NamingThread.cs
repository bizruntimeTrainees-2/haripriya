using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace asynchronous_await_async_
{
    class NamingThread
    {
        static void Main()
            {
            Thread.CurrentThread.Name = "Main";
            Thread worker = new Thread(Go);
            worker.Name = "worker";
            worker.Start();
            Go();
          }
        static void Go()
        {
            Console.WriteLine("Hello from:" + Thread.CurrentThread.Name);
        }
    }
}
