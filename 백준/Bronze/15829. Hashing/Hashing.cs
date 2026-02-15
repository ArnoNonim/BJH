using System;

namespace BaekJoon
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string str = Console.ReadLine();

			const ulong M = 1234567891;
			const ulong r = 31;

			ulong hash = 0;
			ulong pow = 1;

			for (int i = 0; i < n; i++)
			{
				hash = (hash + (ulong)(str[i] - 'a' + 1) * pow) % M;
				pow = (pow * r) % M;
			}

			Console.WriteLine(hash);
		}
	}
}
