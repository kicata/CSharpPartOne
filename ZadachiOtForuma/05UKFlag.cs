using System;

class UKFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int middle = n / 2;
        int outerDots = 0;
        int innerDots = (n / 2) - 1;
        for (int i = 0; i < middle; i++)
        {
            Console.Write(new string('.',outerDots));
            Console.Write('\\');
            Console.Write(new string('.', innerDots));
            Console.Write('|');
            Console.Write(new string('.', innerDots));
            Console.Write('/');
            Console.Write(new string('.', outerDots));
            Console.WriteLine();
            outerDots++;
            innerDots--;
        }

        Console.Write(new string('-', middle));
        Console.Write("*");
        Console.Write(new string('-', middle));
        Console.WriteLine();

         outerDots = (n / 2) - 1;
         innerDots = 0;

        for (int i = 0; i < middle; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write('/');
            Console.Write(new string('.', innerDots));
            Console.Write('|');
            Console.Write(new string('.', innerDots));
            Console.Write('\\');
            Console.Write(new string('.', outerDots));
            Console.WriteLine();
            innerDots++;
            outerDots--;  
        }

    }
}

