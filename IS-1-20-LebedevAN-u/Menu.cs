using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task4;
using Task5;
// сдесь нет остальных Task, так как при разделении их на проекты, я перенес их так что не надо было их указывать(магия)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // а этот вообще не хочет использоваться в пространстве именн
           Task4.Task4 task = new Task4.Task4();
            task.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // забыл переменовать в Task5, а делать это щас лень
            Form1 task = new Form1();
            task.ShowDialog();
        }
    }
}
