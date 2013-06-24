using System;
using System.Numerics;
class TribonachiTriangle
{
    static void Main()
    {

        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
       // int cols = rows;
       // int nMember = int.Parse(Console.ReadLine());
       
       
        if (rows < 2)
        {
            Console.WriteLine(first);
        }
        else if (rows == 2)
        {
            Console.Write(second);
            Console.Write(" ");
            Console.Write(third);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(first);
            Console.Write(second);
            Console.Write(" ");
            Console.Write(third);
            Console.WriteLine();
            BigInteger nextMember = first + second + third;

            for (int i = 3; i <= rows; i++)
            {
                for (int j= 0; j < i; j++)
                {
                    Console.Write(nextMember);
                    Console.Write(" ");

                    first = second;
                    second = third;
                    third = nextMember;
                    nextMember = first + second + third;

                }
                Console.WriteLine();

            }
            
        }
    }
}

