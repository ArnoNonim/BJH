using System;

namespace backjoon
{
	internal class Program
	{
		static long Power(long a, long b, long c)
		{
			if (b == 1) return a % c;

			long half = Power(a, b / 2, c);

			long result = (half * half) % c;

			if (b % 2 == 0)
				return result;
			else
				return (result * (a % c)) % c;
		}

		static void Main()
		{
			string[] input = Console.ReadLine().Split();
			long a = long.Parse(input[0]);
			long b = long.Parse(input[1]);
			long c = long.Parse(input[2]);

			Console.WriteLine(Power(a, b, c));
		}
	}
}