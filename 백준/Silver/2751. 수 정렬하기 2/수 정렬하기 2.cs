using System;
using System.Text;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int[] arr = new int[n];
		for(int i = 0; i < n; i++)
			arr[i] = int.Parse(Console.ReadLine());

		Array.Sort(arr);

		StringBuilder sb = new StringBuilder(string.Join("\n", arr));
		Console.WriteLine(sb.ToString());
	}
}