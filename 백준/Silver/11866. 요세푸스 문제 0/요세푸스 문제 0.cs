using System;
using System.Collections.Generic;
using System.Text;

class Program
{
	static void Main()
	{
		StringBuilder sb = new StringBuilder();

		string[] input = Console.ReadLine().Split();
		int n = int.Parse(input[0]), k = int.Parse(input[1]);
		Queue<int> queue = new Queue<int>();

		for(int i = 0; i < n; i++) queue.Enqueue(i + 1);

		sb.Append("<");

		while (queue.Count > 1)
		{
			for (int i = 0; i < k - 1; i++)
				queue.Enqueue(queue.Dequeue());
			sb.Append(queue.Dequeue()).Append(", ");
		}
		sb.Append(queue.Dequeue()).Append(">");

		Console.WriteLine(sb.ToString());
	}
}