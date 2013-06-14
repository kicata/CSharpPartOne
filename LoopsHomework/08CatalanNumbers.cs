using System;
//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
// (2*n)! / (n + 1)! * n!
// Write a program to calculate the Nth Catalan number by given N.

    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Enter N =");
            decimal n = decimal.Parse(Console.ReadLine());
            decimal nFirst=n;
            decimal factorialN = 1m;
            decimal factorial2N = 1m;
            decimal factorialN1 = 1m;
            decimal power = 2 * n;
            decimal sum = n + 1;
            Console.WriteLine("2n= {0}", power);
            Console.WriteLine("n+1= {0}", sum);
            while (n >= 1)
            {
                factorialN *= n;
                factorial2N *= power;
                factorialN1 *= sum;
                n--;
                power--;
                sum--;
            }
            while (power >= 1)
            {
                factorial2N *= power;
                power--;
            }
            decimal catalanN = factorial2N / (factorialN1 * factorialN);

            Console.WriteLine("The catalan number for n = {0} is: 2n!/(n+1)!*n! => Cn= {1}"
                                ,nFirst, catalanN);
            Console.WriteLine("2n!= {0}", factorial2N);
            Console.WriteLine("n+1!= {0}", factorialN1);
            Console.WriteLine("n!= {0} ", factorialN);
            
        }
    }

