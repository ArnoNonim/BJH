using System;

class Program
{
	static void Main()
	{
		int num = int.Parse(Console.ReadLine());
		double res = ((double)num / 4);

		if (res % 1 == 0)
			Console.WriteLine(res.ToString("F1"));
		else
			Console.WriteLine(res.ToString("F2"));
	}
}