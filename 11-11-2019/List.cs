using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class List
    {
        static void Main(string[] args)
        {
            // var elements = new List<string>();
            //var elements = new List<string>() { "helo", "hai", "helo" };
            List<int> mylist = new List<int>();
            mylist.Add(1);
            mylist.Add(10);
            mylist.Add(100);
            mylist.Add(1000);
            mylist.Add(10000);
            //elements.Add("helo");
            //elements.Add("hai");
            //elements.Add("helo");
            foreach (var element in mylist)
            {
                Console.WriteLine("Unsorted  list:"+element);

            }
            mylist.Remove(1);
            Console.WriteLine("Remove of Remove(1) from list:" + mylist.Count);
            mylist.RemoveAt(2);
            Console.WriteLine("Remove of RemoveAt(2) from list:" + mylist.Count);
            mylist.RemoveRange(0,2);
            Console.WriteLine("Remove of RemoveRange(0,2) from list:" + mylist.Count);
            mylist.Clear();
            Console.WriteLine("Remove of Clear() from list:" + mylist.Count);
            Console.ReadLine();
        }
    }
}
