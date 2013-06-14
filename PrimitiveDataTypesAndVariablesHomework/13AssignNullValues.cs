using System;
/*Create a program that assigns null values to an integer and to double variables.
 * Try to print them on the console, try to add some values or the null literal to 
 * them and see the result.
 */

class AssignNullValues
{
    static void Main(string[] args)
    {
        int a = 5;
        double b= 0.45;
        double sum = a + b;
        Console.WriteLine(sum);

        int? na = a;
        double? nb = b;
        double? nsum = na+nb;
        Console.WriteLine(nsum);

        int? naNull = null;
        Console.WriteLine((na + naNull));
        Console.WriteLine((nb + naNull));
    }
}

