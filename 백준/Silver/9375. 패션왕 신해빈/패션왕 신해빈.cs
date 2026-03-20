using System;
using System.Collections.Generic;

namespace Baekjoon
{
	class Program
	{
		static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine());

			for (int j = 0; j < t; j++)
			{
				int item = int.Parse(Console.ReadLine());
				Dictionary<string, int> dic = new Dictionary<string, int>();

				for (int i = 0; i < item; i++)
				{
					string[] a = Console.ReadLine().Split();
					string c = a[1];

					if (dic.ContainsKey(c))
						dic[c]++;
					else
						dic.Add(c, 1);
				}
				int res = 1;
				
				foreach (int val in dic.Values)
					res *= (val + 1);
				Console.WriteLine(res - 1);
			}
		}
	}
}