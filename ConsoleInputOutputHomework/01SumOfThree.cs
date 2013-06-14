using System;
//Write a program that reads 3 integer numbers from the console and prints their sum
class SumOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter a= :");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b= :");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter c= :");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("a + b +c ={0} + {1} + {2} = {3}", a, b, c, a + b + c);
    }
}