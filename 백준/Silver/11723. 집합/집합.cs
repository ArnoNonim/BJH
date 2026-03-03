using System;
using System.Text;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int set = 0;
		StringBuilder sb = new StringBuilder();

		for (int i = 0; i < n; i++)
		{
			string[] input = Console.ReadLine().Split();
			string cmd = input[0];

			if (cmd == "add")
			{
				int x = int.Parse(input[1]);
				set |= (1 << x);
			}
			else if (cmd == "remove")
			{
				int x = int.Parse(input[1]);
				set &= ~(1 << x);
			}
			else if (cmd == "check")
			{
				int x = int.Parse(input[1]);
				sb.AppendLine((set & (1 << x)) != 0 ? "1" : "0");
			}
			else if (cmd == "toggle")
			{
				int x = int.Parse(input[1]);
				set ^= (1 << x);
			}
			else if (cmd == "all")
			{
				set = (1 << 21) - 2;
			}
			else if (cmd == "empty")
			{
				set = 0;
			}
		}

		Console.Write(sb.ToString());
	}
}