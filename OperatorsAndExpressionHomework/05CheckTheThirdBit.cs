using System;
//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

class CheckTheThirdBit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write an integer number: ");
        int num = int.Parse(Console.ReadLine());

        int mask = 1 << 3;
        int numAndMask = num & mask;
        int bit = numAndMask >> 3;

        if (bit == 1)
        {
            Console.WriteLine("the bit 3 (counting from 0) of a tiped in integer " + num + " is 1");
            Console.WriteLine(Convert.ToString(num,2).PadLeft(32,'0'));
        }
        else
        {
            Console.WriteLine("the bit 3 (counting from 0) of a tiped in integer " + num + " is 0");
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
        }
    }
}

