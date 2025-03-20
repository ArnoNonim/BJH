namespace Baekjoon
{
	internal class Program
    {
        static void Main(string[] args)
        {
            double[] n = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

            Console.WriteLine(n[0] / n[1]);
		}
    }
}
