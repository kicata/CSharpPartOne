using System;

class OddNumber
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long[] arr = new long[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = long.Parse(Console.ReadLine());
        }
        long unique = arr[0];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            unique = unique ^ arr[i + 1];
        }
        Console.WriteLine(unique);
    }
}

