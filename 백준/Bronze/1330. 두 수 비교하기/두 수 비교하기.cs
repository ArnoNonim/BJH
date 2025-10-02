using System;

namespace BaekJoon
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

			if (arr[0] > arr[1])
				Console.WriteLine(">");
			else if (arr[0] < arr[1])
				Console.WriteLine("<");
			else
				Console.WriteLine("==");
		}
	}
}
