using System;
/*Write a program that reads two positive integer numbers 
and prints how many numbers p exist between them such that
the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
 * */
class betweenTwoPositiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first positive integer number :");
        uint a = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter second positive integer number :");
        uint b = uint.Parse(Console.ReadLine());

        int p = 0;

        if (a >= b)
        {
            Console.WriteLine("The first number must be smaller than the second.Try again!");
        }
        else
        {
            for (uint i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }

            }
            Console.WriteLine("There are {0} numbers", p);
        }
    }
}