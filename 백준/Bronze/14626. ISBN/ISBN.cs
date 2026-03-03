using System;

namespace backjoon
{
	internal class Program
	{
		static void Main()
		{
			string input = Console.ReadLine();
			int sum = 0;
			int idx = 0;

			for(int i = 0; i < 13; i++)
			{
				if (input[i] == '*')
				{
					idx = i;
					continue;
				}

				int digit = input[i] - '0';
				sum += i % 2 == 0 ? digit : 3 * digit;
			}

			sum %= 10;

			if(idx % 2 == 0)
			{
				for (int i = 0; i < 10; i++)
					if (sum + i == 10)
					{
						Console.WriteLine(i);
						return;
					}
			}
			else
			{
				for (int i = 0; i < 10; i++)
					if ((sum + 3 * i) % 10 == 0)
					{
						Console.WriteLine(i);
						return;
					}
			}	
		}
	}
}