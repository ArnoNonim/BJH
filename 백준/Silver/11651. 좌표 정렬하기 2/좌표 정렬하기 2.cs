using System;
using System.Linq;
using System.Text;

class Program
{
	class Member
	{
		public int X { get; set; }
		public int Y { get; set; }
	}

	static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine()!);

		var members = new Member[n];
		for (int i = 0; i < n; i++)
		{
			string[] input = Console.ReadLine().Split();
			members[i] = new Member
			{
				X = int.Parse(input[0]),
				Y = int.Parse(input[1])
			};
		}

		StringBuilder sb = new StringBuilder();
		Member[] sortedMember = members.OrderBy(m => m.Y).ThenBy(m => m.X).ToArray();

		foreach (var member in sortedMember)
			sb.AppendLine($"{member.X} {member.Y}");

		Console.Write(sb.ToString());
	}
}