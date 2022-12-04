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
using biblia_Task4;

namespace Task4
{
    public partial class Task4 : Form
    {
        ConnectDB f2 = new ConnectDB();// обявление переменной класса 
        MySqlConnection conn;
        private BindingSource bSource = new BindingSource();
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        DataTable table = new DataTable();
        public Task4()
        {
            InitializeComponent();
        }

        private void Task4_Load(object sender, EventArgs e)
        {
            //подключение к бд через класс
            f2.con();
            conn = new MySqlConnection(f2.connStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // создание таблицы в гриде
            conn.Open();
            table.Clear();
            table.Columns.Clear();
            string com = "SELECT * FROM t_datatime;";//команда для вызова всех столбцов в таблице
            MyDA.SelectCommand = new MySqlCommand(com, conn);
            dataGridView1.DataSource = bSource;
            bSource.DataSource = table;
            MyDA.Fill(table);
            //не показывает 1 и 4 стобец
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            // не дает в них ничего менять
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            // делает столбцы по всей длине
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            conn.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try//нужно чтоб случайно не вылезла ошибка :)
            {
                conn.Open();
                int rowIndex = e.RowIndex;// индекст строки
                int conIndex = e.ColumnIndex;// индекс столбца
                DataGridViewRow row = dataGridView1.Rows[rowIndex];//Получаем значение при клики
                if (conIndex == 1)
                {
                    string com = $"SELECT photoUrl FROM t_datatime WHERE id = {row.Cells[conIndex - 1].Value.ToString()} ;";//команда чтоб забрать ссылку на картинку
                    MySqlCommand command = new MySqlCommand(com, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        pictureBox1.ImageLocation = reader[0].ToString();// вставляем ссылку на картинку
                    }
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
        }
    }
}
