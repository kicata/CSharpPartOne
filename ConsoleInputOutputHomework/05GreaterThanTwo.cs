using System;
/*Write a program that gets two numbers from the console and prints 
the greater of them. Don’t use if statements.
 * */

class GreaterThanTwo
{
    static void Main()
    {
        Console.Write("Enter a= :");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b= :");
        int b = int.Parse(Console.ReadLine());
        int greater = Math.Max(a, b);
        Console.WriteLine("The greater number is {0}", greater);
    }
}