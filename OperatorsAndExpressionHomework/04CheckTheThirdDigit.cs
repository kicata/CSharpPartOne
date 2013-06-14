using System;
//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

class CheckTheThirdDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write at least 4 digit integer number :");
        int num = int.Parse(Console.ReadLine());
        int cont = num / 100;
        if (cont%10==7)
        {
            Console.WriteLine("The tird digit \\from right to left\\ of number "+ num + " is 7");
        }
        else
        {
            Console.WriteLine("The tird digit \\from right to left\\ of number " + num + " is not 7");
        }
    }
}

