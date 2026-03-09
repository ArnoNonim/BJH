using System;

class Program
{
	static int[] dp = new int[5001];
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		dp[3] = dp[5] = 1;

		for(int i = 6; i <= n; i++)
		{
			if (dp[i - 3] != 0) dp[i] = dp[i - 3] + 1;
			if (dp[i - 5] != 0) dp[i] = dp[i] != 0 ? Math.Min(dp[i], dp[i - 5] + 1) : dp[i - 5] + 1;
		}

		Console.WriteLine(dp[n] == 0 ? -1 : dp[n]);
	}
}
