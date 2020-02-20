using System;

namespace Program52
{
    class Program52
    {
        static void Main(string[] args)
        {
            int i, x, y;

            try

            {

                Console.WriteLine("Введите первое число: ");
                string txt = Console.ReadLine();
                x = Int32.Parse(txt);
                Console.WriteLine("Введите второе число: ");
                txt = Console.ReadLine();
                y = Int32.Parse(txt);

                if (x < y)
                {
                    int[] arr = new int[y - x + 1];
                    Console.Write((arr[0] = x) + " ");
                    i = 1;
                    while (i < arr.Length - 1)
                    {
                        arr[i] = arr[i - 1] + 1;
                        Console.Write(arr[i] + " ");
                        i++;
                    }
                    Console.Write(arr[arr.Length - 1] = y);
                }

                else if (x > y)
                {

                    int[] arr = new int[x - y + 1];
                    Console.Write((arr[0] = y) + " ");
                    i = 1;
                    while (i < arr.Length - 1)
                    {
                        arr[i] = arr[i - 1] + 1;
                        Console.Write(arr[i] + " ");
                        i++;
                    }
                    Console.Write(arr[arr.Length - 1] = x);
                }

                else Console.Write("Введённые числа равны.");
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
