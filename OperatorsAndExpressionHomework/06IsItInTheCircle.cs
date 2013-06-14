using System;
//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

class IsItInTheCircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Check if given point (x,  y) is within a circle K(O, 5).");
        Console.WriteLine("Please write the point coordinate for X:");
        int X = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write the point coordinate for Y:");
        int Y = int.Parse(Console.ReadLine());

        char CenterSymbol = 'O';
        int center=(int)CenterSymbol;
        
        int realCenter = center-center;
        int radius = 5;
        int realX = X - center;
        int realY = Y - center;
        double distance = Math.Sqrt((realX * realX) + (realY *realY));

        if (distance<= radius)
        {
            Console.WriteLine("The point:" + X + "," + Y + " is within a circle K(O, 5)");
        }
        else
        {
            Console.WriteLine("The point:" + X + "," + Y + " is NOT within a circle K(O, 5)");
        }
    }
}

