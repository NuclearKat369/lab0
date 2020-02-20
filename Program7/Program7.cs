using System;

namespace Program7
{
    class Program7
    {
        static void Main(string[] args)
        {
			int[,] Array = new int[9, 10];

			Random rand = new Random();

			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 10; j++)
				{					
					Array[i, j] = rand.Next(200);
					Console.Write("[" + Array[i, j] + "] ");
				}
				Console.WriteLine();
			}

			Console.WriteLine();

			int[,] remove = new int[9, 10];
			int l, c;
			l = rand.Next(10);
			c = rand.Next(9);

			Console.WriteLine("Будут удалены строка " + l + " и столбец " + c);

			column: for (int i = 0; i < 9; i++)
			{
				line: for (int j = 0; j < 10; j++)
				{
					if (i == c)
					{
						continue;
					}
					remove[i, j] = Array[i, j];
					if (j == l)
					{
						continue;
					}
					Console.Write("[" + remove[i, j] + "] ");
				}
				if (i != c) Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
