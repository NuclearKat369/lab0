using System;

namespace Program8
{
    class Program8
    {
        static void Main(string[] args)
        {
            int[,] snake = new int[5, 10];

            int x = 0;
            int i, j;

            for (i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    for (j = 0; j < 10; j++)
                    {
                        snake[i, j] = x;
                        x++;
                    }
                }
                else
                {
                    for (j = 9; j >= 0; j--)
                    {
                        snake[i, j] = x;
                        x++;
                    }
                }
            }
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    Console.Write(snake[i, j].ToString("D2") + " ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
