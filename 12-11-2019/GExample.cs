using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GenericEx1
{
    public void Display<TypeOfValue>(string msg, TypeOfValue value)
    {
        Console.WriteLine("{0}:{1}", msg, value);
    }
} 
public class GExample
{
    public static void Main(string[] args)
    {
        GenericEx1 p = new GenericEx1();
        p.Display<int>("Integer", 10);
        p.Display<char>("Character", 'H');
        p.Display<double>("Decimal", 255.67);
        Console.ReadLine();
      //  return 0;
    }
}
