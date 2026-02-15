using System;

namespace BaekJoon
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int cnt = 0;
			int res = 0;

			for (int i = 0; i < n; i++)
			{
				for (int j = 1; j <= nums[i]; j++)
					if (nums[i] % j == 0)
						cnt++;
				if (cnt == 2)
					res++;
				cnt = 0;
			}		

			Console.WriteLine(res);
		}
	}
}
