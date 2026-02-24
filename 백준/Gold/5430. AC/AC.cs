using System;
using System.Text;
using System.Linq;

class Program
{
	static void Main()
	{
		int t = int.Parse(Console.ReadLine());
		StringBuilder sb = new StringBuilder();

		while (t-- > 0)
		{
			string p = Console.ReadLine();
			int n = int.Parse(Console.ReadLine());
			string input = Console.ReadLine();

			int[] arr = n == 0 ? new int[0] : input.Trim('[', ']').Split(',').Select(int.Parse).ToArray();

			int left = 0;
			int right = n - 1;
			bool reversed = false;
			bool error = false;

			foreach (char cmd in p)
			{
				if (cmd == 'R')
					reversed = !reversed;
				else
				{
					if (left > right)
					{
						error = true;
						break;
					}

					if (!reversed)
						left++;
					else
						right--;
				}
			}

			if (error)
			{
				sb.AppendLine("error");
				continue;
			}

			sb.Append("[");

			if (!reversed)
				for (int i = left; i <= right; i++)
				{
					sb.Append(arr[i]);
					if (i < right) sb.Append(",");
				}
			else
				for (int i = right; i >= left; i--)
				{
					sb.Append(arr[i]);
					if (i > left) sb.Append(",");
				}

			sb.AppendLine("]");
		}

		Console.Write(sb.ToString());
	}
}