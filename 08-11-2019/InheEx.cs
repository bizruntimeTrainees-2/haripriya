using System;
namespace ConsoleApplication1
{
    class GFG
    {
        public string name;
        public string subject;
        GFG(String name,String subject)
        {
                

        }
        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }
    class GeeksforGeeks : GFG
    {
        public GeeksforGeeks()
        {
            Console.WriteLine("GeeksforGeeks");
        }
    }
    class Sudo
    {
        static void Main(string[] args)
        {
            GeeksforGeeks g = new GeeksforGeeks();
            g.readers("Kirti", "C#");
            GFG g1 = new GFG();
            GFG g1 = new GFG("hhh","c#");

     

        }
    }
}