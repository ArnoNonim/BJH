using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main()
	{
		int t = int.Parse(Console.ReadLine());

		for (int i = 0; i < t; i++)
		{
			var input = Console.ReadLine().Split();
			int n = int.Parse(input[0]);
			int m = int.Parse(input[1]);

			int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

			Queue<(int priority, int index)> q = new Queue<(int, int)>();

			for (int j = 0; j < n; j++)
				q.Enqueue((arr[j], j));

			int cnt = 0;

			while (true)
			{
				var cur = q.Dequeue();

				if (q.Any(x => x.priority > cur.priority))
					q.Enqueue(cur);
				else
				{
					cnt++;

					if (cur.index == m)
					{
						Console.WriteLine(cnt);
						break;
					}
				}
			}
		}
	}
}