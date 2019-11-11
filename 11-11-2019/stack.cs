using System;
using System.Collections.Generic;
class stack
{
     static void Main(string[] args)
    {
        Stack<string> names = new Stack<string>();
        names.Push("H");
        names.Push("A");
        names.Push("R");
        names.Push("I");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Peek element: " + names.Peek());
        Console.WriteLine("Pop: " + names.Pop());
        Console.WriteLine("After Pop, Peek element: " + names.Peek());
        Console.ReadLine();

    }
}