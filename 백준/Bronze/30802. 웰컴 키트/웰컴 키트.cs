using System;

namespace BaekJoon
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] sizes = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] bundles = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int s = 0, sum = 0;

			for(int i = 0; i < sizes.Length; i++)
			{
				if (sizes[i] % bundles[0] == 0)
					s = sizes[i] / bundles[0];
				else
					s = sizes[i] / bundles[0] + 1;
					sum += s;
			}

			Console.WriteLine(sum);
			Console.WriteLine($"{n / bundles[1]} {n % bundles[1]}");
		}
	}
}
