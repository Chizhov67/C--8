namespace ConsoleAppTask62
{
	internal class Program
	{
		static void createArray(int[,] array)
		{
			int num = 1;
			int i = 0;
			int j = 0;
			int upperSide = 0, downSide = 0, leftSide = 0, rightSide = 0;
			while (num <= 16)
			{
				array[i, j] = num;
				if (i == upperSide && j < 4 - rightSide - 1)
					++j;
				else if (j == 4 - rightSide - 1 && i < 4 - downSide - 1)
					++i;
				else if (i == 4 - downSide - 1 && j > leftSide)
					--j;
				else
					--i;

				if ((i == upperSide + 1) && (j == leftSide) && (leftSide != 4 - rightSide - 1))
				{
					++upperSide;
					++downSide;
					++leftSide;
					++rightSide;
				}
				++num;
			}
		}

		static void printArray(int[,] array)
		{
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					if (array[i, j] / 10 <= 0)
						Console.Write($"0{array[i, j]} ");
					else

						Console.Write(array[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
		static void Main(string[] args)
		{
			int[,] array = new int[4, 4];
			createArray(array);
			printArray(array);

			Console.ReadLine();
		}
	}
}

