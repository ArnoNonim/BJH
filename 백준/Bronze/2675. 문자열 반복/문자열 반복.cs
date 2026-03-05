using System;
using System.Text;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		string[] input;
		int r;
		string s;
		StringBuilder sb;

		for (int i = 0; i < n; i++) 
		{
			sb = new StringBuilder();
			input = Console.ReadLine().Split();
			r = int.Parse(input[0]);
			s = input[1];

			for(int j = 0; j < s.Length; j++)
				for (int k = 0; k < r; k++)
					sb.Append(s[j]);

			Console.WriteLine(sb);
		}
	}
}