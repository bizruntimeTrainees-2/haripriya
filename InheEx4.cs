using System;
public class A
{
    private int value = 10;
    public class B : A
    {
        public int GetValue()
        {
            return this.value;
        }
    }
}
public class C : A
{
}
public class Example
{
    public static void Main(string[] args)
    {
        var b = new A.B();//to get the GetValue(),we are mentioned directry
        Console.WriteLine(b.GetValue());
    }
}