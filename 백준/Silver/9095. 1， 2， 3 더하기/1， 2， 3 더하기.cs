using System;

namespace backjoon
{
	internal class Program
	{

		static void Main()
		{
			int t = int.Parse(Console.ReadLine());
			int[] n = new int[t];
			for(int i = 0; i < t; i++)
				n[i] = int.Parse(Console.ReadLine());

			int[] dp = new int[11];
			dp[1] = 1;
			dp[2] = 2;
			dp[3] = 4;

			for (int i = 4; i < 11; i++)
				dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
			for(int i = 0; i < t; i++)
				Console.WriteLine(dp[n[i]]);
		}
	}
}