using System;

namespace Program21
{
    class Program21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            string num = Console.ReadLine();
            int n, m, s, d;
            n = Int32.Parse(num);
            Console.WriteLine("Введите второе число: ");
            num = Console.ReadLine();
            m = int.Parse(num);
            s = n + m;
            d = n - m;
            Console.WriteLine("Введённые числа: " + n + ", " + m + "\nСумма чисел равна: " + s + 
                "\nРазность чисел равна: " + d);
            Console.ReadLine();
        }
    }
}
