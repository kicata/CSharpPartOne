using System;
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

class RootsOfQuadraticEquation
{
    static void Main(string[] args)
    {
        //read coefficients
        Console.Write("Enter first coefficient a =");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second coefficient b =");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third coefficient c =");
        double c = double.Parse(Console.ReadLine());

        double firstRoot;
        double secondRoot;
        double root;

        //define diskriminant of equation 
        double D = (b * b) - (4 * a * c);

        if (a == 0)
        {
            Console.WriteLine("a = 0. Start Again!!!");
        }
        else
        {
            if (D == 0)
            {
                Console.WriteLine("There is NO roors of a quadratic equation a*x2 + b*x + c = 0");
            }
            else if (D > 0)
            {
                firstRoot = (-b + Math.Sqrt(D)) / (2 * a);
                secondRoot = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("The roors of a quadratic equation a*x2 + b*x + c = 0 are\n {0}, {1}", firstRoot, secondRoot);
            }
            else
            {
                root = -b / (2 * a);
                Console.WriteLine("Because D < 0 the root of a quadratic equation a*x2 + b*x + c = 0 is\n {0}", root);
            }
        }

    }
}