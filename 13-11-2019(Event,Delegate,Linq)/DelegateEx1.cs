using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string str);
    class DeledateEx1
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        { 
            return "Hello" + name;
        }
        static void Main(string[] args)
        {
            DeledateEx1 d = new DeledateEx1();
            AddDelegate ad = new AddDelegate(d.AddNums);
            ad(100,50);//ad.invoke(100,50);
            SayDelegate sy = new SayDelegate(DeledateEx1.SayHello);
            string str = sy("Raj");

        }
    }
}