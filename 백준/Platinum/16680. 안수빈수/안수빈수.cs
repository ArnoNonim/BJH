using System;

class Program
{
	static void Main(string[] args)
	{
		int t = int.Parse(Console.ReadLine());

		while (t != 0)
		{
			ulong n = ulong.Parse(Console.ReadLine());

			Console.WriteLine(n * 999999999);
			t--;
		}
	}
}