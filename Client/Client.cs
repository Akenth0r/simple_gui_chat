using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    class Client
    {
        bool isRunning;
        Socket client;
        byte[] data;
        TextBox tBoxOut;
        TextBox tBoxIn;
        string Username;
        public Client()
        {
        }

        public Client(string ip, int port, TextBox tBoxOut, TextBox tBoxIn, string username)
        {
            Start(ip, port, tBoxOut, tBoxIn, username);
        }

        public void Start(string ip, int port, TextBox tBoxOut, TextBox tBoxIn, string username)
        {
            if (!isRunning)
            {
                this.Username = username;
                this.tBoxOut = tBoxOut;
                this.tBoxIn = tBoxIn;
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(ip), port);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    client.Connect(ipPoint);
                    tBoxOut.AppendText("Connected to the server.");
                    tBoxOut.AppendText(Environment.NewLine);
                }
                catch (Exception)
                {
                    MessageBox.Show("Server is not responding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                data = new byte[512];
                isRunning = true;
                Thread clientThread = new Thread(this.ListenToServer);
                clientThread.IsBackground = true;
                clientThread.Start();
            }
        }

        public bool IsRunning
        { get { return this.isRunning; } }

        public void Stop()
        {
            this.isRunning = false;
            
        }

        public void Send()
        {
            if (this.tBoxIn.TextLength <= 0)
                return;
            client.Send(Encoding.Unicode.GetBytes("[" + DateTime.Now.ToLongTimeString() + "] " + Username + ": " + tBoxIn.Text));
            tBoxIn.Clear();
        }

        public void ListenToServer()
        {
            while (this.isRunning)
            {
                try
                {
                    do
                    {
                        int bytes = 0;
                        bytes = client.Receive(data);
                    }
                    while (client.Available > 0);
                    tBoxOut.AppendText(System.Text.Encoding.Unicode.GetString(data));
                    tBoxOut.AppendText(Environment.NewLine);
                }
                catch (Exception)
                {
                    if (isRunning)
                        MessageBox.Show("Disconnected from server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            try
            {
                client.Disconnect(false);
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            catch (Exception) { }
        }

        public void Disconnect()
        {
            try
            {
                client.Disconnect(false);
                client.Shutdown(SocketShutdown.Both);
                client.Close();
                Stop();
                tBoxOut.AppendText("Disconnected from server.");
                tBoxOut.AppendText(Environment.NewLine);
            }
            catch (Exception) { MessageBox.Show("You are not connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
        }

    }
}
