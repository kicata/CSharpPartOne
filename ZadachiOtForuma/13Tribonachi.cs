using System;
using System.Numerics;
class Tribonachi
{
    static void Main()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        int nMember = int.Parse(Console.ReadLine());

        BigInteger nextMember = first + second + third;
        if (nMember==1)
        {
            Console.WriteLine(first);
        }
        else if (nMember == 2)
        {
            Console.WriteLine(second);
        }
        else if (nMember == 3)
        {
            Console.WriteLine(third);
        }
        else if (nMember == 4)
        {
            Console.WriteLine(nextMember);
        }
        else
        {
            for (int i = 5; i <=nMember; i++)
            {
                first = second;
                second = third;
                third = nextMember;
                nextMember = first + second + third;
            }
            Console.WriteLine(nextMember);
        }
        
    }
}


