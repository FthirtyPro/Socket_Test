using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine;

public class SocketServer : MonoBehaviour
{
     
    static void Main(string[] args)
    {

        Socket Serv = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint ipline =new IPEndPoint(IPAddress.Parse("192.168.18.129"), 7788);
        Serv.Bind(ipline);//端口绑定。
        Serv.Listen(100);

        while (true)
        {
            Socket clientSocket=Serv.Accept();
        }



       
    }
}
