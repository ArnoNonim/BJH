using System;
using System.Collections.Generic;
using System.Text;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		Queue<int> queue = new Queue<int>();
		StringBuilder sb = new StringBuilder();
		int back = -1;

		for (int i = 0; i < n; i++)
		{
			string[] input = Console.ReadLine().Split();

			if (input[0] == "push")
			{
				int x = int.Parse(input[1]);
				queue.Enqueue(x);
				back = x;
			}
			else if (input[0] == "pop")
				sb.AppendLine(queue.Count > 0 ? queue.Dequeue().ToString() : "-1");

			else if (input[0] == "size")
				sb.AppendLine(queue.Count.ToString());

			else if (input[0] == "empty")
				sb.AppendLine(queue.Count == 0 ? "1" : "0");

			else if (input[0] == "front")
				sb.AppendLine(queue.Count > 0 ? queue.Peek().ToString() : "-1");

			else if (input[0] == "back")
				sb.AppendLine(queue.Count > 0 ? back.ToString() : "-1");
		}

		Console.Write(sb.ToString());
	}
}