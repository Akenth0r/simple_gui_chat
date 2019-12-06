using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class fServer : Form
    {
        Thread serverThread;
        Server server;
        public fServer()
        {
            server = new Server();
            InitializeComponent();
        }

        private void bStartServer_Click(object sender, EventArgs e)
        {
            if (!server.IsRunning)
            {
                server.Start(tbIP.Text, Convert.ToInt32(tbPort.Text), tbConsole);
                serverThread = new Thread(server.ListenToConnection);
                serverThread.IsBackground = true;
                serverThread.Start();
            }
        }

        ~fServer()
        {
        }

        private void fServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Stop();
        }

        private void bStopServer_Click(object sender, EventArgs e)
        {
            server.Stop();
        }
    }
}
