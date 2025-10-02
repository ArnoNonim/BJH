using System;
using System.Linq;

namespace BaekJoon
{
	class Program
	{
		static void Main(string[] args)
		{
			while(true)
			{
				int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse).OrderByDescending(x => x).ToArray();

				if (arr.Sum() == 0) break;
				Console.WriteLine((arr[0] * arr[0] == arr[1] * arr[1] + arr[2] * arr[2]) ? "right" : "wrong");
			}
		}
	}
}
