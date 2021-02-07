using System;
using System.Net;
using System.Net.Sockets;

namespace MechStellServer
{
    class Server
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MechStell-Server startet...");
            StartServer();
        }

        private static void StartServer()
        {
            IPAddress listenAddress = IPAddress.Parse("0.0.0.0");
            TcpListener serverSocket = new TcpListener(listenAddress, 25025);
            serverSocket.Start();

            while (true)
            {
                serverSocket.AcceptTcpClient();
                Console.WriteLine("Neuer Client!");
            }
        }
    }
}
