using System;

namespace backjoon
{
	internal class Program
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int cost = 0;
			int min;

			for (int i = 0; i < n; i++)
			{
				if (i + 1 < n && i + 2 < n)
				{
					if (arr[i + 1] > arr[i + 2])
					{
						int two = Math.Min(arr[i], arr[i + 1] - arr[i + 2]);
						cost += two * 5;
						arr[i] -= two;
						arr[i + 1] -= two;
					}
					int three = Math.Min(arr[i], Math.Min(arr[i + 1], arr[i + 2]));
					cost += three * 7;
					arr[i] -= three;
					arr[i + 1] -= three;
					arr[i + 2] -= three;
				}
				if (i + 1 < n)
				{
					int two = Math.Min(arr[i], arr[i + 1]);
					cost += two * 5;
					arr[i] -= two;
					arr[i + 1] -= two;
				}
				cost += arr[i] * 3;
			}

			Console.WriteLine(cost);
		}
	}
}