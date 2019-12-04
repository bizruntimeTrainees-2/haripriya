using System;
using System.Net.Sockets;
using System.IO;
public class ServerSocket1
{
    public static void Main()
    {
        try
        {
            bool status = true;
            string servermessage = "";
            string clientmessage = "";
            TcpListener tcpListener = new TcpListener(8100);
            tcpListener.Start();
            Console.WriteLine("Server Started");
            Socket socketForClient = tcpListener.AcceptSocket();
            Console.WriteLine("Client Connected");
            NetworkStream networkStream = new NetworkStream(socketForClient);
            StreamWriter streamwriter = new StreamWriter(networkStream);
            StreamReader streamreader = new StreamReader(networkStream);
            while (status)
            {
                if (socketForClient.Connected)
                {
                    servermessage = streamreader.ReadLine();
                    Console.WriteLine("Client:" + servermessage);
                    if ((servermessage == "bye"))
                    {
                        status = false;
                        streamreader.Close();
                        networkStream.Close();
                        streamwriter.Close();
                        return;
                    }
                    Console.Write("Server:");
                    clientmessage = Console.ReadLine();
                    streamwriter.WriteLine(clientmessage);
                    streamwriter.Flush();
                }
            }
            streamreader.Close();
            networkStream.Close();
            streamwriter.Close();
            socketForClient.Close();
            Console.WriteLine("Exiting");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}
/*
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SimpleTcpSrvr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int recv;

            byte[] data = new byte[1024];

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"),9050);

            Socket newsock = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            newsock.Bind(ipep);

            newsock.Listen(10);

            Console.WriteLine("Waiting for a client...");

            Socket client = newsock.Accept();

            IPEndPoint clientep = (IPEndPoint)client.RemoteEndPoint;

            Console.WriteLine("Connected with {0} at port {1}",clientep.Address,clientep.Port);

            string welcome = "Welcome to my test server";

            data = Encoding.UTF8.GetBytes(welcome);

            client.Send(data,data.Length,SocketFlags.None);

            string input;

            while (true)
            {

                data = new byte[1024];

                recv = client.Receive(data);

                if (recv == 0)

                break;

                Console.WriteLine("Client: "+Encoding.UTF8.GetString(data, 0, recv));

                input = Console.ReadLine();

                Console.WriteLine("You: " + input);

                client.Send(Encoding.UTF8.GetBytes(input));
            }

            Console.WriteLine("Disconnected from {0}", clientep.Address);

            client.Close();

            newsock.Close();

            Console.ReadLine();

        }
    }
}
*/