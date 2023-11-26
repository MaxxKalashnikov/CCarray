using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    //Дан целочисленный массив а[15]. Найдите наименьшее и
    //наибольшее из четных чисел в последовательности чисел а[15].
    //Предусмотрите ситуацию, когда четных чисел в последовательности нет.
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int[] massiv = new int[15];//обяввляем целочисленный массив из 15 сиволов 
            Random rand = new Random();
            int i = 0;
            while (i < massiv.Length)//заполняем массив случайными чслами в диапазоне 100
            {
                massiv[i] = rand.Next(100);
                text1.Text += Environment.NewLine +(i+1) + ") " + massiv[i].ToString();//выводим все элементы массива на экран 
                i++;
            }
            int a = 0;
            while (i < massiv.Length)//считаем количество четных элемнтов в массиве 
            {
                if (massiv[i] % 2 != 0)
                {
                    a = a + 1;
                }
                i++;
            }
            if (a == 15)//предусматриваем ситуацию, когда четных элементов нет 
            {
                text1.Text += Environment.NewLine + "Четных элементов в массиве не существует!"; 
            }
            else
            {
                int min = 900000;
                int max = 0;
                i = 0;
                int j = 0;
                while (i < massiv.Length) //вычисляем минимальный элемент массива
                {
                    if (massiv[i] % 2 == 0 && massiv[i] != 0)
                    {
                        if (massiv[i] < min)
                        {
                            min = massiv[i];
                        }
                        if (massiv[j] > max)
                        {
                            max = massiv[j];
                        }
                    }
                    i++;
                    j++;
                }
                if (min == max)
                {
                    text1.Text += Environment.NewLine + "Максимум и минимум равны между собой и имеют значение " + min.ToString();
                }
                else
                {
                    text1.Text += Environment.NewLine + "Минимальный четный эллемент массива = " + min.ToString();
                    text1.Text += Environment.NewLine + "Максимальный четный эллемент массива = " + max.ToString();
                }
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
        }

        private void cmClose(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
