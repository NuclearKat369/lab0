using System;

namespace Program11
{
    class Program101
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            String txt = Console.ReadLine();
            int a, b, c;
            a = Int32.Parse(txt);
            b = a - 1;
            c = a + 1;
            Console.WriteLine(b + ", " + a + ", " + c);
            Console.ReadLine();
        }
    }
}
