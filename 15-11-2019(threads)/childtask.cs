 

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Asynchronious

{
   class Program

    {
        public static void Main(String [] args)

        {
            Task t1 = new Task(() =>
             {
                 System.Threading.Thread.Sleep(5000);

                 Console.WriteLine("Huge Task Finish");
             }   
             );

            t1.Start();

            Task t4= new Task(() =>
            {
                int n = 4;
                if (n % 2 == 0)

                    Console.WriteLine("it is even number");
            }
            
        );
            t4.Start();

            Task t2 = new Task(

                () => {

                       System.Threading.Thread.Sleep(5000);

                       Console.WriteLine("Huge Task Finish"); 

                     }

                );

            t2.Start();

            bool rValue = t2.Wait(1000);

            Console.WriteLine("Main Process Finished");


        }

    }

}