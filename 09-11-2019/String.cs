using System;

namespace String
{
    class String
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            char[] ch = { 'c', 's', 'h'};
            string s2 = new string(ch);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.ReadKey();
        }

        internal static bool Compare(string s3, string s4)
        {
            throw new NotImplementedException();
        }
    }
}
