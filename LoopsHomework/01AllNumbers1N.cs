using System;
//Write a program that prints all the numbers from 1 to N.
    class AllNumbers1N
    {
        static void Main()
        {
            Console.Write("Please enter N = ");
            int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i < n;  i++ )
            //{
            //    Console.Write(i + " ");
                
            //}
            int count = 1;
            while (count < n)
            {
                Console.Write(count + " ");
                count++;
            }
        }
    }

