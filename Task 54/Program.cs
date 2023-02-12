namespace ConsoleAppTask54
{
	internal class Program
	{
		static void createArray(int[,] array, int M, int N)
		{
			Random rnd = new Random();
			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					array[i, j] = rnd.Next(1, 10);
				}
			}
		}

		static void printArray(int[,] array, int M, int N)
		{
			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					Console.Write(array[i, j] + " ");
				}
				Console.WriteLine();
			}
		}

		static void orderArray(int[,] array, int M, int N)
		{
			int[] row = new int[N];

			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < N; j++)
				{
					row[j] = array[i, j];
				}
				Array.Sort(row);
				Array.Reverse(row);
				
				for (int k = 0; k < row.Length; k++)
				{
					array[i, k] = row[k];
				}
			}
		}


		static void Main(string[] args)
		{
			int M, N;


			Console.Write("Введите число строк массива: ");
			while (!int.TryParse(Console.ReadLine(), out M))
			{
				Console.WriteLine("\nНеверный ввод, введите число строк массива: ");
			}

			Console.Write("Введите число столбцов массива: ");
			while (!int.TryParse(Console.ReadLine(), out N))
			{
				Console.WriteLine("\nНеверный ввод, введите число столбцов массива: ");
			}

			int[,] array = new int[M, N];
			createArray(array, M, N);
			printArray(array, M, N);
			orderArray(array, M, N);

			Console.WriteLine("\n\nОтсортированный массив\n");
			printArray(array, M, N);


			Console.ReadLine();
		}
	}
}

