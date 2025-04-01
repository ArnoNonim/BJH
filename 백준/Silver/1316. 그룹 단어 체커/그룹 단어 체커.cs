using System;

namespace Baekjoon
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int cnt = 0;

			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();
				if (IsGroupWord(input)) cnt++;
			}

			Console.WriteLine(cnt);
		}

		static bool IsGroupWord(string word)
		{
			bool[] apb = new bool[26];
			char prevChar = '\0';

			foreach (char c in word)
			{
				if (c != prevChar)
				{
					if (apb[c - 'a']) return false;
					apb[c - 'a'] = true;
				}
				prevChar = c;
			}

			return true;
		}
	}
}
