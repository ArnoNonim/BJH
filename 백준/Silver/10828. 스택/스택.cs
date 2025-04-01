using System;
using System.Collections.Generic;

namespace Baekjoon
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Stack<int> stack = new Stack<int>();
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Split();

				if (input[0] == "push")
				{
					stack.Push(int.Parse(input[1]));
				}
				else if (input[0] == "pop")
				{
					if (stack.Count == 0)
					{
						Console.WriteLine("-1");
					}
					else
					{
						Console.WriteLine(stack.Pop());
					}
				}
				else if (input[0] == "size")
				{
					Console.WriteLine(stack.Count);
				}
				else if (input[0] == "empty")
				{
					if (stack.Count == 0)
					{
						Console.WriteLine("1");
					}
					else
					{
						Console.WriteLine("0");
					}
				}
				else if (input[0] == "top")
				{
					if (stack.Count == 0)
					{
						Console.WriteLine("-1");
					}
					else
					{
						Console.WriteLine(stack.Peek());
					}
				}
			}
		}
	}
}
