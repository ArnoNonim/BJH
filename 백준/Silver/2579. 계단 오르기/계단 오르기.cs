using System;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int[] arr = new int[n + 1];
		int[] dp = new int[n + 1];

		for (int i = 1; i <= n; i++)
			arr[i] = int.Parse(Console.ReadLine());

		if (n == 1)
		{
			Console.WriteLine(arr[1]);
			return;
		}

		dp[1] = arr[1];
		dp[2] = arr[1] + arr[2];

		for (int i = 3; i <= n; i++)
			dp[i] = Math.Max(dp[i - 2] + arr[i], dp[i - 3] + arr[i - 1] + arr[i]);

		Console.WriteLine(dp[n]);
	}
}