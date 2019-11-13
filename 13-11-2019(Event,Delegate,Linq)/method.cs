using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class method
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {//this is static content,so we are going to call with clsname
            return "Hello" + name;
        }
        static void Main(string[] args)
        {
            method d = new method();
            d.AddNums(100, 20);
            string str = method.SayHello("Raj");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}