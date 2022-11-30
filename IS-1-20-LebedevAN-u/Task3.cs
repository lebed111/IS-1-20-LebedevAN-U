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

            conn.Close();
        }
    }
}
