using System;

namespace Baekjoon
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

			Console.WriteLine(n[0] * n[1]);
		}
	}
}
