using System;
using System.Linq;

class Program
{
	static void Main()
	{
		string[] input = Console.ReadLine().Split();
		string[] trimmed = input.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

		Console.WriteLine(trimmed.Length);
	}
}