using System;
using System.Numerics;

class QuadronacciRectangle
{
    static void Main()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        BigInteger fourth = BigInteger.Parse(Console.ReadLine());
        int Row = int.Parse(Console.ReadLine());
        int Col = int.Parse(Console.ReadLine());

        BigInteger nextMember = first + second + third + fourth;
        int lastMember = Row * Col;
        if ((Row <= 1 )&&(Col < 5))
        {
            Console.WriteLine("{0} {1} {2} {3}",first, second, third,fourth);
        }
        else
        {
            BigInteger[] arr = new BigInteger[lastMember];
            arr[0] = first;
            arr[1] = second;
            arr[2] = third;
            arr[3] = fourth;

            arr[4] = nextMember;

            // fill array
            for (int i = 5; i < lastMember; i++)
            {
                first = second;
                second = third;
                third = fourth;
                fourth = nextMember;
                nextMember = first + second + third + fourth;
                arr[i] = nextMember;
            }
            //fill matrix
            BigInteger[,] matrix = new BigInteger[Row, Col];
            int count = 0;
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    matrix[i, j] = arr[count];
                    count++;
                }
            }
            //print
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            } 
                
        }

        

    }
}

