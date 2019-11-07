//constructor chaining
using System;
namespace Tutlane
{
    class User
    {
        public User()
        {
            Console.Write("Hi, ");
        }
       public User(string a):this()
       {
            Console.Write(a);
       }
        public User(string a, string b):this("welcome")
      {
         Console.Write(a + " " + b);
      }
   }
       class Program
   {
      static void Main(string[] args)
       {
           User user1 = new User(" to", "tutlane");
           Console.WriteLine();
           Console.WriteLine("\nPress Enter Key to Exit..");
           Console.ReadLine();
        }
    }
}