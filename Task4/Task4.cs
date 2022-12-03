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

namespace Task4
{
    public partial class Task4 : Form
    {
        biblia_Task4.ConnectDB f2;
        MySqlConnection conn;
        public Task4()
        {
            InitializeComponent();
        }

        private void Task4_Load(object sender, EventArgs e)
        {
            f2.con();
            conn = new MySqlConnection(f2.connStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            conn.Close();
        }
    }
}
