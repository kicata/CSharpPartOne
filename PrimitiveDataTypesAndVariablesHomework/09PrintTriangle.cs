using System;

/*Write a program that prints an isosceles triangle 
 * of 9 copyright symbols ©. Use Windows Character Map
 * to find the Unicode code of the © symbol. Note: the 
 * © symbol may be displayed incorrectly.
 */
class PrintTriangle
{
    static void Main(string[] args)
    {

        char copySign = '\u00A9';
        /*
                    Console.WriteLine(" " + " " + " " + copySign);
                    Console.WriteLine(" " + " " + copySign + copySign + copySign);
                    Console.WriteLine(" " + copySign + copySign + copySign + copySign + copySign);
        */

        int row = 3, symbol = 1, col = 5;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < (col - symbol) / 2; j++)
            {
                Console.Write("  ");
            }
            for (int j = 0; j < symbol; j++)
            {
                Console.Write(copySign +" ");
            }
            symbol += 2;
            Console.WriteLine();
        }

    }
}