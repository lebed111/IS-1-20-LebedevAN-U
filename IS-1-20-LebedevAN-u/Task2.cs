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
            string Host;
            string Port;
            string User;
            string BD;
            string Password;
            public string connStr;
            public BDMysql(string a, string s, string d, string w, string e)
            {
                Host = a;
                Port = s;
                User = d;
                BD = w;
                Password = e;
            }
            public string Conect()
            {
               return connStr = $"server={Host};port={Port};user={User};database={BD};password={Password};";               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mysql = new BDMysql(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
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
