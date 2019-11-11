using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class SortedList
    {
        static void Main(string[] args)
        {
            SortedList<string, string> names = new SortedList<string, string>();
            names.Add("1", "A");
            names.Add("4", "D");
            names.Add("5", "E");
            names.Add("3", "C");
            names.Add("2", "B");
            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.ReadLine();
        }
    }
}

