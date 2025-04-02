using System;

namespace Baekjoon
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());
			List<(int start, int end)> meetings = new List<(int, int)>();

			for (int i = 0; i < N; i++)
			{
				int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
				meetings.Add((ab[0], ab[1]));
			}
			meetings = meetings.OrderBy(m => m.end).ThenBy(m => m.start).ToList();

			int cnt = 0;
			int lastEndTime = 0;

			foreach (var (start, end) in meetings)
			{
				if (start >= lastEndTime)
				{
					lastEndTime = end;
					cnt++;
				}
			}

			Console.WriteLine(cnt);
		}
	}
}
