using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;


public class EchoClient
{
    public static void Main()
    {
        try
        {
           TcpClient client= new TcpClient("127.0.0.1", 8080);
            StreamReader reader = new StreamReader(client.GetStream());
            StreamWriter writer = new StreamWriter(client.GetStream());
            string s = String.Empty;
            while (!s.Equals("Exit"))
            {
                Console.WriteLine("Enter a string to send server:");
                s = Console.ReadLine();
                Console.WriteLine();
                writer.WriteLine(s);
                writer.Flush();
                String server_string = reader.ReadLine();
                Console.WriteLine(server_string);
            }
            reader.Close();
            writer.Close();
            client.Close();
        }catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }

}