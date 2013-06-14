using System;
using System.Threading;
using System.Globalization;

//Sort 3 real values in descending order using nested if statements.
class ThreeRealInDecending
{
    static void Main()
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

        decimal greater = thirdValue;
        //testing
        if ((firstValue > thirdValue) || (secondValue > thirdValue))
        {
            if (firstValue > secondValue)
            {
                greater = firstValue;
                Console.WriteLine("The decending sequence of this 3 real numbers is {0:0.0000} , {1:0.0000}, {2:0.0000}", greater, secondValue, thirdValue);
            }
            else
            {
                greater = secondValue;
                Console.WriteLine("The decending sequence of this 3 real numbers is {0:0.0000} , {1:0.0000}, {2:0.0000}", greater, firstValue, thirdValue);
            }
        }
        else if ((thirdValue > firstValue) || (thirdValue > secondValue))
        {
            greater = thirdValue;

            if (firstValue > secondValue)
            {
                decimal middle = firstValue;
                Console.WriteLine("The decending sequence of this 3 real numbers is {0:0.0000} , {1:0.0000}, {2:0.0000}", greater, middle, secondValue);
            }
            else
            {
                decimal middle = secondValue;
                Console.WriteLine("The decending sequence of this 3 real numbers is {0:0.0000} , {1:0.0000}, {2:0.0000}", greater, middle, firstValue);
            }
        }
    }
}

