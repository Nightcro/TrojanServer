using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TroianServer
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 30021;
            TcpListener server = new TcpListener(System.Net.IPAddress.Parse("192.168.21.89"), port);
            TcpClient client;

            try
            {
                server.Start();

                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    Byte[] bytes = new byte[1024];
                    // Loop to receive all the data sent by the client.
                    i = stream.Read(bytes, 0, bytes.Length);
                    String msg = bytes.ToString();

                    Console.WriteLine(msg);
                    client.Close();
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
