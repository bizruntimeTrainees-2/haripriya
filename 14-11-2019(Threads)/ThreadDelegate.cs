using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace asynchronous_await_async_
{
    class ThreadDelegate
    {
        static void Main()
        {
            Thread t = new Thread(new ThreadStart(Go));
            //Thread t = new Thread(Go);
            //Thread t = new Thread ( () => Print ("Hello") );
            /*new Thread (() =>
                {
                   Console.WriteLine ("I'm running on another thread!");
                   Console.WriteLine ("This is so easy!");
                }).Start();*/
          //public delegate void ThreadStart();
          //public delegate void ParameterizedThreadStart(object obj);
        t.Start();
            Go();
        }
        static void Go()
        {
            Console.WriteLine("hello!");
            Console.ReadLine();
        }
    }
}
