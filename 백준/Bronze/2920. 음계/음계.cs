using System;
using System.Linq;

class Program
{
	static void Main()
	{
		int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		int[] clone = nums;

		nums = nums.OrderBy(n => n).ToArray();

		int cnt = 0;
		for (int i = 0; i < nums.Length; i++)
			if (nums[i] == clone[i])
				cnt++;
		nums = nums.OrderByDescending(n => n).ToArray();

		if (cnt == 8)
			Console.WriteLine("ascending");
		else
		{
			cnt = 0;
			for (int i = 0; i < nums.Length; i++)
				if (nums[i] == clone[i])
					cnt++;

			if (cnt == 8)
				Console.WriteLine("descending");
			else
				Console.WriteLine("mixed");
		}
	}
}