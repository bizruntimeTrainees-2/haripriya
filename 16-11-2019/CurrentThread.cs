using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace THREADS
{
    class CurrentThread
    {
        static void Main()
        {
            Thread th = Thread.CurrentThread;
            Console.WriteLine(th.Name);
            Console.ReadLine();
        }    
    }
}
