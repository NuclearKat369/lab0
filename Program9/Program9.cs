using System;

namespace Program9
{
    class Program9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов: ");
            string txt = Console.ReadLine();
            int n = Int32.Parse(txt);
            Random rand = new Random();
            int[] arr = new int[n];
            Console.WriteLine("Сформирован ряд чисел: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(99);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное и минимальное значение заданного ряда чисел: ");
            int[] newarr = new int[2];
            newarr = getNums(arr);
            Console.WriteLine(string.Join(", ", newarr));

            static int [] getNums(params int[] a)
            {
                Array.Sort(a);
                int[] n = new int[2];
                n[0] = a[a.Length - 1];
                n[1] = a[0];                
                return n;
            }
            Console.ReadLine();
        }

    }
}