using System;
//Write a program that prints all the numbers from 1 to N,
//that are not divisible by 3 and 7 at the same time.

    class NotDevisibleBy3And7
    {
        static void Main()
        {
            Console.Write("Please enter N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The numbers form 1 to n that are NOT devided by 3 and 7 at the same time are: ");
            for (int i = 1; i < n; i++)
            {  
                if ((i % 3==0)&&(i % 7 ==0))
                {
                    continue; 
                }
                else
                {
                    Console.Write(i + " ");
                }
                

            }
        }
    }

