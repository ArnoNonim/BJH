namespace Baekjoon
{
	internal class Program
    {
        static int n;
        static int[,] fibonacci = new int[41, 2];

        static void Main(string[] args)
        {
            using (var write = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
				n = int.Parse(Console.ReadLine());
				for (int i = 0; i < n; i++)
				{
					int index = int.Parse(Console.ReadLine());
					Fibonacci(index);
					write.WriteLine($"{fibonacci[index, 0]} {fibonacci[index, 1]}");
				}
			}
        }

        static (int, int) Fibonacci(int n)
        {
            if (n == 0)
            {
                fibonacci[0, 0] = 1;
                fibonacci[0, 1] = 0;
                return (fibonacci[0, 0], fibonacci[0, 1]);
            }
            else if (n == 1)
            {
                fibonacci[1, 0] = 0;
                fibonacci[1, 1] = 1;
                return (fibonacci[1, 0], fibonacci[1, 1]);
            }
            if (fibonacci[n, 0] != 0 && fibonacci[n, 1] != 0)
                return (fibonacci[n, 0], fibonacci[n, 1]);
            else
            {
                fibonacci[n, 0] = Fibonacci(n - 1).Item1 + Fibonacci(n - 2).Item1;
                fibonacci[n, 1] = Fibonacci(n - 1).Item2 + Fibonacci(n - 2).Item2;
                return (fibonacci[n, 0], fibonacci[n, 1]);
            }
        }
    }
}
