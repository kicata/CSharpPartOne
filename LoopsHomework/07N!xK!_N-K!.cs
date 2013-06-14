using System;
//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N and K so (1 < K < N)");
            Console.Write("Enter K =");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter N =");
            int n = int.Parse(Console.ReadLine());
            decimal factorialK = 1;
            decimal factorialN = 1;
            decimal razlikaFactorial = 1;
            decimal razlika = n - k;
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
                while (1 < razlika)
                {
                   razlikaFactorial *= razlika;
                    razlika--;
                }
                rezult = (factorialN * factorialK) / razlikaFactorial;

                Console.WriteLine("The result of N !{0} * K !{1} / (N-K)! {2} is {3}", factorialN, factorialK,razlikaFactorial, rezult);
            }
            else
            {
                Console.WriteLine("Try again and remember (1 < K < N)");
            }
        }
    }

