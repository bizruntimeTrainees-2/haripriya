using System;
   public class cloneMethod
    {
       public static void Main(string[] args)
        {
            string s1 = "Heloo";
            string s2 = (string)s1.Clone();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            //Console.WriteLine(Object.ReferenceEquals(s1,s2));
            Console.ReadKey();
        }
    }