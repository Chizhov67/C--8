namespace ConsoleAppTask60
{
	internal class Program
	{
		public static void CreateArray(int[,,] arrayXYZ, int x, int y, int z)
		{
			int count = 0;
			Random rnd = new Random();
			int digit;
			int[] temp = new int[x * y * z];

			for (int i = 0; i < temp.Length; i++)
			{
				digit = rnd.Next(10, 100);

				if (temp.Contains(digit))
				{
					i--;
				}

				else
				{
					temp[i] = digit;
				}
				
			}

			for (int i = 0; i < x; i++)
			{
				for (int j = 0; j < y; j++)
				{
					for (int k = 0; k < z; k++)
					{
						arrayXYZ[i, j, k] = temp[count];
						count++;
					}
				}
	
			}
		}

		public static void printArray(int[,,] arrayXYZ, int x, int y, int z)
		{
			for (int i = 0; i < x; i++)
			{
				for (int j = 0; j < y; j++)
				{
					for (int k = 0; k < z; k++)
					{
						Console.Write($"{arrayXYZ[i,j,k]}({i},{j},{k}) ");
					}
					Console.WriteLine();
				}
			}
		}
		static void Main(string[] args)
		{
			int x = 0, y = 0, z = 0;
			bool flag = true;

			while (flag)
			{
				Console.Write("Введите число элементов по x: ");
				while (!int.TryParse(Console.ReadLine(), out x))
				{
					Console.WriteLine("\nНеверный ввод, Введите число элементов по x: ");
				}

				Console.Write("Введите число элементов по y: ");
				while (!int.TryParse(Console.ReadLine(), out y))
				{
					Console.WriteLine("\nНеверный ввод, Введите число элементов по y: ");
				}

				Console.Write("Введите число элементов по z: ");
				while (!int.TryParse(Console.ReadLine(), out z))
				{
					Console.WriteLine("\nНеверный ввод, Введите число элементов по z: ");
				}

				if (x * y * z > 91)
				{
					Console.WriteLine("\nОшибка, нельзя заполнить различными числами!\n");
				}

				else
				{
					flag = false;
				}
			}

			int[,,] arrayXYZ = new int[x, y, z];
			CreateArray(arrayXYZ, x, y, z);
			printArray(arrayXYZ, x, y, z);


			Console.ReadLine();
		}
	}
}
