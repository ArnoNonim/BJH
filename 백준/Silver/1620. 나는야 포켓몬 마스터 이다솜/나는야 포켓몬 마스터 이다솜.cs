using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		string[] input = Console.ReadLine().Split();
		int n = int.Parse(input[0]), m = int.Parse(input[1]);
		Dictionary<int, string> id = new Dictionary<int, string>();
		Dictionary<string, int> name = new Dictionary<string, int>();
		string pokemon;
		for (int i = 1; i <= n; i++)
		{
			pokemon = Console.ReadLine();
			id[i] = pokemon;
			name[pokemon] = i;
		}

		string problem;
		int res;
		for(int i = 1; i <= m; i++)
		{
			problem = Console.ReadLine();
			if(int.TryParse(problem, out res))
				Console.WriteLine(id[res]);
			else
				Console.WriteLine(name[problem]);
		}
	}
}