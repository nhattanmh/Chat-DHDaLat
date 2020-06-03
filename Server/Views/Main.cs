using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        IPEndPoint ip;
        Socket server;
        List<Socket> lsClient;
        void Connect()
        {
            lsClient = new List<Socket>();
            ip = new IPEndPoint(IPAddress.Any, 5555);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ip);

            Thread listen = new Thread(() => {
                try
                {
                    //chạy vòng lặp để lắng nghe nhiều kết nối
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        lsClient.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    ip = new IPEndPoint(IPAddress.Any, 5555);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }
        void Close()
        {
            server.Close();
        }
        void Send(Socket client)
        {
            //Nếu txt rỗng thì k gửi
            if (txtChat.Text != string.Empty)
                client.Send(Serial(txtChat.Text));
        }
        void AddMess(string s)
        {
            lvChat.Items.Add(new ListViewItem() { Text = s });
            txtChat.Clear();
        }
        // string IP;
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 50000];
                    client.Receive(data);
                    //nhận tin bên server, phân tích data thành chuỗi
                    string mess = (string)DesSerialize(data);
                    foreach (Socket item in lsClient)
                    {
                        if (item != null && item != client)
                            item.Send(Serial(mess));
                        //Lấy địa chỉ IP của client
                        // IP = item.RemoteEndPoint.ToString();
                    }
                    AddMess(mess /*IP + mess*/);


                }
            }
            catch
            {
                lsClient.Remove(client);
                client.Close();
            }
        }
        byte[] Serial(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(stream, obj);
            return stream.ToArray();
        }
        //gom mảnh
        object DesSerialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter format = new BinaryFormatter();
            return format.Deserialize(stream);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (Socket item in lsClient)
            { Send(item); }
            AddMess(txtChat.Text);
            txtChat.Clear();
        }
    }
}
