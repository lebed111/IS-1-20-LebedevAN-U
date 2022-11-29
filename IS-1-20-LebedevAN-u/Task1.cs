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
        //Я надеюсь что тут можно было использовать делегаты
        public Task1()
        {
            InitializeComponent();
            
        }
        public delegate void aaaa(string mes);
        public void listbox(string mes) =>  listBox1.Items.Add(mes);      
        HDD hdd;
        Videocard vid;
        abstract class  Accessories
        {
            public aaaa Helpaa;
            public int price;
            public string age;
            public Accessories(int a, string c)
            {
                price = a;
                age = c;               
            }
            public void Display()
            {
            }
            public void RegisterHandler(aaaa del)
            {
                Helpaa = del;
            }
        }
        class HDD : Accessories
        {
            int Revolutions { set; get; }
            string Interface { set; get; }
            int Volume { set; get; }
            public HDD(int a, string c, int rev, string i, int vol):base (a,c)
            {
                Revolutions = rev;
                Interface = i;
                Volume = vol;
            }

          public new void Display()
          {
                Helpaa?.Invoke($"Цена {price},Год создания {age},Количество оборотов {Revolutions},Интерфейс {Interface},Объем памяти {Volume}");
           }
        }
        class Videocard : Accessories
        {
            int CPU { set; get; }
            int Manufacturer { set; get; }
            int Memory { set; get; }
            public Videocard(int a , string c , int cpu , int man , int mem ) : base(a , c)
            {
                CPU = cpu;
                Manufacturer = man;
                Memory = mem; 
            }
            public new void Display()
            {
                Helpaa?.Invoke($"Цена {price},Год создания {age},ЧастотаCPU {CPU},Производительность {Manufacturer},Обем памяти {Memory}");
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
                hdd = new HDD(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text));
                hdd.RegisterHandler(listbox);
                hdd.Display();
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
                vid = new Videocard(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text));
                vid.RegisterHandler(listbox);
                vid.Display();
            }
            catch
            {
                MessageBox.Show("Ведите данные");
            }
        }
    }
}
