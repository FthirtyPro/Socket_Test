using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class ChatManger : MonoBehaviour {


    public string Ipstring="192.168.0.112";
    private int Ip=7788;
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
        SocketClient.Connect(new IPEndPoint(IPAddress.Parse(Ipstring), Ip));
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
        Debug.Log   ("+++");

    }


}
