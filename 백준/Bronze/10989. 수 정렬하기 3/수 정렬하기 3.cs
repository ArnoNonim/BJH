using System;

class Program
{
	static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());
		int max = 10000;
		int[] cnt = new int[max + 1];
		int temp = 0;
		for (int i = 0; i < n; i++)
		{
			temp = int.Parse(Console.ReadLine());
			cnt[temp]++;
		}
		using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
		{
			for (int i = 0; i <= max; i++)
			{
				if (cnt[i] == 0) continue;
				for (int j = 0; j < cnt[i]; j++)
				{
					print.WriteLine(i);
				}
			}
		}
	}
}