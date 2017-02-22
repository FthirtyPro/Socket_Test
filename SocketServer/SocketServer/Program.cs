using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {

            Socket Serv = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);



            Serv.Connect();
        }
    }
}
