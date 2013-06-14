using System;
//Write an expression that checks if given integer is odd or even


    class OddOrEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write an integer number:");
            int num = int.Parse(Console.ReadLine());

            if (num%2==0)
            {
                Console.WriteLine("The number "+ num +" is even");
            }
            else
            {
                Console.WriteLine("The number " + num + "is odd");
            }
        }
    }

