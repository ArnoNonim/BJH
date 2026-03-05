using System;
using System.Linq;

class Program
{
	static void Main()
	{
		string input = Console.ReadLine();
		char[] alphs = new char[input.Length];
		int[] usedAlphs = new int[26];
		int[] pos = Enumerable.Repeat(-1, 26).ToArray();

		for (int i = 0; i < input.Length; i++)
			alphs[i] = input[i];

		for (int i = 0; i < input.Length; i++)
			for(int j = 97; j <= 122; j++)
				if (alphs[i] == j)
					if (usedAlphs[j - 97] == 0)
					{
						pos[j - 97] = i;
						usedAlphs[j - 97] = 1;
					}

		for(int i = 0;i < 26; i++)
			Console.Write(pos[i] + " ");
	}
}