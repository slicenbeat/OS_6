using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new ClientForm(args[0]));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сначала запустите сервер, затем клиент.", "Ошибка клиента");
            }
        }
    }
}
