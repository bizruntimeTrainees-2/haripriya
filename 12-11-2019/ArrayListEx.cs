using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class ArrayListEx
    {
            static void Main(string[] args)
            {
                ArrayList al = new ArrayList();
                Console.WriteLine("Adding some numbers:");
                al.Add(4);
                al.Add(7);
                al.Add(40);
                al.Add(40);
               

                Console.WriteLine("Capacity: {0} ", al.Capacity);
                Console.WriteLine("Count: {0}", al.Count);
                Console.Write("Content: ");
                foreach (int i in al)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
                Console.Write("Sorted Content: ");
                al.Sort();
                foreach (int i in al)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
