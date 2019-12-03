using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class MultipleThreadEchoServer
{
    private static void ProcessClientRequest(object argument)
    {
        TcpClient client = (TcpClient)argument;
        try
        {
            StreamReader reader = new StreamReader(client.GetStream());
            StreamWriter writer = new StreamWriter(client.GetStream());
            string s = String.Empty;
            while (!(s = reader.ReadLine()).Equals("Exit") || (s == null))
            {
                Console.WriteLine("From Client ->" + s);
                writer.WriteLine("From Client ->" + s);
                writer.Flush();
            }
            reader.Close();
            writer.Close();
            client.Close();
            Console.WriteLine("Closing Client Connection:");
        }
        catch (IOException)
        {
            Console.WriteLine("problem with Client connection,existing thread");
        }
        finally
        {
            if (client != null)
            {
                client.Close();
            }
        }
    }
    static void Main()
    {
        TcpListener listener = null;
        try
        {
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            listener.Start();
            Console.WriteLine("Multiple ThreadEcho server started...");
            while (true)
            {
                Console.WriteLine("waiting for incoming client connection....");
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Accepted new client connection");
                Thread t = new Thread(ProcessClientRequest);
                t.Start(client);
            }
        } catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            if (listener != null)
            {
                listener.Stop();
            }
        }
    }
}
