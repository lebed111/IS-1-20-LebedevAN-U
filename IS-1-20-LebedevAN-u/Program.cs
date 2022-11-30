using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_LebedevAN_u
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }

    }
    public class Connection
    {
        public string host = "10.90.12.110";
        //public string host = "chuc.caseum.ru";
        public string port = "33333";
        public string user = "st_1_20_19";
        public string data = "is_1_20_st19_KURS";
        public string passwprd = "14313537";
        public string connStr;
        public string con()
        {
            return connStr = $"server={host};port={port};user={user};database={data};password={passwprd};";
        }
    }
}
