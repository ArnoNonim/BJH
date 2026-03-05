using System;

class Program
{
	static void Main()
	{
		int t = int.Parse(Console.ReadLine());
		string[] input;
		int h = 0, w = 0, n = 0;

		for (int i = 0; i < t; i++)
		{
			input = Console.ReadLine().Split();
			h = int.Parse(input[0]); w = int.Parse(input[1]); n = int.Parse(input[2]);

			if (n % h == 0)
				Console.WriteLine(h * 100 + n / h);
			else
				Console.WriteLine(n % h * 100 + ((n / h) + 1));
		}
	}
}