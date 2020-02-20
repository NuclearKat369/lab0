using System;

namespace Program14
{
    class Program14
    {
        static void Main(string[] args)
        {
            Rand x = new Rand();

            Console.WriteLine(x.ToString());
            Console.ReadLine();
        }
    }

    public class Rand
    {

        int[] arr;

        public Rand()
        {
            Random r = new Random();
            arr = new int[r.Next(30)];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(200);
            }
           
        }
        
        public override string ToString()
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            string str = "Массив: " + string.Join("--", arr) + "\n" +
                "Количество Элементов: " + arr.Length + "\n" + "Среднее значение элементов массива: " +
                (double)(sum / arr.Length);
            return str;
        }
    }
}
