using System;
using System.Text;
using System.Linq;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		Array.Sort(arr);
		int res = 0;

		for(int i = 0; i < n; i++)
		{
			int time = 0;
			for(int j = 0; j <= i; j++)
			{
				time += arr[j];
			}
			res += time;
		}

		Console.WriteLine(res);
	}
}