using System;

namespace Baekjoon
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split();
			string l = input[0], r = input[1];
			int cnt = 0;

			if (l.Length != r.Length)
				Console.WriteLine(cnt);
			else
			{
				int i = 0;
				while (i < l.Length && l[i] == r[i])
				{
					if (l[i] == '8')
						cnt++;
					i++;
				}
				Console.WriteLine(cnt);
			}
		}
	}
}
