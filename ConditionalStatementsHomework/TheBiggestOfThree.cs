using System;
//Write a script that finds the biggest of three integers using nested if statements.

class TheBiggestOfThree
    {
        static void Main()
        {
           Console.Write("Enter integer number a = ");
           int firstValue =int.Parse(Console.ReadLine());

           Console.Write("Enter integer number b = ");
           int secondValue =int.Parse(Console.ReadLine());

           Console.Write("Enter integer number c = ");
           int thirdValue =int.Parse(Console.ReadLine());

           int greater = thirdValue;

           if ((firstValue > thirdValue)||(secondValue > thirdValue))
           {
               if (firstValue > secondValue)
               {
                   greater = firstValue;
                   Console.WriteLine("The greater number is {0}",greater);
               }
               else
               {
                   greater = secondValue;
                   Console.WriteLine("The greater number is {0}", greater);
               }
           }
           else
           {
               greater = thirdValue;
               Console.WriteLine("The greater number is {0}", greater);
           }
        }
    }

