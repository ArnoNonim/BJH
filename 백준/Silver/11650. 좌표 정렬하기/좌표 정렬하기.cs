using System;
using System.Linq;

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

		Member[] sortedMember = members.OrderBy(m => m.X).ThenBy(m => m.Y).ToArray();

		foreach (var member in sortedMember)
			Console.WriteLine($"{member.X} {member.Y}");
	}
}