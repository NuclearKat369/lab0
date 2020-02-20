using System;

namespace Program51
{
    class Program5
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число: ");
                string txt = Console.ReadLine();
                int x = Int32.Parse(txt);
                Console.WriteLine("Введите второе число: ");
                txt = Console.ReadLine();
                int y = Int32.Parse(txt); 
                
                if (x < y)
                {
                    int[] arr = new int[y - x + 1];
                    Console.Write((arr[0] = x) + " ");
                    for (int i = 1; i < arr.Length - 1; i++)
                    {
                        arr[i] = arr[i - 1] + 1;
                        Console.Write(arr[i] + " ");
                    }
                    Console.Write(arr[arr.Length - 1] = y);
                }

                else if (x > y)
                {
                    int[] arr = new int[x - y + 1];
                    Console.Write((arr[0] = y) + " ");
                    for (int i = 1; i < arr.Length - 1; i++)
                    {
                        arr[i] = arr[i - 1] + 1;
                        Console.Write(arr[i] + " ");
                    }
                Console.Write(arr[arr.Length - 1] = x);
                }
                
                else Console.WriteLine("Введённые числа равны.");
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

