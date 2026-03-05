using System;
using System.Linq;

class Program
{
	static void Main()
	{
		int[] arr = new int[10];
		for(int i = 0; i < 10; i++)
			arr[i] = int.Parse(Console.ReadLine()) % 42;

		Console.WriteLine(arr.Distinct().Count());
	}
}