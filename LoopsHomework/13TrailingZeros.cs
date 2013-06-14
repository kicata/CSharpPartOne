using System;
using System.Numerics;
//Write a program that calculates for given N how many trailing zeros
//present at the end of the number N!. Examples:
// N = 10 ? N! = 3628800 ? 2
// N = 20 ? N! = 2432902008176640000 ? 4
// Does your program work for N = 50 000?
// Hint: The trailing zeros in N! are equal to the number of its prime
//divisors of value 5. Think why!
    class TrailingZeros
    {
        static void Main()
        {
            Console.Write("Enter N =");
            int n = int.Parse(Console.ReadLine());
            int nStart = n;
            BigInteger factorialN = 1;
            int counter5 = 0;
            while (n > 1)
            {
                if (n % 5 == 0)
                {
                    counter5++;
                }

                factorialN *= n;
                n--;
                
            }
            Console.WriteLine("Facturiel of {0} has {1} zeeros \n in rezult {2}", nStart, counter5, factorialN);     
        }
    }

