using System;
//Write a program that calculates N!/K! for given N and K (1<K<N).

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter N and K so (1 < K < N)");
        Console.Write("Enter K =");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter N =");
        int n = int.Parse(Console.ReadLine());
        decimal factorialK = 1;
        decimal factorialN = 1;
        decimal rezult;

        if ((1 < k) && (k < n))
        {
            while (1 < k)
            {
                factorialK *= k;
                k--;
            }
            while (1 < n)
            {
                factorialN *= n;
                n--;
            }

            rezult = factorialN / factorialK;

            Console.WriteLine("The result of N !{0} / K !{1}  is {2}",factorialN, factorialK, rezult);
        }
        else
        {
            Console.WriteLine("Try again and remember (1 < K < N)");
        }
    }
}

