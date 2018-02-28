using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using UnityEngine;

public class Server : MonoBehaviour {

    public string ipAddress;
    public int port;
    private TcpListener listener;
    private Socket client;
    private ASCIIEncoding ascii;

    public static Server server;

	// Use this for initialization
	void Start () {
        if (server != null)
        {
            GameObject.Destroy(server);
        }
        else
        {
            server = this;
        }
        DontDestroyOnLoad(this);

        ascii = new ASCIIEncoding();
        listener = new TcpListener(IPAddress.Parse(ipAddress), port);

        listener.Start();
        Console.WriteLine("Starting server...");


        client = listener.AcceptSocket();

        Console.WriteLine("Connection accepted from " + client.RemoteEndPoint);


        byte[] b = new byte[100];
        int k = client.Receive(b);

        char cc = ' ';
        string test = null;
        Console.WriteLine("Received...");

        for (int i = 0; i < k - 1; i++)
        {
            Console.WriteLine(Convert.ToChar(b[i]));
            cc = Convert.ToChar(b[i]);
            test += cc.ToString();
        }

        switch (test)
        {
            case "1":
                break;
        }

        client.Send(ascii.GetBytes("The string was received"));
        client.Close();

        Console.WriteLine("Sent Acknowledgement");
       
        listener.Stop();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void closeServer()
    {
        if (client != null)
        {
            client.Close();
        }
        listener.Stop();
    }
}
