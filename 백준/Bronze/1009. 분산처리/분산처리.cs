using System;

namespace Baekjoon
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());

			for (int i = 0; i < t; i++)
			{
				int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
				int task = ab[0];

				for (int j = 1; j < ab[1]; j++)
					task = task * ab[0] % 10;
				if (task % 10 == 0)
					Console.WriteLine(10);
				else
					Console.WriteLine(task % 10);
			}
		}
	}
}
