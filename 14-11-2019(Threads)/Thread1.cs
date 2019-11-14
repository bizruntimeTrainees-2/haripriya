using System;
using System.Threading;


 class Thread1
{
    public static void T1()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("from child thread: " + i);
        }
    }
    public static void Main()
    {
        Console.WriteLine("Main thread start:");
        Thread t = new Thread(new ThreadStart(T1));
        t.Start();
        for (int i = 50; i < 55; i++)
        {
            Console.WriteLine("from Main thread: " + i);
        }
        t.Join();
        Console.WriteLine("main thread ends.");
        Console.ReadLine();
    }
}
