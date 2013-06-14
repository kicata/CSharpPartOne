using System;
/*Find online more information about ASCII (American Standard Code for Information Interchange) 
 * and write a program that prints the entire ASCII table of characters on the console.
 */
    class PrintASCIItable
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 128; i++)
            {
                char a = (char)i;
                Console.WriteLine(a);
            }
        }
    }

