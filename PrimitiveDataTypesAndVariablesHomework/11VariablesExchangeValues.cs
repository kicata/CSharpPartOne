using System;
/*Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
 */
class VariablesExchangeValues
{
    static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int exchValue1 = (a+b) - a;
            int exchValue2 = (a+b) - b;
            Console.WriteLine("The value of a is: " + a + "\n" + "The value of b is: " + b + "\n" +
                "The exchange value of a is: " + exchValue1 + "\n" + "The exchange value of b is: " + exchValue2 + "\n");
        }
}