using System;

namespace backjoon
{
	internal class Program
	{
		static void Main()
		{
			int[,] arr = new int[30, 30];

			for(int i = 0; i < 15; i++)
			{
				arr[15, 14 - i] = 1;
				arr[14 - i, 15] = 16;
				arr[15, 15 + i] = 16 * 16;
				arr[15 + i, 15] = 16 * 16 * 15;
			}
			arr[15, 15] = 0;

			for(int i = 0; i < 30; i++)
			{
				for(int j = 0; j < 30; j++)
					Console.Write(arr[i, j] + " ");
				Console.WriteLine();
			}
		}
	}
}