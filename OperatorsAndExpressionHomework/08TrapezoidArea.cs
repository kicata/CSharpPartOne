using System;
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

class TrapezoidArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter h: ");
            int h = int.Parse(Console.ReadLine());

            double area = ((a + b) * h) / 2;

            Console.WriteLine("The trapezoid area = "+ area);

        }
    }

