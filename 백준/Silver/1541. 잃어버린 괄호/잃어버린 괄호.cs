using System;

namespace Baekjoon
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int res = 0;
			string num = "";
			bool isMinus = false;

			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == '-' || input[i] == '+')
				{
					if (isMinus)
						res -= int.Parse(num);
					else
						res += int.Parse(num);

					num = "";
				}
				else
					num += input[i];

				if (input[i] == '-')
					isMinus = true;
			}

			if (isMinus)
				res -= int.Parse(num);
			else
				res += int.Parse(num);

			Console.WriteLine(res);
		}
	}
}