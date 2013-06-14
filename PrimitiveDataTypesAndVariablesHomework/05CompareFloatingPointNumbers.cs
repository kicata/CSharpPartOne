using System;
/*Write a program that safely compares floating-point numbers
 * with precision of 0.000001. 
 * Examples:
(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
 * */
class CompareFloatingPointNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type two floatint-point numbers to compare it");
            Console.WriteLine("Please type first number");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Please type second number");
            float secondNum = float.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                Console.WriteLine("The first number is bigger");
            }
            else if (secondNum > firstNum)
            {
                Console.WriteLine("The second number is bigger");
            }
            else
            {
                Console.WriteLine("The two numbers are equal");
            }
        }
    }

