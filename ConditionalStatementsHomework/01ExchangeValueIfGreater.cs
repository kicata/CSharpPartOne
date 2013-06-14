using System;
//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
class ExchangeValueIfGreater
{
    static void Main(string[] args)
    {
        Console.Write("Enter integer  number a = ");
        int firstValue = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer  number b = ");
        int secondValue = int.Parse(Console.ReadLine());

        int greater = secondValue;

        if (firstValue < secondValue)
        {
            Console.WriteLine("b {0} is greater",greater);
        }
        else if (firstValue > secondValue)
        {
            
            greater = firstValue;
            firstValue = secondValue;
           
            Console.WriteLine("a > b but if a = {0} and b = {1} so b > a",firstValue, greater);
        }
        else
        {
            Console.WriteLine(" The two numbers are equal so start again ");
        }

    }
}

