using System;
using System.Net.Sockets;
using System.IO;
public class ClientSocket1
{
    static void Main(string[] args)
    {
        TcpClient socketForServer;
        bool status = true;
        try
        {
            socketForServer = new TcpClient("localhost", 8100);
            Console.WriteLine("Connected to Server");
        }
        catch
        {
            Console.WriteLine("Failed to Connect to server{0}:999", "localhost");
            return;
        }
        NetworkStream networkStream = socketForServer.GetStream();
        StreamReader streamreader = new StreamReader(networkStream);
        StreamWriter streamwriter = new StreamWriter(networkStream);
        try
        {
            string clientmessage = "";
            string servermessage = "";
            while (status)
            {
                Console.Write("Client:");
                clientmessage = Console.ReadLine();
                if ((clientmessage == "bye") || (clientmessage == "BYE"))
                {
                    status = false;
                    streamwriter.WriteLine("bye");
                    streamwriter.Flush();
                }
                if ((clientmessage != "bye") && (clientmessage != "BYE"))
                {
                    streamwriter.WriteLine(clientmessage);
                    streamwriter.Flush();
                    servermessage = streamreader.ReadLine();
                    Console.WriteLine("Server:" + servermessage);
                }
            }
        }
        catch
        {
            Console.WriteLine("Exception reading from the server");
        }
        streamreader.Close();
        networkStream.Close();
        streamwriter.Close();
    }
}
/*
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SimpleTcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            byte[] data = new byte[1024];

            string input, stringData;

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"),9050);

            Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            try
            {
                server.Connect(ipep);

            }
            catch(SocketException e)
            {
                Console.WriteLine("Unable to connect to server.");

                Console.WriteLine(e.ToString());

                return;
            }

            int recv = server.Receive(data);

            stringData = Encoding.UTF8.GetString(data, 0, recv);

            Console.WriteLine(stringData);

            while (true)
            {
                input = Console.ReadLine();

                if (input == "exit")

                    break;

                Console.WriteLine("You: " + input);

                server.Send(Encoding.UTF8.GetBytes(input));

                data = new byte[1024];

                recv = server.Receive(data);

                stringData = Encoding.UTF8.GetString(data, 0, recv);

                byte[] utf8string = System.Text.Encoding.UTF8.GetBytes(stringData);

                Console.WriteLine("Server: "+stringData);
            }

            Console.WriteLine("Disconnecting from server...");

            server.Shutdown(SocketShutdown.Both);

            server.Close();

            Console.WriteLine("Disconnected!");

            Console.ReadLine();

        }
    }
}
*/ 
