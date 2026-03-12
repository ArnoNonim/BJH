using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		while (true)
		{
			string input = Console.ReadLine();
			if (input == ".") break;

			Stack<char> stack = new Stack<char>();
			bool valid = true;

			foreach (char c in input)
			{
				if (c == '(' || c == '[')
					stack.Push(c);
				else if (c == ')')
				{
					if (stack.Count == 0 || stack.Peek() != '(')
					{
						valid = false;
						break;
					}
					stack.Pop();
				}
				else if (c == ']')
				{
					if (stack.Count == 0 || stack.Peek() != '[')
					{
						valid = false;
						break;
					}
					stack.Pop();
				}
			}

			if (stack.Count != 0) valid = false;

			Console.WriteLine(valid ? "yes" : "no");
		}
	}
}