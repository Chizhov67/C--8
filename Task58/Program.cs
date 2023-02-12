namespace ConsoleAppTask58
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
					Thread.Sleep(1);
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

		static int[,] multiplyMatrix(int[,] oneArray, int[,] twoArray, int M, int N, int columnsTwo)
		{
			int sum = 0;
			int[,] resultArray = new int[M, columnsTwo];

			for (int i = 0; i < M; i++)
			{
				for (int j = 0; j < columnsTwo; j++)
				{
					sum = 0;
					for (int k = 0; k < N; k++)
					{
						sum += oneArray[i, k] * twoArray[k, j];
					}
					resultArray[i, j] = sum;
				}
			}

			return resultArray;
		}

		static void Main(string[] args)
		{
			int M, N, columsTwo;


			Console.Write("Введите число строк 1 матрицы: ");
			while (!int.TryParse(Console.ReadLine(), out M))
			{
				Console.WriteLine("\nНеверный ввод, введите число строк 1 матрицы: ");
			}

			Console.Write("Введите число столбцов 1 матрицы и строк 2 матрицы: ");
			while (!int.TryParse(Console.ReadLine(), out N))
			{
				Console.WriteLine("\nНеверный ввод, Введите число столбцов 1 матрицы и строк 2 матрицы: ");
			}

			Console.Write("Введите число столбцов 2 матрицы ");
			while (!int.TryParse(Console.ReadLine(), out columsTwo))
			{
				Console.WriteLine("\nНеверный ввод, Введите число столбцов 2: ");
			}

			int[,] arrayOne = new int[M, N];
			int[,] arrayTwo = new int[N, columsTwo];
			int[,] resultArray = new int[M, columsTwo];

			Console.WriteLine("\nПервая матрица\n");
			createArray(arrayOne, M, N);
			printArray(arrayOne, M, N);

			Console.WriteLine("\nВторая матрица\n");
			createArray(arrayTwo, N, columsTwo);
			printArray(arrayTwo, N, columsTwo);

			Console.WriteLine("\n\nПроизведение двух матриц:\n");
			resultArray = multiplyMatrix(arrayOne, arrayTwo, M, N, columsTwo);
			printArray(resultArray, M, columsTwo);

			Console.ReadLine();
		}
	}
}
