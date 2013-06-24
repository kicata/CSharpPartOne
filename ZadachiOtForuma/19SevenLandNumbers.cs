using System;


class SevenLandNumbers
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int powerCounter = 0;
        int decimalNumber = 0;
        int result = 0;
        string sevenland = "";
        string reverse="";
        //from 7->10
        while (inputNumber!=0)
        {
            int lastNumber = inputNumber % 10;
            decimalNumber = decimalNumber + lastNumber * (int)Math.Pow(7, powerCounter);
            inputNumber /= 10;
            powerCounter++;
        }
        decimalNumber++;
        //from 10->7
        while (decimalNumber != 0)
        {
            int ostatyk = decimalNumber % 7;
            sevenland= sevenland + ostatyk.ToString();
            decimalNumber/=7;         
        }

        //reverse string
       
        for (int i = sevenland.Length - 1; i >= 0; i--)
        {
            reverse += sevenland[i];
        }

        result=int.Parse(reverse);
        Console.WriteLine(result);

    }
}

