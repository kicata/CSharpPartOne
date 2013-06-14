using System;
//Write a program that reads a number N and calculates
// the sum of the first N members of the sequence of
//Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

class PrintNSumOfFibonachiNumbers
{
    static void Main()
    {
        Console.Write("Enter how many Fibbonachi numbers you want to print ");
        ulong n = ulong.Parse(Console.ReadLine());
        ulong a = 0;
        ulong b = 1;
        ulong sum = a + b;
        ulong actualSum = 2;
        Console.WriteLine("This is the fibbonachi sequence from 0 to n-> {0}:",n);
        Console.Write(a + ", ");
        Console.Write(b + ", ");
        Console.Write(sum + ", ");

        for (ulong i = 0; i < n-3; i++)
        {
            a = b;
            b = sum;
            sum = a + b;
            Console.Write(sum + " , ");
            actualSum += sum;
        }
        Console.WriteLine();
        Console.WriteLine("And the sum of those members is: {0}",actualSum);
    }
}
