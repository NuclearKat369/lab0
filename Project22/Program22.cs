using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Project22
{
    class Program22
    {
        static void Main(string[] args)
        {
            
            int n, m, s, d;
            string num = Interaction.InputBox("Ваше число: ", "Введите первое число: ");
            n = Int32.Parse(num);
            num = Interaction.InputBox("Ваше число: ", "Введите второе число: ");
            m = Int32.Parse(num);
            s = n + m;
            d = n - m;
            MessageBox.Show("Введённые числа: " + n + ", " + m + "\nСумма чисел равна: " + s +
                "\nРазность чисел равна: " + d, "Вычисления");
                       
        }
    }
}