using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class SortedList1
    {
        public static void Main(string[] args)
        {
            SortedList<int,string> mylist = new SortedList<int,string>();
            mylist.Add(3, "This");
            mylist.Add(2, "Is");
            mylist.Add(1, "SortedList");
           /* if (mylist.ContainsKey(1) == true)
            {
                Console.WriteLine("Key is found...!!");
            }
            else
            {
                Console.WriteLine("Key is not found...!!");
            }
            if (mylist.ContainsValue("this") == true)
            {
                Console.WriteLine("Key is found...!!");
            }
            else
            {
                Console.WriteLine("Key is not found...!!");
            }*/
            foreach (KeyValuePair<int, string> pair in mylist)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();
            SortedList<string,Double> mylist2 = new SortedList<string,Double>();
            mylist2.Add("helo",1.11);
            mylist2.Add("how",2.1);
            mylist2.Add("r u",50.0);
            foreach (KeyValuePair<string, Double> pair in mylist2)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.ReadLine();
        }
    }
}

