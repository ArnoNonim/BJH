using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		string[] input = Console.ReadLine().Split();
		int n = int.Parse(input[0]), m = int.Parse(input[1]);
		var set = new HashSet<string>();
		var result = new List<string>();

		for (int i = 0; i < n; i++)
			set.Add(Console.ReadLine());

		for (int i = 0; i < m; i++)
		{
			string name = Console.ReadLine();
			if (set.Contains(name))
				result.Add(name);
		}
		result.Sort();

		Console.WriteLine(result.Count);
		Console.WriteLine(string.Join("\n", result));
	}
}