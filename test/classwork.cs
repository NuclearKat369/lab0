using System;

public class classwork
{
	public static void Main()
	{

		int[,] Array = new int[13, 8];

		Random rand = new Random();

		for (int i = 0; i < 13; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Array[i, j] = rand.Next(1, 200);
				Console.Write("[" + Array[i, j] + "] ");
			}
			Console.WriteLine();
		}

		Console.WriteLine();

		int[,] NewArray = new int[8, 13];

		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 13; j++)
			{
				NewArray[i, j] = Array[j, i];
				Console.Write("[" + NewArray[i, j] + "] ");
			}
			Console.WriteLine();
		}

		Console.WriteLine();

		int[,] remove = new int[13, 8];
		int l, c;
		l = rand.Next(8);
		c = rand.Next(13);

		Console.WriteLine(l + " " + c);

		for (int i = 0; i < 13; i++)
		{
			for (int j = 0; j < 8; j++)
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

