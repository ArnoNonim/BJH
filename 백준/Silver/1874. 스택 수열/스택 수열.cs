using System;
using System.Collections.Generic;
using System.Text;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		Stack<int> stack = new Stack<int>();
		StringBuilder sb = new StringBuilder();

		int cur = 1;

		for (int i = 0; i < n; i++)
		{
			int target = int.Parse(Console.ReadLine());

			while (cur <= target)
			{
				stack.Push(cur++);
				sb.AppendLine("+");
			}

			if (stack.Peek() == target)
			{
				stack.Pop();
				sb.AppendLine("-");
			}
			else
			{
				Console.WriteLine("NO");
				return;
			}
		}

		Console.WriteLine(sb.ToString());
	}
}