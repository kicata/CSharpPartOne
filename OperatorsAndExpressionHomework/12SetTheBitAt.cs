using System;
/*We are given integer number n, value v (v=0 or 1) and a position p. 
 * Write a sequence of operators that modifies n to hold the value v 
 * at the position p from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	n = 5 (00000101), p=2, v=0  1 (00000001)
 * */


class SetTheBitAt
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write an integer number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("The binery representation of the given number " + num + " is: ");
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));

        Console.WriteLine("Please write the desired bit position to change: ");
        int bitPosition = int.Parse(Console.ReadLine());

        Console.WriteLine("Please write the desired bit value \\0 or 1\\: ");
        int bitValue = int.Parse(Console.ReadLine());

        if (bitValue == 1)
        {
            int mask = 1 << bitPosition;
            int result = num | mask;

            Console.WriteLine("The binery representation of the result " + result + " is: ");

            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));


        }
        else
        {
            int mask = ~(1 << bitPosition);
            int result = num & mask;

            Console.WriteLine("The binery representation of the result " + result + " is: ");

            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        }


    }
}