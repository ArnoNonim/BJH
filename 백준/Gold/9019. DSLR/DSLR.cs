using System;
using System.Collections.Generic;

namespace backjoon
{
	internal class Program
	{
		static int n, current, target;
		static bool[] visited;

		static void bfs()
		{
			Queue<(int, string)> q = new Queue<(int, string)>();
			q.Enqueue((current, ""));
			while(q.Count != 0)
			{
				int cur = q.Peek().Item1;
				string dslr = q.Peek().Item2;
				q.Dequeue();
				if(cur == target)
				{
					Console.WriteLine(dslr);
					return;
				}
				int DVal = cur * 2 % 10000;
				int SVal = cur - 1 < 0 ? 9999 : cur - 1;
				int LVal = cur % 1000 * 10 + cur / 1000;
				int RVal = cur / 10 + (cur % 10) * 1000;
				if (!visited[DVal])
				{
					visited[DVal] = true;
					q.Enqueue((DVal, dslr + 'D'));
				}
				if (!visited[SVal])
				{
					visited[SVal] = true;
					q.Enqueue((SVal, dslr + 'S'));
				}
				if (!visited[LVal])
				{
					visited[LVal] = true;
					q.Enqueue((LVal, dslr + 'L'));
				}
				if (!visited[RVal])
				{
					visited[RVal] = true;
					q.Enqueue((RVal,dslr + 'R'));
				}
			}
		}

		static void Main()
		{
			n = int.Parse(Console.ReadLine());
			for(int i = 0; i < n; i++)
			{
				visited = new bool[10000];
				int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
				current = input[0];
				target = input[1];
				bfs();
			}
		}
	}
}