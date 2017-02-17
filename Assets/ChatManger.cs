using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class ChatManger : MonoBehaviour {


    public string IPstring;
    private int Ip;
    public UIInput textInput;

    private Socket SocketClient;
	// Use this for initialization
	void Start () {
        ClinetConect();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ClinetConect()
    {
        SocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        SocketClient.Connect(new IPEndPoint(IPAddress.Parse(IPstring), Ip));
    }

    void SendMessage(string message)
    {
        byte[] data = Encoding.UTF8.GetBytes(message);
        SocketClient.Send(data);
    }

    public void OnSendButtonClick()
    {
        string value = textInput.value;
        SendMessage(value);

    }


}
