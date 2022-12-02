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
    public partial class Task3 : Form
    {
        Connection f2 =  new Connection();
        MySqlConnection conn;
        private BindingSource bSource = new BindingSource();
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        DataTable table = new DataTable();
        public Task3()
        {
            InitializeComponent();
            
        }

        private void Task3_Load(object sender, EventArgs e)
        {
            f2.con();
            conn = new MySqlConnection(f2.connStr);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            table.Clear();
            table.Columns.Clear();
            string coooom = "SELECT Client.id_cl,Orders.id_cl,Orders.id_ta,Orders.date_or FROM Orders INNER JOIN Client ON Client.id_cl = Orders.id_cl ORDER BY Client.id_cl; ";// это команда с INNER JOIN 
            MyDA.SelectCommand = new MySqlCommand(coooom,conn);
            dataGridView1.DataSource = bSource;
            bSource.DataSource = table;
            MyDA.Fill(table);

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.ColumnHeadersVisible = true;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            string com = $"SELECT * FROM Client ";

            conn.Close();
        }
    }
}
