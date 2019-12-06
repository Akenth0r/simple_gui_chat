using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Client
{
    public partial class Form1 : Form
    {
        Client client;
        public Form1()
        {
            InitializeComponent();
            client = new Client();
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Length == 0)
            {
                MessageBox.Show("Enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            client.Start(tbIP.Text, Convert.ToInt32(tbPort.Text), this.tBoxOut, this.tBoxIn, tbUsername.Text);
           
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            try
            {
                client.Send();
            }
            catch (Exception)
            {
                MessageBox.Show("Connect to the server before sending messages!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Stop();
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect();
        }
    }
}
