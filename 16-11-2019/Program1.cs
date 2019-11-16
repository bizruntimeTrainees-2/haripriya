using System;
using System.Threading;
class Sync1
{
   public void Print()
    {
        for (int i = 1; i <= 10; i++)
        {
            Thread.Sleep(100);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
class Program1
{
    static void Main(string[] args)
    {
        Sync1 s = new Sync1();
        Thread t1 = new Thread(new ThreadStart(s.Print));
        Thread t2 = new Thread(new ThreadStart(s.Print));
        t1.Start();
        t2.Start();
    }
}