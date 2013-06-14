using System;
using System.Threading;
using System.Globalization;

//Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

class ProductOfThreeSign
{

    static void Main(string[] args)
    {  
        //reseting culture
        Thread.CurrentThread.CurrentCulture =
        CultureInfo.InvariantCulture;
        //reading numbers
        Console.Write("Enter real number a = ");
        decimal firstValue = decimal.Parse(Console.ReadLine());

        Console.Write("Enter real number b = ");
        decimal secondValue = decimal.Parse(Console.ReadLine());

        Console.Write("Enter real number c = ");
        decimal thirdValue = decimal.Parse(Console.ReadLine());

        char sign = '+';
        //testing
        if ((firstValue == 0) || (secondValue == 0) || (thirdValue == 0))
        {
            Console.WriteLine("Start again one of the numbers is 0");
        }
        else if ((firstValue < 0) && (secondValue < 0) && (thirdValue < 0))
        {
            sign = '-';
            Console.WriteLine("The sign is {0}", sign);
        }
        else if ((firstValue < 0) && (secondValue < 0) ||
              (firstValue < 0) && (thirdValue < 0) ||
              (secondValue < 0) && (thirdValue < 0))
        {
            sign = '+';
            Console.WriteLine("The sign is {0}", sign);
        }
        else if ((firstValue < 0) || (secondValue < 0) || (thirdValue < 0))
        {
            sign = '-';
            Console.WriteLine("The sign is {0}", sign);
        }
        else
        {
            sign = '+';
            Console.WriteLine("The sign is {0}", sign);
        }
    }
}

