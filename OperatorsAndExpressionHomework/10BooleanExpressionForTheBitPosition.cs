using System;
/*Write a boolean expression that returns if the bit at position p
 * (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.
*/
class BooleanExpressionForTheBitPosition
{
    static void Main()
    {
        Console.WriteLine("Please write an integer number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write the position which you desire to check: ");
        int p = int.Parse(Console.ReadLine());


        int mask = 1 << p;
        int numAndMask = num & mask;
        int bit = numAndMask >> p;
        bool bitPol = true;
        if (bit == 1)
        {
            Console.WriteLine("the bit "+p+" (counting from 0) of a typed in integer " + num + " is 1");
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine(bitPol);
        }
        else
        {
            Console.WriteLine("the bit " + p + " (counting from 0) of a typed in integer " + num + " is 0");
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            bitPol = false;
            Console.WriteLine(bitPol);
        }
    }
}

