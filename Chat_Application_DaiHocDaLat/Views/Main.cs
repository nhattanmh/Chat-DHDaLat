using Chat_Application_DaiHocDaLat.BLL;
using MaterialSkin;
using MaterialSkin.Controls;
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

namespace Chat_Application_DaiHocDaLat.Views
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Cyan300, Primary.Cyan500, Primary.DeepOrange800, Accent.Cyan700, TextShade.BLACK);
            CheckForIllegalCrossThreadCalls = false;
            DisplayClientOnline();
            
            Connect();
        }
        void DisplayClientOnline()
        {
          DataTable data= BllClient.Instance.Client.DisplayClientOnline();
            foreach (DataRow dtRow in data.Rows)
            {
                    lb_ClientOnline.Items.Add(dtRow.ItemArray[0]);
                
            }
                Task.Run(async () => {
                    for (;;)
                    {
                        await Task.Delay(5000);
                        lb_ClientOnline.Items.Clear();
                        DataTable Data = BllClient.Instance.Client.DisplayClientOnline();
                        foreach (DataRow dtRow in Data.Rows)
                        {
                            lb_ClientOnline.Items.Add(dtRow.ItemArray[0]);

                        }
                    }
                });

            }
        IPEndPoint ip;
        Socket client;
       
        void Connect()
        {
            ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5555);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try { client.Connect(ip); }
            catch
            {
              
                MessageBox.Show("Không thể kết nối đến server...", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        void Close()
        {
            client.Close();
        }
        void Send()
        {
            //Nếu txt rỗng thì k gửi
            if (txtChat.Text != string.Empty)
                client.Send(Serial(txtChat.Text));
        }
        //add tin nhắn vào listview
        void AddMess(string s)
        {
            lvChat.Items.Add(new ListViewItem() { Text = s });
            txtChat.Clear();
        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 50000];
                    client.Receive(data);
                    //nhận tin bên server, phân tích data thành chuỗi
                    string mess = (string)DesSerialize(data);
                    AddMess(mess);
                }
            }
            catch
            {
                Close();
            }
        }
        //phân mảnh dữ liệu
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

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            BllClient.Instance.Client.setStatusOffline(this.Text);
        }

        private void mtrButtonPass_Click(object sender, EventArgs e)
        {

        }

        private void mtrButtonPass_Click_1(object sender, EventArgs e)
        {
            Send();
            AddMess(txtChat.Text);
        }
    }
}
