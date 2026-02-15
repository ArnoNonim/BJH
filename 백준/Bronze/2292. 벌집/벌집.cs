using System;

namespace BaekJoon
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int cnt = 1;
			int room = 1;
			
			while(n > room)
			{
				room += 6 * cnt;
				cnt++;
			}

			Console.WriteLine(cnt);
		}
	}
}
