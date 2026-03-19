using System;

class Program
{
	static void Main()
	{
		string[] input = Console.ReadLine().Split();
		int level = int.Parse(input[0]);
		string timing = input[1];

		if (timing == "miss")
			Console.WriteLine(0);
		if (timing == "bad")
			Console.WriteLine(200 * level);
		if (timing == "cool")
			Console.WriteLine(400 * level);
		if (timing == "great")
			Console.WriteLine(600 * level);
		if (timing == "perfect")
			Console.WriteLine(1000 * level);
	}
}