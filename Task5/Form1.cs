using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblia_Task4;
using MySql.Data.MySqlClient;

namespace Task5
{
    public partial class Form1 : Form
    { 
        // со строки 18 по 54 все эти строки уже использовались в Task3 и Task4
        ConnectDB f2 = new ConnectDB();
        MySqlConnection conn;
        private BindingSource bSource = new BindingSource();
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f2.con();
            conn = new MySqlConnection(f2.connStr);
            data();
        }
        void data()// метод для создание таблицы в гриде, структура почти такая же как и в Task4 и Task3
        {
            conn.Open();
            string com = "SELECT * FROM t_Uchebka_Lebedev";
            table.Clear();
            table.Columns.Clear();
            MyDA.SelectCommand = new MySqlCommand(com, conn);
            dataGridView1.DataSource = bSource;
            bSource.DataSource = table;
            MyDA.Fill(table);

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data();//для обновления грида
        }

        private void button1_Click(object sender, EventArgs e)
        {
          try
          {
           conn.Open();
           string com = $"INSERT t_Uchebka_Lebedev(fioStud,datetimStud) VALUES ('{textBox2.Text}','{textBox1.Text}');";// команда для добавление строка
           MySqlCommand command = new MySqlCommand(com, conn);
           command.ExecuteNonQuery();//строка для перенесение команды в бд
          }
           catch(MySql.Data.MySqlClient.MySqlException)
          {
             MessageBox.Show($"у вас не правильно указана дата или не правильно написано \n Пример: 10.04.21");
          }
          finally
          {
           conn.Close();
          }
            //Первая ошибка MySql.Data.MySqlClient.MySqlException не правильно заполнено хотя таблица с датой может быть пустой :)
            
        }
    }
}
