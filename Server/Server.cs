using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    class Server
    {
        bool isRunning;
        Socket listenSocket;
        TextBox tBox;
        List<Socket> clients;


        public Server()
        {
           
        }

        public Server(string ip, int port, TextBox tBox)
        {
            Start(ip, port, tBox);
        }

        public bool IsRunning
        { get { return this.isRunning; } }

        public void Start(string ip, int port, TextBox tBox)
        {
            
            this.tBox = tBox;
            // Ip:port
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            // Make a socket
            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listenSocket.Bind(ipPoint);
            tBox.AppendText("Creating a server...");
            tBox.AppendText(Environment.NewLine);
            listenSocket.Listen(10);
            clients = new List<Socket>();
        }

        public void ListenToConnection()
        {
            isRunning = true;
            while (isRunning)
            {
                Socket user = listenSocket.Accept();
                clients.Add(user);
                tBox.AppendText("User connected");
                tBox.AppendText(Environment.NewLine);
                Thread thread = new Thread(() => ListenToClient(user));
                thread.Start();
            }

        }

        public void ListenToClient(Socket user)
        {
            while (isRunning)
            {
                int bytes = 0;
                byte[] data = new byte[512];
                try
                {
                    do
                    {
                        bytes = user.Receive(data);

                    }
                    while (user.Available > 0);
                }
                catch (Exception) 
                {
                    tBox.AppendText("User disconnected.");
                    tBox.AppendText(Environment.NewLine);
                    break;
                }

                    tBox.AppendText(System.Text.Encoding.Unicode.GetString(data));
                    tBox.AppendText(Environment.NewLine);

                try
                {
                    foreach (Socket client in clients)
                    {
                            client.Send(data);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            clients.Remove(user);
            user.Shutdown(SocketShutdown.Both);
            user.Close();
           
        }
        public void Stop()
        {
            isRunning = false;
        }
    }
}
