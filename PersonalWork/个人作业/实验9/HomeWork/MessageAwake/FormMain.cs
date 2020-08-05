using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MessageAwake
{
    public partial class FormMain : Form
    {
        private System.Windows.Forms.NotifyIcon myNotifyIcon;
        private bool isExit = false;
        private int formHeight;

        private int port = 8001;
        private UdpClient udpClient;

        public FormMain()
        {
            InitializeComponent();
            formHeight = 0;
            this.Height = formHeight;
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myNotifyIcon = new NotifyIcon(this.components);
            myNotifyIcon.Icon =  new Icon("demo.ico");
            myNotifyIcon.Text = "网络呼叫提醒\n";
            myNotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            myNotifyIcon.Visible = true;
            myNotifyIcon.DoubleClick += new EventHandler(myNotifyIcon_DoubleClick);

            IPAddress myIP = (IPAddress)Dns.GetHostAddresses(Dns.GetHostName()).GetValue(0);
            textBoxRemoteIP.Text = myIP.ToString();
            Thread myThread = new Thread(new ThreadStart(ReceiveData));
            myThread.Start();
            textBoxSendMessage.Focus();

        }

        void myNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowThisForm();
        }

        private void ShowThisForm()
        {
            this.Height = 0;
            timer1.Enabled = true;
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit == false)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void 结束程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isExit = true;
            udpClient.Close(); 
            Application.Exit();
        }

        private void 呼叫对方ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowThisForm();
        }

        private void ReceiveData()
        {
            udpClient = new UdpClient(port);
            IPEndPoint remote = null;
            while (true)
            {
                try
                {
                    byte[] bytes = udpClient.Receive(ref remote);
                    string str = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                    MessageBox.Show(str, string.Format("收到来自[{0}]的呼叫", remote));
                }
                catch
                {
                    break;
                }
            }
        }
        private void sendData()
        {
            UdpClient myUdpClient = new UdpClient();
            IPAddress remoteIP;
            if (IPAddress.TryParse(textBoxRemoteIP.Text, out remoteIP) == false)
            {
                MessageBox.Show("远程IP格式不正确");
                return;
            }
            IPEndPoint iep = new IPEndPoint(remoteIP, port);
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(textBoxSendMessage.Text);
            try
            {
                myUdpClient.Send(bytes, bytes.Length, iep);
                textBoxSendMessage.Clear();
                myUdpClient.Close();
                textBoxSendMessage.Focus();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "发送失败");
            }
            finally
            {
                myUdpClient.Close();
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            sendData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (formHeight < 235)
            {
                this.Height = formHeight;
                formHeight += 5;
            }
            else
            {
                timer1.Enabled = false;
                formHeight = 0;
            }
        }


    }
}