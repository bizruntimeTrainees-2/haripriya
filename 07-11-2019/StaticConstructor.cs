using System;
public static class MyStaticClass
{
    static MyStaticClass()
    {
        Console.WriteLine("Inside static constructor.");
    }
    public static int myStaticVariable = 0;

    public static void myStaticMethod()
    {
        Console.WriteLine("This is static method.");
    }

    public static int MyStaticProperty { get; set; }
}
class Program
{ 
    static void Main(string[] args)
    {
        MyStaticClass.myStaticVariable = 100;
        MyStaticClass.MyStaticProperty = 200;
        MyStaticClass.myStaticVariable = 300;
        MyStaticClass.MyStaticProperty = 400;
        Console.ReadKey();
    }
}