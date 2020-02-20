using System;

namespace Program3
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            string txt = Console.ReadLine();
            int x = Int32.Parse(txt);
            int y = 0, k = 1;
            while (x > 0)
            {
                y = (k * (x % 2)) + y;
                k = k * 10;
                x = x / 2;

            }
            Console.WriteLine("Введённое число в двоичной системе: " + y.ToString("D4"));

            if ((y / 10) % 2 == 1)
            {
                y = y - 10;
            }
            else y = y + 10;

            Console.WriteLine(y.ToString("D4"));
            Console.ReadLine();
        }
    }
}
