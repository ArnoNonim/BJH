using System;

namespace backjoon
{
	internal class Program
	{
		static void Main()
		{
			int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

			Array.Sort(a);
			Console.WriteLine(a[n[1] - 1]);
		}
	}
}