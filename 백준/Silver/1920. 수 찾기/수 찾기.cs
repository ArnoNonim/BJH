using System;
using System.Linq;
using System.Text;

namespace AlgorithmPrac
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ReadLine();
			var n = Console.ReadLine().Split().ToList();
			n.Sort();

			Console.ReadLine();
			var m = Console.ReadLine().Split().ToList();

			var sb = new StringBuilder();

			for (int i = 0; i < m.Count; i++)
			{
				var check = n.BinarySearch(m[i]);
				if (check > -1)
				{
					sb.Append("1" + Environment.NewLine);
				}
				else
				{
					sb.Append("0" + Environment.NewLine);
				}
			}
			Console.Write(sb.ToString());
		}
	}
}