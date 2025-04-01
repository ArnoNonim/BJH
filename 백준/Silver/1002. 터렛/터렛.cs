using System;

namespace Baekjoon
{
	internal class Program
    {
        static void Main(string[] args)
        {
			var cntCase = int.Parse(Console.ReadLine()!);
			for (int c = 0; c < cntCase; c++)
			{
				var input = Console.ReadLine()!.Split(' ');
				var x1 = int.Parse(input[0]);
				var y1 = int.Parse(input[1]);
				var r1 = int.Parse(input[2]);
				var x2 = int.Parse(input[3]);
				var y2 = int.Parse(input[4]);
				var r2 = int.Parse(input[5]);

				var distSqrd = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
				var sumRadSqrd = Math.Pow(r1 + r2, 2);
				var diffRadSqrd = Math.Pow(r1 - r2, 2);

				if (distSqrd == 0)
				{
					if (r1 == r2) Console.WriteLine(-1);
					else Console.WriteLine(0);
				}
				else if (distSqrd == sumRadSqrd || distSqrd == diffRadSqrd)
					Console.WriteLine(1);
				else if (distSqrd > diffRadSqrd && distSqrd < sumRadSqrd)
					Console.WriteLine(2);
				else Console.WriteLine(0);
			}
		}
    }
}
