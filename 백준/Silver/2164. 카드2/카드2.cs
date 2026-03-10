using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		if (n == 1)
		{
			Console.WriteLine(1);
			return;
		}

		Queue<int> cards = new Queue<int>();
		for (int i = 0; i < n; i++)
			cards.Enqueue(i + 1);

		while (true)
		{
			cards.Dequeue();
			if (cards.Count == 1) break;
			int card = cards.Dequeue();
			cards.Enqueue(card);
		}

		Console.WriteLine(cards.Peek());
	}
}