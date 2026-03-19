using System;

class Program
{
	static void Main()
	{
		int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

		for (int i = -1000; i <= 1000; i++)
		{
			if ((arr[0] + i) / 2 == arr[1])
			{
				Console.WriteLine(i);
				return;
			}
		}
	}
}