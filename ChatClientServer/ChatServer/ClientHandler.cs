using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    class ClientHandler
    {
        private Socket clientSocket;
        private string clientName;

        public ClientHandler(Socket clientSocket)
        {
            this.clientSocket = clientSocket;
        }

        internal void Start()
        {
            NetworkStream stream = new NetworkStream(clientSocket);
            StreamWriter writer = new StreamWriter(stream);
            StreamReader reader = new StreamReader(stream);
            string clientText;

            writer.WriteLine("The server is ready. Choose a username.");
            writer.Flush();
            clientName = reader.ReadLine();
            writer.WriteLine("Connected as {0}.", clientName);
            writer.Flush();
            Console.WriteLine("Client named {0}, connected.", clientName);

            do
            {

            } while (true);
        }
    }
}