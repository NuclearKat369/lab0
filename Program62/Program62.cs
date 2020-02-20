using System;

namespace Program62
{
    class Program62
    {
        static void Main(string[] args)
        {
            int q, sum, i, r;

            try
            {

                Console.WriteLine("Введите целое число: ");
                string txt = Console.ReadLine();
                q = Int32.Parse(txt);

                Console.WriteLine("Суммируемые числа: ");

                int[] arr = new int[q];
                Random rand = new Random();
                sum = 0;
                i = 0;
                while (i < q)
                {
                    r = rand.Next(100);
                    if (r % 5 == 2 || r % 3 == 1)
                    {
                        arr[i] = r;
                        sum = sum + arr[i];
                        Console.Write(arr[i] + " ");
                        i++;
                    }
                }
                Console.WriteLine();

                Console.WriteLine("Сумма чисел равна: " + sum);
                Console.ReadLine();

            }

            catch
            {
                Console.WriteLine("Ошибка!");
                Console.ReadLine();
            }

        }
    }
}
