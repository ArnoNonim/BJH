using System;

class Program
{
	static void FizzBuzz(int n)
	{
		if (n % 3 == 0 && n % 5 == 0)
			Console.WriteLine("FizzBuzz");
		else if (n % 3 == 0 && n % 5 != 0)
			Console.WriteLine("Fizz");
		else if (n % 3 != 0 && n % 5 == 0)
			Console.WriteLine("Buzz");
		else
			Console.WriteLine(n);
	}

	static void Main()
	{
		string a = Console.ReadLine();
		string b = Console.ReadLine();
		string c = Console.ReadLine();
		int num = 0;

		if (a[0] >= 48 && a[0] <= 57) num = int.Parse(a) + 3;
		else if (b[0] >= 48 && b[0] <= 57) num = int.Parse(b) + 2;
		else if (c[0] >= 48 && c[0] <= 57) num = int.Parse(c) + 1;

		FizzBuzz(num);
	}
}