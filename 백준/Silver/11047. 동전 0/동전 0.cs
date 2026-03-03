using System;

class Program
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = arr[0];
        int k = arr[1];

        int[] coins = new int[n];
        for (int i = 0; i < n; i++)
            coins[i] = int.Parse(Console.ReadLine());

        int cnt = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            cnt += k / coins[i];
            k %= coins[i];
        }

        Console.WriteLine(cnt);
    }
}