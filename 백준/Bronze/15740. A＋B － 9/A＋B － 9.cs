using System;
using System.Numerics;

class Program
{
	static void Main()
	{
		BigInteger[] arr = Array.ConvertAll(Console.ReadLine().Split(), BigInteger.Parse);
		Console.WriteLine(arr[0] + arr[1]);
	}
}