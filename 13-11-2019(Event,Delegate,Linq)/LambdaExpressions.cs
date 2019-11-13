using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class LambdaExpressions
    {
        static void Main()
        {
            GreetingsDelegate obj =(name)=>
              {
                  return "Hello " + name + "H r u?";
              };
            string str = obj.Invoke("Raju ");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
