using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;

namespace TroianServer
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 30021;
            TcpListener server = new TcpListener(System.Net.IPAddress.Parse("192.168.21.89"), port);
            TcpClient client;
            String username;
            
            try
            {
                server.Start();
                Console.WriteLine("Waiting for a connection...");
                client = server.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                
                while (true)
                {
                    username = Messages.ReceiveMessage(stream);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
