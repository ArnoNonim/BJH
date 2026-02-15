using System;
using System.Linq;

namespace BaekJoon
{
	class Program
	{
		static void Main()
		{
			int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int gcd = getgcd(nums[0], nums[1]);

			Console.WriteLine(gcd);
			Console.WriteLine(nums[0] * nums[1] / gcd);
		}

		static int getgcd(int a, int b)
		{
			if (a % b == 0)
				return b;
			else
				return getgcd(b, a % b);
		}
	}
}
