using System;

namespace BaekJoon
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string str = Console.ReadLine();
			string[] alphs = new string[26];

			long hash = 0;
			
			for(int i = 0; i < 26; i++)
			{
				alphs[i] = Convert.ToChar(97 + i).ToString();
			}

			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < 26; j++)
				{
					if (str[i] == Convert.ToChar(alphs[j]))
					{
						hash += (j + 1) * (long)Math.Pow(31, i);
					}
				}
			}

			Console.WriteLine(hash);
		}
	}
}
