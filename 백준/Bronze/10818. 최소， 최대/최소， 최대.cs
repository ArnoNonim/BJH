using System;
using System.Linq;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

		Console.WriteLine(nums.Min() + " " + nums.Max());
	}
}