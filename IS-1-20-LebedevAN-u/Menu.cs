using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_LebedevAN_u
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task1 task = new Task1();
            task.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task2 task = new Task2();
            task.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task3 task = new Task3();
            task.ShowDialog();
        }
    }
}
