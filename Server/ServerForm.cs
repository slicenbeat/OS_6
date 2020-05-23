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

namespace Server
{
    public partial class ServerForm : Form
    {
        Dictionary<string, string> database; 
        int port = 8005;
        Socket ListenSocket; 
        Socket Handler; 
        IPEndPoint IPPoint; 

        List<Socket> list_socks;
        Thread thread_for_working_sock;
        List<Thread> threads;
        List<Process> processes;

        string request;
        string answer;
        int count;

        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            int number_str = 1;
            try
            {
                database = new Dictionary<string, string>();
                using (StreamReader Reader = new StreamReader("database.txt", Encoding.GetEncoding("windows-1251")))
                {
                    string buffer;
                    while ((buffer = Reader.ReadLine()) != null)
                    {
                        string[] QA = buffer.Split('—');
                        if (QA[0] == "" || QA[1] == "")
                        {
                            throw new Exception("Поля для запроса или ответа, расположенные " + number_str.ToString() + " строке, скорее всего, пустые.\nПерепроверьте документ.");
                        }
                        if (QA[0].Length > 400 || QA[1].Length > 400)
                        {
                            throw new Exception("Длина запроса или ответа, расположенного в " + number_str.ToString() + " строке, превышает 400 символов.\nПерепроверьте документ.");
                        }
                        database.Add(QA[0], QA[1]);
                        number_str++;
                    }
                }
                if(database.Count == 0)
                {
                    throw new Exception("Файл пуст!");
                }

                LogBox.Text += DateTime.Now.ToString("HH:mm:ss");
                LogBox.Text += ": База данных подключена." + Environment.NewLine;

                ListenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сервера");
                Environment.Exit(0);
            }

            ListenSocket.Bind(IPPoint);
            LogBox.Text += DateTime.Now.ToString("HH:mm:ss");
            LogBox.Text += ": Сервер готов к приему запросов." + Environment.NewLine;
        }

        public void ClientHandler(object ind)
        {
            bool flag = false;
            int index = (int)ind;
            Action action;

            while (true)
            {
                StringBuilder builder = new StringBuilder();
                int bytes = 0; 
                byte[] data = new byte[256];
                do
                {
                    try
                    {
                        bytes = list_socks[index].Receive(data);
                    }
                    catch (SocketException ex)
                    {
                        action = () => LogBox.Text += DateTime.Now.ToString("HH:mm:ss");
                        Invoke(action);
                        action = () => LogBox.Text += ": Клиент #" + (index + 1).ToString() + " отключился" + Environment.NewLine;
                        Invoke(action);
                        flag = true;
                        break;
                    }
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (list_socks[index].Available > 0);
                if (flag == true) break;
                request = builder.ToString();
                answer = "";

                action = () => LogBox.Text += DateTime.Now.ToString("HH:mm:ss");
                Invoke(action);
                if (database.TryGetValue(request, out answer))
                {
                    action = () => LogBox.Text += ": Сервер нашёл информацию для клиента #"+ (index + 1).ToString() +" по запросу: \"" + request + "\"" + Environment.NewLine;
                    Invoke(action);
                }
                else
                {
                    action = () => LogBox.Text += ": Сервер не нашёл информацию для клиента #" + (index + 1).ToString() + " по запросу: \"" + request + "\"" + Environment.NewLine;
                    answer = "Информации по данному запросу нет...";
                    Invoke(action);
                }
                data = Encoding.Unicode.GetBytes(answer);
                list_socks[index].Send(data);
            }
        }
        private void ClientsBar_Scroll(object sender, EventArgs e)
        {
            if (ClientsBar.Value == 1)
            {
                bStartClient.Text = "Подключить 1 клиента";
            }
            else bStartClient.Text = "Подключить " + ClientsBar.Value + " клиентов";
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                list_socks[i].Shutdown(SocketShutdown.Both);
                list_socks[i].Close();
                threads[i].Abort();
                threads[i].Join(500);
                try
                {
                    processes[i].Kill();
                }
                catch (Exception ex)
                {

                }
            }
            
            if (list_socks != null || threads != null || processes != null)
            {
                list_socks.Clear();
                threads.Clear();
                processes.Clear();
            }
        }
           

        private void bStartClient_Click(object sender, EventArgs e)
        {
            ListenSocket.Listen(ClientsBar.Value);

            processes = new List<Process>();
            list_socks = new List<Socket>();
            threads = new List<Thread>();
            bStartClient.Enabled = false;
            bDeleteClients.Enabled = true;
            count = ClientsBar.Value;

            ProcessStartInfo prc = new ProcessStartInfo();

            for (int i = 0; i < ClientsBar.Value; i++)
            {
                prc.FileName = "C:\\Users\\Дамир\\Desktop\\os_lab_6\\Client\\bin\\Debug\\Client.exe";
                prc.Arguments = (i + 1).ToString();
                processes.Add(Process.Start(prc));
                Handler = ListenSocket.Accept();
                list_socks.Add(Handler);
                thread_for_working_sock = new Thread(new ParameterizedThreadStart(ClientHandler));
                thread_for_working_sock.Start(i);
                threads.Add(thread_for_working_sock);

            }
            LogBox.Text += DateTime.Now.ToString("HH:mm:ss");
            if (ClientsBar.Value == 1)
            {
                LogBox.Text += ": Подключили " + ClientsBar.Value.ToString() + " клиента." + Environment.NewLine;
            }
            else LogBox.Text += ": Подключили " + ClientsBar.Value.ToString() + " клиентов." + Environment.NewLine;
        }

        private void LogBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bDeleteClients_Click(object sender, EventArgs e)
        {
            bStartClient.Enabled = true;
            bDeleteClients.Enabled = false;
            for (int i = 0; i < count; i++)
            {
                list_socks[i].Shutdown(SocketShutdown.Both);
                list_socks[i].Close();
                threads[i].Abort();
                threads[i].Join(500);
                try
                {
                    processes[i].Kill();
                }
                catch (Exception ex)
                {
                    
                }
            }
            count = 0;
            LogBox.Text += DateTime.Now.ToString("HH:mm:ss");
            LogBox.Text += ": Клиенты сброшены." + Environment.NewLine;
            list_socks.Clear();
            threads.Clear();
            processes.Clear();

        }

        private void сохранитьЛогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileTxt.FileName = DateTime.Now.ToString("yyyy-dd-MM ddd HH-mm-ss");
            string path;
            if (SaveFileTxt.ShowDialog() == DialogResult.OK)
            {
                path = SaveFileTxt.FileName;
                using (StreamWriter writer = new StreamWriter(path, false, Encoding.GetEncoding(1251)))
                {
                    writer.WriteLine(LogBox.Text);
                    writer.Close();
                }

            }
        }

        private void SaveDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void открытьЛогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogBox.Clear();
            string path;
            if (OpenFileTxt.ShowDialog() == DialogResult.OK)
            {
                path = OpenFileTxt.FileName;
                using (StreamReader reader = new StreamReader(path, Encoding.GetEncoding(1251)))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        LogBox.Text += line + Environment.NewLine;
                    }
                }

            }
        }
    }
}