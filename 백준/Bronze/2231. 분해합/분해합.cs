using System;

namespace BaekJoon
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine()); 

			for (int i = 0; i < n; i++)
			{
				string c = i.ToString();
				int m = i;
				for (int j = 0; j < c.Length; j++)
				{
					m += int.Parse(c[j].ToString());
				}
				if(n == m)
				{
					Console.WriteLine(i);
					return;
				}
			}

			Console.WriteLine(0);
		}
	}
}
