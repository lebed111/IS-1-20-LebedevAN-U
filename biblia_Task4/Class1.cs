using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace biblia_Task4
{
    public class ConnectDB
    {
        //public string host = "10.90.12.110";// делал это в чюки поэтому и две строки подключения 
        public string host = "chuc.caseum.ru";
        public string port = "33333";
        public string user = "st_1_20_19";
        public string data = "is_1_20_st19_KURS";
        public string passwprd = "14313537";
        public string connStr;
        public string con()// строка подключения
        {
            return connStr = $"server={host};port={port};user={user};database={data};password={passwprd};";
        }
    }
}
