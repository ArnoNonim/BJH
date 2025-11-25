namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;

            for(int i = 0; i < n; i++)
                sum += int.Parse(input[i].ToString());

			Console.WriteLine(sum);
		}
    }
}
