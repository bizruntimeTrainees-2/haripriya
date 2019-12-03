﻿using System;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using SocketProgramming;

namespace WindowsApplication2
{
    public partial class chat
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;

       

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readData = "Conected to Chat Server ...";
            //Chat Server and Chat Client are running on the same machine 
            clientSocket.Connect("127.0.0.1",8080);
            serverStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
        }

        private void getMessage()
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[10025];
                buffSize = clientSocket.ReceiveBufferSize;
                serverStream.Read(inStream, 0, buffSize);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                readData = "" + returndata;
               
            }
        }

    }
}