using System;
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

class ExchangeTheTreeBits
{
    static void Main()
    {
        Console.WriteLine("Please write an positive integer number: ");
        uint num = uint.Parse(Console.ReadLine());
    
        //here we get the value of the bits
        uint mask = 1 << 3;
        uint bit3 = (num & mask) >> 3;

        mask = 1 << 4;
        uint bit4 = (num & mask) >> 4;

        mask = 1 << 5;
        uint bit5 = (num & mask) >> 5;

        mask = 1 << 24;
        uint bit24 = (num & mask) >> 24;

        mask = 1 << 25;
        uint bit25 = (num & mask) >> 25;

        mask = 1 << 26;
        uint bit26 = (num & mask) >> 26;
        
        uint temp;  //we will use temp for our temporary result
        uint result; //in result we will keep our curent result

        // here we work with 3,4,5 bit
        if (bit3 == 0)
        {
            mask = ~((uint)1 << 24);
            temp = num & mask;
        }
        else
        {
            mask = 1 << 24;
            temp = num | mask;
        }
        result = temp;

        if (bit4 == 0)
        {
            mask = ~((uint)1 << 25);
            temp = result & mask;
        }
        else
        {
            mask = 1 << 25;
            temp = result | mask;
        }
        result = temp;

        if (bit5 == 0)
        {
            mask = ~((uint)1 << 26);
            temp = result & mask;
        }
        else
        {
            mask = 1 << 26;
            temp = result | mask;
        }
        result = temp;
        // here we work with 24,25,26 bit
        if (bit24 == 0)
        {
            mask = ~((uint)1 << 3);
            temp = result & mask;
        }
        else
        {
            mask = 1 << 3;
            temp = result | mask;
        }
        result = temp;

        if (bit25 == 0)
        {
            mask = ~((uint)1 << 4);
            temp = result & mask;
        }
        else
        {
            mask = 1 << 4;
            temp = result | mask;
        }
        result = temp;

        if (bit26 == 0)
        {
            mask = ~((uint)1 << 5);
            temp = result & mask;
        }
        else
        {
            mask = 1 << 5;
            temp = result | mask;
        }
        result = temp;
        //finally print the result
        Console.WriteLine("The binary representation of number "+ num +" is: ");
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
        Console.WriteLine("The binary representaion of modified number "+result+" is:"); 
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}