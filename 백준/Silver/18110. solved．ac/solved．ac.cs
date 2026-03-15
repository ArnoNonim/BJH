using System;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		if (n == 0)
		{
			Console.WriteLine(0);
			return;
		}

		int[] arr = new int[n];
		for (int i = 0; i < n; i++)
			arr[i] = int.Parse(Console.ReadLine());

		Array.Sort(arr);

		int idx = (int)Math.Round(n * 0.15, MidpointRounding.AwayFromZero);

		double sum = 0;
		for (int i = idx; i < n - idx; i++)
			sum += arr[i];

		int res = (int)Math.Round(sum / (n - idx * 2), MidpointRounding.AwayFromZero);

		Console.WriteLine(res);
	}
}