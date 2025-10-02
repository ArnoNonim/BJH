using System;

namespace BaekJoon
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			int[] brr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

			for(int i = 0; i < arr[0]; i++)
			{
				if (arr[1] > brr[i])
					Console.Write(brr[i] + " ");
			}
		}
	}
}
