using System;

namespace Program61
{
    class Program61
    {
        static void Main(string[] args)
        {
            int q, sum;

            try
            {

                Console.WriteLine("Введите целое число: ");
                string txt = Console.ReadLine();
                q = Int32.Parse(txt);

                Console.Write("Суммируемые числа: ");

                int[] arr = new int[q];
                Random rand = new Random();
                sum = 0;
                for (int i = 0; i < q; i++)
                {
                    int r = rand.Next(100);
                    if (r % 5 == 2 || r % 3 == 1)
                    {
                        arr[i] = r;
                        sum = sum + arr[i];
                        Console.Write(arr[i] + " ");
                    }
                    else i--;
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
