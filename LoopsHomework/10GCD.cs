using System;
//Write a program that calculates the greatest common divisor
// (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

class GCD
{
    static void Main()
    {
        Console.Write("Enter a = ");
        double a = int.Parse(Console.ReadLine());
        Console.Write("Enter b = ");
        double b = int.Parse(Console.ReadLine());

        double division;
        double divisionRemainder;

        if (b == 0)
        {
            Console.WriteLine("The GCD is {0}", a);
        }
        else
        {
            while (true)
            {
                division = a / b;
                divisionRemainder = a % b;
                if (divisionRemainder != 0)
                {
                    Console.WriteLine("{0} : {1} = {2} ; with reminder = {3}", a, b, division, divisionRemainder);
                    a = b;
                    b = divisionRemainder;
                }
                else
                {
                    Console.WriteLine("The GCD is: {0}", b);
                    break;
                }
            }
        }
       
    }

}
