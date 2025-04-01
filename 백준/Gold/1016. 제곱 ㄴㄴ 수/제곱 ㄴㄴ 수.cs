using System;

namespace Baekjoon
{
	internal class Program
    {
        static void Main(string[] args)
        {
			string[] s = Console.ReadLine().Split();
			ulong min = ulong.Parse(s[0]), max = ulong.Parse(s[1]);

			List<bool> check = new List<bool>(new bool[max - min + 1]);

			for (ulong i = 2; i <= MathF.Sqrt(max); i++)
			{
				ulong pow = i * i;
				ulong start = min / pow;

				if (min % pow != 0) start++;

				for(ulong j = start; j * pow <= max; j++)
				{
					check[(int)((j * pow) - min)] = true;
				}
			}

			ulong res = 0;
			for (ulong i = 0; i < (ulong)check.Count; ++i)
			{
				if (!check[(int)i])
					res++;
			}

			Console.WriteLine(res);
		}
    }
}
