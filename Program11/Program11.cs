using System;

namespace Program11
{
    class Program11
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите желаемое количество чисел: ");
            string txt = Console.ReadLine();
            int n = Int32.Parse(txt);

            Random rand = new Random();

            int[] nums = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(100);
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Максимальное значение в массиве равно: " + ops.getMax(nums));
            Console.WriteLine("Минимальное значение в массиве равно: " + ops.getMin(nums));
            Console.WriteLine("Среднее значение в массиве равно: " + ops.getMid(n, nums));
            Console.ReadLine();
        }
    }

    public class ops
    {
        
        public static int getMax(params int[] a)
        {

            int[] sortA = a;              
            Array.Sort(sortA);
            return sortA[sortA.Length - 1];

        }

        public static int getMin(params int[] b)
        {

            int[] sortB = b;        
            Array.Sort(sortB);
            return sortB[0];

        }

        public static double getMid(int q, params int[] c)
        {

            int[] sortC = c;

            int s = 0;
            double mid;
            for (int i = 0; i < sortC.Length; i++)
            {
                s = s + sortC[i];
            }

            mid = (double) s/q; 

            return mid;
           

        }

    }
}
