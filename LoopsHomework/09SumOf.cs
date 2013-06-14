using System;
//Write a program that, for a given two integer numbers N and X, calculates the sum
//S = 1 + 1!/X + 2!/X2 + … + N!/XN

    class SumOf
    {
        static void Main()
        {
            Console.Write("Enter N =");
            decimal n = decimal.Parse(Console.ReadLine());
            Console.Write("Enter X =");
            decimal x = decimal.Parse(Console.ReadLine());

            decimal power = 1;
            decimal factorialN = 1m;
            decimal sum = 1;

            for (int i = 1; i <= n; i++)
            {
                power *= x;
                factorialN *= i;
                sum += (factorialN / power);

            }

            Console.WriteLine("S = 1 + 1!/X + 2!/X2 + … + N!/XN => {0}",sum);
            Console.WriteLine("n!= {0}",factorialN);
            Console.WriteLine("X{0}^n{1}= {2}",x,n,power);   
        }
    }

