using System;

class Program
{
	static int num = 0;

	static void div(int n, int r, int c)
	{
		if (n == 1) return;

		int half = n / 2;
		int temp = (n * n) / 4;

		if (r < half && c < half)
		{
			div(half, r, c);
		}
		else if (r < half && c >= half)
		{
			num += temp;
			div(half, r, c - half);
		}
		else if (r >= half && c < half)
		{
			num += temp * 2;
			div(half, r - half, c);
		}
		else
		{
			num += temp * 3;
			div(half, r - half, c - half);
		}
	}

	static void Main(string[] args)
	{
		int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
		int n = 1 << input[0];

		div(n, input[1], input[2]);

		Console.WriteLine(num);
	}
}