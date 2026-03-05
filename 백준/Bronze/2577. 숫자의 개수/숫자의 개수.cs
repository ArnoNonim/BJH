using System;

class Program
{
	static void Main()
	{
		int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), c = int.Parse(Console.ReadLine());
		string n = (a * b * c).ToString();
		int[] nums = new int[n.Length];
		int[]	zeroToNine = new int[10];
		for(int i = 0; i < n.Length; i++)
			nums[i] = int.Parse(n[i].ToString());

		for (int i = 0; i < n.Length; i++)
			for(int j = 0; j < 10; j++)
				if (nums[i] == j)
					zeroToNine[j]++;

		for (int j = 0; j < 10; j++)
				Console.WriteLine(zeroToNine[j]);
	}
}