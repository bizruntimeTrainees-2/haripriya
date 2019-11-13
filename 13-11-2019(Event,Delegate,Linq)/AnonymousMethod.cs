using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate string GreetingsDelegate(string name);
    class AnonymousMethod
    {
       /* public static string Greetings(string name)
        {
            return "Hello" + name + "H r u?";
        }*/
        static void Main()
        {
            //GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            GreetingsDelegate obj = delegate (string name)
              {
                  return "Hello" + name + "H r u?";
              };
            string str=obj.Invoke("Raj");
            Console.WriteLine();
        }
    }
}
