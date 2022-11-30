
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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            
        }   
        HDD hdd;
        Videocard vid;
        abstract class  Accessories
        {
            public int price;
            public string age;
            public string Articyl;// для чего оно нужно черт возьми
            public Accessories(int a, string c, string d)
            {
                price = a;
                age = c;
                Articyl = d;
            }
            public void Display()
            {
            }

        }
        class HDD : Accessories
        {
            int Revolutions { set; get; }
            string Interface { set; get; }
            int Volume { set; get; }
            public HDD(int a, string c, int rev, string i, int vol, string d):base (a,c,d)
            {
                Revolutions = rev;
                Interface = i;
                Volume = vol;
            }

          public new string Display()
          {
               return ($"Цена {price},Год создания {age},Количество оборотов {Revolutions},Интерфейс {Interface},Объем памяти {Volume}, Артикуул {Articyl}");
           }
        }
        class Videocard : Accessories
        {
            int CPU { set; get; }
            int Manufacturer { set; get; }
            int Memory { set; get; }
            public Videocard(int a , string c , int cpu , int man , int mem, string d ) : base(a , c, d)
            {
                CPU = cpu;
                Manufacturer = man;
                Memory = mem; 
            }
            public new string Display()
            {
                return ($"Цена {price},Год создания {age},ЧастотаCPU {CPU},Производительность {Manufacturer},Обем памяти {Memory}, Артикул {Articyl}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                hdd = new HDD(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text), textBox9.Text);
                listBox1.Items.Add(hdd.Display());
            }
            catch
            {
                MessageBox.Show("Ведите данные");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                vid = new Videocard(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), textBox9.Text);
                listBox1.Items.Add(vid.Display());
            }
            catch
            {
                MessageBox.Show("Ведите данные");
            }
        }
    }
}
