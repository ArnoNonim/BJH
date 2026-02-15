using System;
using System.Linq;

namespace BaekJoon
{
	class Program
	{
		static void Main()
		{
			int[] nums = new int[9];
			int cnt = 0;
			
			for (int i = 0; i < 9; i++)
				nums[i] = int.Parse(Console.ReadLine());
			int max = nums.Max();
			for (int i = 0; i < 9; i++)
			{
				if (nums[i] == max)
				{
					Console.WriteLine(max);
					Console.WriteLine(i + 1);
				}
			}
		}
	}
}
