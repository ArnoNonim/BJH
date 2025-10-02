using System;

namespace BaekJoon
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

			Array.Sort(arr);

			if(n == 1)
			{
				Console.WriteLine(arr[0] * arr[0]);
			}
			else
			{
				Console.WriteLine(arr[n - 1] * arr[0]);
			}
		}
	}
}
