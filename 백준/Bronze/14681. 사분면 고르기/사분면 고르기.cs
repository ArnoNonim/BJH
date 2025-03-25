namespace CS_250325
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int x = int.Parse(Console.ReadLine());
			int y = int.Parse(Console.ReadLine());

            if (x < 0)
            {
				if (y < 0)
					Console.WriteLine(3);
				else
					Console.WriteLine(2);
			}
            else
            {
				if (y < 0)
					Console.WriteLine(4);
				else
					Console.WriteLine(1);
			}
		}
    }
}
