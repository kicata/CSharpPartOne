using System;
//Write a program that reads the radius r of a circle and prints its perimeter and area.
class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        Console.Write("Enter circle radius r= : ");
        int r = int.Parse(Console.ReadLine());
        double pi = 3.14;
        double perimeter = pi * (r * r);
        double area = 2 * pi * r;
        Console.WriteLine("The perimeter of a circle with radius {0}, is {1}\n" + "and the circle area is {2}", r, perimeter, area);
    }
}