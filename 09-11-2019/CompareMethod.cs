using System;
namespace String
{
    class CompareMethod
    {
        static void Main(string[] args)
        {
            string s1 = "hai";
            string s2 = "hai";
            string s3 = "Heloo";
            string s4 = "csharpp";
            Console.WriteLine(string.Compare(s1, s2));
            Console.WriteLine(string.Compare(s3, s4));
            Console.ReadLine();
        }
    }
}
