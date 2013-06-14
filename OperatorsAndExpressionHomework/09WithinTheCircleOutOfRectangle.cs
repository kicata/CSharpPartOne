using System;
/*Write an expression that checks for given point (x, y) if it is within the circle 
 * K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/

class WithinTheCircleOutOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter the X coordinate: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the Y coordinate: ");
        int y = int.Parse(Console.ReadLine());


        double r = Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1)));
        if (r <= 3)
        {
            if ((x >= -1) && (y <= 1) && (y >= -1))
            {
                Console.WriteLine("Sorry the point " + x + "," + y + " is in the Circle but in the rectangle");
            }
            else
            {
                Console.WriteLine("The point " + x + "," + y + " is in the Circle and out of  the rectangle");
            }
        }
        else
        {
            Console.WriteLine("Sorry the point " + x + "," + y + " is OUT OF Circle");
        }



    }
}