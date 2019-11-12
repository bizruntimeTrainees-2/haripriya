using System;
using System.Collections;

namespace Collections
{

    class Program
    {

        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", "A");
            ht.Add("002", "B");
            ht.Add("004", "C");
            ht.Add("005", "D");
            ht.Add("006", "E");
            ht.Add("007", "F");

           if (ht.ContainsValue("G"))
            {
                Console.WriteLine("The alphabet is already in the list");
            }
            else
            {
                ht.Add("008", "G");
            }
            ICollection key = ht.Keys;
            foreach (string k in ht)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();
        }
    }
}