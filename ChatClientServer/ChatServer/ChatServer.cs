using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    class ChatServer
    {
        private IPAddress IP = IPAddress.Parse("127.0.0.1");
        private int port;
        private volatile bool stop;

        public ChatServer(int port)
        {
            this.port = port;
        }

        internal void Run()
        {
            TcpListener listener = new TcpListener(IP, port);
            listener.Start();

            stop = false;

            while (!stop)
            {
                Console.WriteLine("Server is ready for a new client to connect.");

                Socket clientSocket = listener.AcceptSocket();

                Thread ClientHandlerThread = new Thread(new ClientHandler(clientSocket).Start);
                ClientHandlerThread.Start();
            }

            Console.WriteLine("Shutting down connection...");
            listener.Stop();
            Thread.Sleep(3000);
        }
    }
}