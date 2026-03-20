using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		string[] input = Console.ReadLine().Split();
		int n = int.Parse(input[0]), m = int.Parse(input[1]);
		Dictionary<string, string> dic = new Dictionary<string, string>();

		string[] str;
		for(int i = 0; i < n; i++)
		{
			str = Console.ReadLine().Split();
			dic.Add(str[0], str[1]);
		}
		string address;
		for (int i = 0; i < m; i++)
		{
			address = Console.ReadLine();
			Console.WriteLine(dic[address]);
		}
	}
}