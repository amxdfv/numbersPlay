using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        static int num=100 ;                  // число элементов массива
        static int[] array = new int[num];  // объявляем пока что пустой массив чисел 
        static string a;
        


        public Form1()
        {
            InitializeComponent();

        }

        public void fullArray()         // функция заполнения массива
        {

            Random r = new Random();
            int t;
            for (t = 0; t < num; t++) { 
            array[t] = r.Next(0, 10);
            }
            
        } 
        
        public void ArrToStr()           // функция преобразующая все значения массива в строку для удобста вывода в текстовом формате
        {
            int e = array[0];
            a = e.ToString();
            int b;
            int t;
            for (t = 1; t < num; t++)
            {
                b = array[t];
                a = a + ' ' + b.ToString();
            }
           
        }
        
        public void button1_Click(object sender, EventArgs e)             // заполняем массив по нажатию кнопки
        {
            num = Int32.Parse(textBox1.Text);
            Form1 p = new Form1();     // эта строчка нужна для вызова соответсвующих функций из класса
            p.fullArray();            // заполняем массив
            p.ArrToStr();               // преобразуем массив в  строку
            label1.Text = a;            // выводим значения элементов массива в текстовое поле
            
        }

        public void button2_Click(object sender, EventArgs e)          // подсчет среднего значения
        {
           
            float m = array[0];                 // инциализируем переменную равную первому элемету массива
            int t;
            float s;
            for (t = 1; t < num; t++)          // запускаем цикл который сложи все элементы массива
            {
            m = m + array[t];
            
            }
            s = m / num;                       // делим полученную сумму на количество элементов
            string n = s.ToString();
            label2.Text = n;                   // выводим получившееся число в тесктовом поле
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 p = new Form1();     // строчка нужна для доспука к функции преобразования массива в строку
            int k;                    // счетчик количества циклов
            int fst;                   // первый сравниваемый элемент массива (сокращение от  английского first)
            int scd;                   // второй сравниваемый элемент массива (сокращение от внглийского second)
            int count;                 // переменная обозначающая была ли перестановка элементов массива
            int x;                      // переменная которая на 1 меньше чем число элементов в массиве
            x = num - 1;
            do                                 // цикл, расставляющий элементы массива в нужном порядке
            {
                count = 0;
                for (k = 0; k < x; k++)
                {
                    fst = array[k];
                    scd = array[k + 1];
                    if (scd < fst)
                    {
                        array[k + 1] = fst;
                        array[k] = scd;
                        count = 1;
                    }
                }
            } while (count > 0);

            p.ArrToStr();                       // преобразуем массив встроку
            label2.Text = a;                    // выводим на экран
        }

        public void button4_Click(object sender, EventArgs e)        // аналогично предыдущей функции
        {
            Form1 p = new Form1();
            int k;
            int fst;
            int scd;
            int count;
            int x;
            x = num - 1;
            do
            {
                count = 0;
                for (k = 0; k < x; k++)
                {
                    fst = array[k];
                    scd = array[k + 1];
                    if (scd > fst)
                    {
                        array[k + 1] = fst;
                        array[k] = scd;
                        count = 1;
                    }
                }
            } while (count > 0);
            
            p.ArrToStr();
            label2.Text = a;
        }

        
    }
}
