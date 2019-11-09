using System;
namespace String
{
    class GetEnumeration
    {
        public static void Main(string[] args)
        {
            string s1 = "heloo";
            CharEnumerator ch = s1.GetEnumerator();
            while(ch.MoveNext())
            {
                Console.WriteLine(ch.Current);
            }
            Console.ReadLine();
        }
    }
}
