using System;

namespace backjoon
{
	internal class Program
	{
		static int[,] graph = new int[100, 100];

		static void FloydWarshall(int n)
		{
			for (int k = 0; k < n; k++)
				for (int i = 0; i < n; i++)
					for (int j = 0; j < n; j++)
						if (graph[i, j] == 0 && graph[i, k] == 1 && graph[k, j] == 1)
							graph[i, j] = 1;
		}

		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
				for (int j = 0; j < n; j++)
					graph[i, j] = input[j];
			}
				
			FloydWarshall(n);

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
					Console.Write(graph[i, j] + " ");
				Console.WriteLine();
			}
		}
	}
}