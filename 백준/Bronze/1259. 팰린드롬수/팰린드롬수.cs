using System;
using System.Linq;
using System.Text;

namespace BaekJoon
{
	class Program
	{
		static void Main()
		{
			StringBuilder sb = new StringBuilder();
			while (true)
			{
				string input = Console.ReadLine();

				if (input == "0")
					break;

				string reversed = new string(input.Reverse().ToArray());

				sb.AppendLine(input == reversed ? "yes" : "no");
			}

			Console.Write(sb.ToString());
		}
	}
}
