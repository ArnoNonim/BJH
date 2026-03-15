using System;

class Program
{
	static void Main()
	{
		string[] input;
		int a, b;

		while (true)
		{
			input = Console.ReadLine().Split();
			a = int.Parse(input[0]); b = int.Parse(input[1]);
			if (a == 0 && b == 0) return;

			if (a > b) Console.WriteLine("Yes");
			else Console.WriteLine("No");
		}
	}
}