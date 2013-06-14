﻿using System;

//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

class CalculateTheSumWithPrecision
{
    static void Main()
    
    {
       decimal sum = 1.0m;

        for (int i = 2; i <= 1000; i++)
        {
            sum += (1m / i);
            i++;
            sum -= (1m / i);
        }
        Console.WriteLine("The sum is: {0:0.000}", sum); 
    }
}
   