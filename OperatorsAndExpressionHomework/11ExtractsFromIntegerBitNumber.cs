using System;
/*Write an expression that extracts from a given integer i 
 * the value of a given bit number b. Example: i=5; b=2  value=1
 * */
class ExtractsFromIntegerBitNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write an integer number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Please write the desired bit number: ");
        int bitNumber = int.Parse(Console.ReadLine());

        int mask = 1 << bitNumber;
        int numAndMask = num & mask;
        int bitValue = numAndMask >> bitNumber;

        Console.WriteLine("The value of the bit in position " + bitNumber + " of number " + num + " is " + bitValue);
    }
}
