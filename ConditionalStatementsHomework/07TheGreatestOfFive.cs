using System;
//Write a program that finds the greatest of given 5 variables.
class TheGreatestOfFive
    {
        static void Main(string[] args)
        {
           Console.Write("Enter integer number a = ");
           int firstValue =int.Parse(Console.ReadLine());

           Console.Write("Enter integer number b = ");
           int secondValue =int.Parse(Console.ReadLine());

           Console.Write("Enter integer number c = ");
           int thirdValue =int.Parse(Console.ReadLine());

           Console.Write("Enter integer number d = ");
           int fourthValue = int.Parse(Console.ReadLine());

           Console.Write("Enter integer number e = ");
           int fiftValue = int.Parse(Console.ReadLine());

           int greater = fiftValue;
           int[] numbers = new int[5] { firstValue, secondValue, thirdValue, fourthValue, fiftValue };

           foreach (int i in numbers)
           {
               if (i > greater)
               {
                   greater = i;
               }
               
           }
           System.Console.WriteLine("The greater number is {0}", greater);

           
        }
    }

