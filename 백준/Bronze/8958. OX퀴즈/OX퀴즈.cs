using System;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		string[] quizzes = new string[n];
		for (int i = 0; i < n; i++)
		{
			quizzes[i] = Console.ReadLine();
			char[] alphs = new char[quizzes[i].Length];
			for (int j = 0; j < quizzes[i].Length; j++)
				alphs[j] = quizzes[i][j];
			int sum = 0, score = 1;
			for (int j = 0; j < alphs.Length; j++)
			{
				if (alphs[j] == 'O')
				{
					sum += score;
					score++;
				}
				else
					score = 1;
			}
			Console.WriteLine(sum);
		}
	}
}