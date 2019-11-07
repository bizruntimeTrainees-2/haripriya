using System;

public static class MyStaticClass
{
    public static int myStaticVariable = 0;

    public static void MyStaticMethod()
    {
        Console.WriteLine("This is a static method.");
    }

    public static int MyStaticProperty
    {
        get
        {
            return myStaticVariable;
        }
        set
        {
            myStaticVariable =500;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(MyStaticClass.myStaticVariable);

        MyStaticClass.MyStaticMethod();

        MyStaticClass.MyStaticProperty = 100;

        Console.WriteLine(MyStaticClass.MyStaticProperty);
    }
}