using System;
//Write a program that reads from the console a positive integer number N (N < 20)
//and outputs a matrix


    class SimpleMatrix
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = i; j < n+i; j++)
                {
                    Console.Write(j + " " );
                }
            }
        }
    }

