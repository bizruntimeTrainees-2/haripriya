using System;
namespace String
{
    class ContainsMethod
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "He";
            string s3 = "Hi";
            Console.WriteLine(s1.Contains(s2));
            Console.WriteLine(s1.Contains(s3));
            Console.ReadKey();
        }
    }
}