using System;
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

    class IsItPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a positive integer from 0 to 100: ");
            int num = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (num<2)
            {
                Console.WriteLine("Numbers smaller than 2 is not prime numbers.");
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    
                        if (num % i == 0)
                        {
                            isPrime = false;
                        }
                 }
            }
            if (isPrime==true)
            {
                Console.WriteLine("The Number "+num+" is prime");
            }
            else
            {
                Console.WriteLine("The Number " + num + " is NOT prime");    
            }
        }
    }

