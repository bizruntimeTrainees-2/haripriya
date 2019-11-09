using System;
namespace String
{
    class CopyMethod
    {
        public static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = string.Copy(s1);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
