using System;
using System.Linq;

class Program
{
	class Member
	{
		public int Age { get; set; }
		public string? Name { get; set; }
		public int Order { get; set; }
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
				Age = int.Parse(input[0]),
				Name = input[1],
				Order = i
			};
		}

		Member[] sortedMember = members.OrderBy(m => m.Age).ThenBy(m => m.Order).ToArray();

		foreach (var member in sortedMember)
			Console.WriteLine($"{member.Age} {member.Name}");

	}
}