namespace ConsoleAppTask56
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

		static int sumNumberRow(int[,] array, int M, int N)
		{
			int[] sum = new int[M];
			int numberRow = 0, tempSum = 1000;
			for (int i = 0; i < M; i++)
			{
				sum[i] = 0;
				for (int j = 0; j < N; j++)
				{
					sum[i] += array[i, j];
				}
			}

			for (int i = 0; i < M; i++)
			{
				if(sum[i] < tempSum)
				{
					tempSum = sum[i];
					numberRow = i;
				}
			}

			return numberRow;
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

			Console.WriteLine("\nСтрока в которой наименьшая сумма: " + (sumNumberRow(array, M, N) + 1));

			Console.ReadLine();
		}
	}
}
