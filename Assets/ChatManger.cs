using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine;

public class ChatManger : MonoBehaviour {


    public string IPstring;
    private int Ip;

    private Socket SocketClient;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ClinetConect()
    {
        SocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        SocketClient.Connect(new IPEndPoint(IPAddress.Parse(IPstring), Ip));
    }


}
