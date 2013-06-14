using System;
/*Write a program that reads an integer number n
 * from the console and prints all the numbers in the interval 
 * [1..n], each on a single line.
 * */
class PrintsAllNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int count = 1;
        if (count < 1)
        {
            Console.WriteLine("n must be greater than 1.Try again");
        }
        while (count < n)
        {
            Console.WriteLine(count);
            count++;
        }

    }
}