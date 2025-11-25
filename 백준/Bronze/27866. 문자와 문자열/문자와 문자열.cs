namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(input.Substring(n - 1, 1));
        }
    }
}
