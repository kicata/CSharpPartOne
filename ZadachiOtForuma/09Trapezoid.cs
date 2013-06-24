using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDods = n - 1;
        int innerDots = n - 1;
        int trapezoidHeight = n - 1;
        
        //First row
        Console.Write(new string('.',n));
        Console.Write(new string('*', n));
        Console.WriteLine();
        //Middle part
        for (int i = 1; i <= trapezoidHeight; i++)
        {
            Console.Write(new string('.', outerDods));
            Console.Write("*");
            Console.Write(new string('.', innerDots));
            Console.Write("*");
            Console.WriteLine();
            outerDods--;
            innerDots++;
        }
        //Last row
        Console.Write(new string('*',2*n));
        Console.WriteLine();

    }
}

