using System;

class Program
{
	static void Main()
	{
		string[] input = Console.ReadLine().Split();
		int h = int.Parse(input[0]), m = int.Parse(input[1]);

		if(m < 45)
		{
			h -= 1;
			m += 15;
			if (h < 0)
				h = 23;
		}
		else
			m -= 45;


		Console.WriteLine(h + " " + m);
	}
}