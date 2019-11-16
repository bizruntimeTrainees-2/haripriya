using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace THREADS
{
    class AsynchronousMethod
    {
        static void Main(string[] args)
        {
            Task<int> result = add();
            Console.WriteLine("length: {0}", result.Result);
            Console.ReadLine();
        }
          
        async static Task<int> add()
        {
            Task<string> TaskUrl = new HttpClient().GetStringAsync("http://www.google.com");
            string result = await TaskUrl;
            return result.Length;
           
        }
    }
}
