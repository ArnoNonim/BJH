using System;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		for (int i = 0; i < n; i++)
		{
			string answer = "YES";
			string input = Console.ReadLine();
			int balance = 0;
			for (int j = 0; j < input.Length; j++)
			{
				if(input[j] == '(')
					balance++;
				else
					balance--;
				if(balance < 0)
				{
					answer = "NO";
					break;
				}
			}
			if (balance != 0)
				answer = "NO";

			Console.WriteLine(answer);
		}
	}
}