using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main()
	{
		string[] input;
		Dictionary<int, int> amounts = new Dictionary<int, int>();
		int[] years = new int[3];
		string[] surnames = new string[3];
		for(int i = 0; i < 3; i++)
		{
			input = Console.ReadLine().Split();
			amounts.Add(int.Parse(input[0]), i + 1);
			years[i] = int.Parse(input[1]);
			surnames[i] = input[2];
		}
		Array.Sort(years);
		Console.WriteLine((years[0] % 100).ToString() + (years[1] % 100).ToString() + (years[2] % 100).ToString());
		amounts = amounts.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
		foreach (int key in amounts.Keys)
		{
			string surname = surnames[amounts[key] - 1];
			Console.Write(surname[0]);
		}
	}
}