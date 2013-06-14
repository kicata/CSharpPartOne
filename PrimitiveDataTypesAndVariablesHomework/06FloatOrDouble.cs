using System;
/*Which of the following values can be assigned to a variable of type
 * float and which to a variable of type double: 34.567839023, 12.345,
 * 8923.1234857, 3456.091?
 * */
class FloatOrDouble
    {
        static void Main(string[] args)
        {
            double firstNum = 34.567839023;
            float secondNum = 12.345f;
            double thirdNum = 8923.1234857;
            float fourthNum = 3456.091f;

            Console.WriteLine(" The  number "+ firstNum + " is doubleType");
            Console.WriteLine(" The  number " + secondNum + " is floatType");
            Console.WriteLine(" The  number " + thirdNum + " is doubleType");
            Console.WriteLine(" The  number " + fourthNum + " is floatType");

        }
    }

