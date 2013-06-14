using System;
/*Declare two string variables and assign them with following value:
 * The "use" of quotations causes difficulties.

	Do the above in two different ways: with and without using quoted strings.
 */
class DeclareTwoStringII
    {
        static void Main(string[] args)
        {
            string firtsExpr="The \"use\" of quotations causes difficulties";
            Console.WriteLine(firtsExpr);
            string use = "use";
            string secondExpr = "The "+use+" of quotations causes difficulties";
            Console.WriteLine(secondExpr);
        }
    }
