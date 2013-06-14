
using System;

//** Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
//    0  "Zero"
//    273  "Two hundred seventy three"
//    400  "Four hundred"
//    501  "Five hundred and one"
//    711  "Seven hundred and eleven"
// * */

class NumberPronunciation
{
    static void Main()
    {
        Console.Write("Write a number between 0 and 999: ");
        int number = int.Parse(Console.ReadLine());

        int hundreds = number / 100;
        int tens = (number - (hundreds * 100)) / 10;
        int ones = (number - (hundreds * 100) - (tens * 10));
        int specials = number % 100;


        string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                        "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

        string[] arr2 = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };


        if (number >= 0 && number < 20)
        {
            Console.WriteLine("{0}", arr[number]);
        }
        else if (number >= 20 && number <= 99)
        {
            if (number % 10 == 0)
            {
                Console.WriteLine("{0}", arr2[tens - 2]);
            }
            else
            {
                Console.WriteLine("{0} {1}", arr2[tens - 2], arr[ones]);
            }
        }
        else if (number > 99 && number < 1000)
        {
            if (specials == 0)
            {
                Console.WriteLine("{0} hundred", arr[hundreds]);
            }
            else if (specials > 0 && specials < 20)
            {
                Console.WriteLine("{0} hundred and {1}", arr[hundreds], arr[specials]);
            }
            else if (number % 10 == 0)
            {

                Console.WriteLine("{0} hundred and {1}", arr[hundreds], arr2[tens - 2]);
            }
            else
            {
                Console.WriteLine("{0} hundred {1} {2}", arr[hundreds], arr2[tens - 2], arr[ones]);

            }
        }
    }
}



