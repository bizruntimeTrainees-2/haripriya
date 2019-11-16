using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THREADS
{
    class Thread1
    {
        static void Main(string[] args)
        {
            Work1();
            Work2();
        }

        static void Work1()
        {
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("Work 1 is called " + i.ToString());

            }

        }

        static void Work2()

        {
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("Work 2 is called " + i.ToString());

            }
            Console.ReadLine();

        }
    }
}
