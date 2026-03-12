using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
	public static int LowerBound(int[] arr, int target)
	{
		int start = 0;
		int end = arr.Length;
		while (start < end)
		{
			int mid = start + (end - start) / 2;
			if (arr[mid] >= target)
				end = mid;
			else
				start = mid + 1;
		}
		return start;
	}

	public static int UpperBound(int[] arr, int target)
	{
		int start = 0;
		int end = arr.Length;
		while (start < end)
		{
			int mid = start + (end - start) / 2;
			if (arr[mid] > target)
				end = mid;
			else
				start = mid + 1;
		}
		return start;
	}

	static void Main()
	{
		StringBuilder sb = new StringBuilder();

		int n = int.Parse(Console.ReadLine());
		int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		int m = int.Parse(Console.ReadLine());
		int[] brr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

		Array.Sort(arr);

		int cnt;
		foreach(int i in brr)
		{
			cnt = UpperBound(arr, i) - LowerBound(arr, i);
			sb.Append(cnt + " ");
		}

		Console.WriteLine(sb.ToString());
	}
}