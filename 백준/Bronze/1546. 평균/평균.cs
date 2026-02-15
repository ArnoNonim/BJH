using System;
using System.Linq;

namespace BaekJoon
{
	class Program
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			double[] scores = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
			double m = scores.Max();
			double sum = 0;

			for(int i = 0; i < n; i++)
				sum += (scores[i] / m) * 100.0;

			Console.WriteLine(sum / n);
		}
	}
}
