using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;

namespace Client
{
    public partial class ClientForm : Form
    {
        int port = 8005;
        Socket Socket;
        IPEndPoint IPPoint;
        string address = "127.0.0.1";
        byte[] data;
        string request;
        string number;
        public ClientForm(string number)
        {
            this.number = number;
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            this.Text = "Клиент #" + number;
            IPPoint = new IPEndPoint(IPAddress.Parse(address), port);
            Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket.Connect(IPPoint);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                request = RequestBox.Text;
                if (RequestBox.Text.Length == 0)
                {
                    throw new Exception("Запрос пуст. Введите что-нибудь.");
                }
                
                if (RequestBox.Text.Length > 400)
                {
                    throw new Exception("Длина запроса превышает 400 символов...");
                }


                data = Encoding.Unicode.GetBytes(request);
                try
                {
                    Socket.Send(data);
                    data = new byte[256]; 
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0; 

                    do
                    {
                        bytes = Socket.Receive(data, data.Length, 0);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (Socket.Available > 0);

                    AnswerBox.Text = builder.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Закройте окна всех активных клиентов и запустите сервер.", "Ошибка клиента");
                    Environment.Exit(0);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка клиента");
                RequestBox.Clear();
            }
        }

        private void AnswerBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RequestBox.Clear();
            AnswerBox.Clear();
        }

        private void RequestBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RequestBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
