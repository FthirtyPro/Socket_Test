using System.Net.Sockets;

namespace Assets
{
    public class Client
    {
        private Socket clinetSclient;

        public Client(Socket s )
        {
            clinetSclient = s;
        }
    }
}