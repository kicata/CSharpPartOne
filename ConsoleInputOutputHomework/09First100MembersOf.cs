using System;
/*Write a program to print the first 100 members of the
 *sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
*/
class First100MembersOf
{
    static void Main()
    {
        ulong a = 0;
        ulong b = 1;
        ulong sum = a + b;
        Console.Write(a + ",");
        Console.Write(b + ",");
        Console.Write(sum + ",");
        for (int membrCount = 0; membrCount < 100; membrCount++)
        {
            a = b;

            b = sum;

            sum = a + b;
            Console.Write(sum + " , ");
        }
    }
}