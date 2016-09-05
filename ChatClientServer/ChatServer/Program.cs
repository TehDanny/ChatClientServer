using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatServer server = new ChatServer(9001);
            server.Run();
        }
    }
}
