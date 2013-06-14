using System;
//Write an expression that calculates rectangle’s area by given width and height.


class RectanglesArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please type in the rectangle’s  WIDTH: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Please type in the rectangle’s  HEIGHT: ");
        int height = int.Parse(Console.ReadLine());

        int area = (width * height);
        Console.WriteLine("The rectangle aria is {0}",area);
    }
}

