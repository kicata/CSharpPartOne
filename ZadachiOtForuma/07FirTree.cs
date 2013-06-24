using System;

class FirTree
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int halfpart = rows - 2;
        int star = 1;
        for (int i = 1; i < rows; i++)
        {
            Console.Write(new string('.',halfpart));
            Console.Write(new string('*',star));
            Console.Write(new string('.',halfpart));
            Console.WriteLine();
            halfpart--;
            star = star + 2;
        }
        halfpart = rows - 2;
        star = 1;
        Console.Write(new string('.', halfpart));
        Console.Write(new string('*', star));
        Console.Write(new string('.', halfpart));
    }
}

