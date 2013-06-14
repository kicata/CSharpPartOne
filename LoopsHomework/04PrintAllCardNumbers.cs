using System;
/*Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
// The cards should be printed with their English names. Use nested for loops and switch-case.
 * 
 * Spatia=1 / Karo=2 / Pika=3 / Kupa=4
 * J=11/ Q=12/ K=13 /A =14
 * 
 * */
class PrintAllCardNumbers
{
    static void Main()
    {
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine(i + ":");
            for (int j = 2; j <= 14; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

