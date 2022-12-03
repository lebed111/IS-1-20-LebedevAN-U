using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_20_LebedevAN_u
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }
        public MySqlConnection conn;
        BDMysql mysql;
        class BDMysql
        {
            string Host = "chuc.caseum.ru"; // тут два поля так как я это ещё тестил в чюки
            //string Host = "10.90.12.110";
            string Port = "33333";
            string User = "uchebka";
            string BD = "uchebka";
            string Password = "uchebka";
            public string connStr;

            public string Conect() //возвращение строки подключения через return
            {
               return connStr = $"server={Host};port" +
                    $"={Port};user={User};database={BD};password={Password};";               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try//само подключение вне класса
            {
                mysql = new BDMysql();
                mysql.Conect();
                conn = new MySqlConnection(mysql.connStr);
                conn.Open();
                conn.Close();    
                MessageBox.Show("Успех");
                
            }
            catch
            {
                MessageBox.Show("ПРОВАЛ");
            }
        }
    }
}
