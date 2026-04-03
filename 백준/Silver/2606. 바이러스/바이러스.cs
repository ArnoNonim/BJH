using System;
using System.Collections.Generic;

class Program
{
	static List<int>[] list;
	static int[] virus;
	static int result = 0;

	static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());
		int m = int.Parse(Console.ReadLine());

		list = new List<int>[n + 1];
		virus = new int[n + 1];

		for (int i = 0; i <= n; i++)
			list[i] = new List<int>();

		for (int j = 0; j < m; j++)
		{
			string[] input = Console.ReadLine().Split();
			int u = int.Parse(input[0]);
			int v = int.Parse(input[1]);

			list[u].Add(v);
			list[v].Add(u);
		}

		DFS(1);
		Console.WriteLine(result);
	}

	static void DFS(int start)
	{
		virus[start] = 1;

		foreach (int x in list[start])
			if (virus[x] == 0)
			{
				result++;
				DFS(x);
			}
	}
}