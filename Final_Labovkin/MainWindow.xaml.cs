using System;
using System.Data;
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
using System.Globalization;

namespace Lab1WpfApp1_Labovkin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //переменная, обозначающая действие
        public string Act;
        //переменная, набранное число
        public string Num1;
        //переменная, означающая, что мы начали набирать второе число
        public bool flag;

        public MainWindow()
        {
            flag = false;
            InitializeComponent();
        }

        // набор цифр от 0 до 9
        private void Button_Click_Nums(object sender, RoutedEventArgs e)
        {
            //при наборе второго числа, первое стирается 
            if (flag)
            {
                flag = false;
                textBox.Text = "0";
            }
            Button b = (Button)sender;
            if (textBox.Text == "0")
                textBox.Text = b.Content.ToString();
            else
                textBox.Text += b.Content.ToString();
        }
        //кнопка для стирания значений
        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
        }
        //метод запоминает последнее действие и число введенное после него
        private void Button_Click_Oper(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Act = b.Content.ToString();
            Num1 = textBox.Text;
            flag = true;
        }
        //мметод выполняющий математическую операцию
        private void Button_Click_Equal(object sender, RoutedEventArgs e)
        {
            //переменные для хранения значения
            double num1, num2, result;
            result = 0;
            num1 = Convert.ToDouble(Num1);
            num2 = Convert.ToDouble(textBox.Text);
            if (Act == "+")
            {
                result = num1 + num2;
            }
            if (Act == "-")
            {
                result = num1 - num2;
            }
            if (Act == "*")
            {
                result = num1 * num2;
            }
            if (Act == "/")
            {
                result = num1 / num2;
            }
            Act = "=";
            flag = true;
            textBox.Text = result.ToString();
        }
        //метод, меняющий знак числа
        private void Button_Click_Plus_Minus(object sender, RoutedEventArgs e)
        {
            double num, result;
            num = Convert.ToDouble(textBox.Text);
            result = -num;
            textBox.Text = result.ToString();
        }
        //метод, добавляющий запятую, для вещественных чисел
        private void Button_Click_Point(object sender, RoutedEventArgs e)
        {
            //проверяем, есть ли уже запятая
            if (!textBox.Text.Contains(","))
                textBox.Text = textBox.Text + ",";
        }
        //метод, вычисляющий корень числа
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double num, result;
            num = Convert.ToDouble(textBox.Text);
            result = Math.Sqrt(num);
            textBox.Text = result.ToString();
        }
    }
}






























//            //перебираем все элементы,которые находятся внутри сетки MainGrid
//            foreach (UIElement el in MainRoot.Children)
//            {
//                if (el is Button)
//                {
//                    ((Button)el).Click += Button_Click;
//                }
//            }
//        }
//            private void Button_Click(object sender, RoutedEventArgs e)
//        {

//            {
//                string str = ((Button)e.OriginalSource).Content.ToString();

//                if (str == "AC")
//                    textBox.Clear();

//                else if (str == "=")
//                {

//                    textBox.Text = new DataTable().Compute(textBox.Text, null).ToString();

//                }
//                else textBox.Text += str;
//            }
//        }
//    }
//}






















