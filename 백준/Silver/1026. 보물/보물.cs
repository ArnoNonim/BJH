using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] brr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

			List<int> brrList = brr.OrderByDescending(x => x).ToList();
			Array.Sort(arr);
			int sum = 0;
			for (int i = 0; i < n; i++)
			{
				sum += brrList[i] * arr[i];
			}

			Console.WriteLine(sum);
		}
	}
}