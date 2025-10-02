using System;
using System.Linq;
using System.Threading;

namespace BaekJoon
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string[] input = Console.ReadLine().Split();

			int[] arr = new int[n];
			(int, int)[] p = new (int, int)[n];

			for(int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(input[i]);
				p[i] = (i, arr[i]);
			}

			var sortList = p.OrderBy(o => o.Item2).ToArray();
			int[] res = new int[n + 1];

			for(int i = 0; i < n; i++)
				res[sortList[i].Item1] = i;
			for(int i = 0; i < n; i++)
			{
				Console.Write($"{res[i]} ");
			}

			Console.WriteLine();

		}
	}
}
