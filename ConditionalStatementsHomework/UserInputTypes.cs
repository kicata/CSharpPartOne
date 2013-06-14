using System;
using System.Threading;
using System.Globalization;
/* Write a program that, depending on the user's choice inputs int,
 double or string variable. If the variable is integer or double, increases it with 1.
 If the variable is string, appends "*" at its end. The program must show the value of that
 variable as a console output. Use switch statement.
 * */
    class UserInputTypes
    {
        static void Main()
        {
            //reseting culture
            Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;

            Console.WriteLine("Enter    1 for int\n \t 2 for double\n\t 3 for string");
            byte userChoice = byte.Parse(Console.ReadLine());
            
            switch (userChoice)
            {
                case 1:
                    Console.Write("Now type your variable = ");

                    int intUserChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result is {0}",intUserChoice + 1);
                    break;
                case 2:
                    Console.Write("Now type your variable = ");

                    double doubleUserChoice = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result is {0:0.000}",doubleUserChoice + 1);
                    break;
                case 3:
                    Console.Write("Now type your variable = ");

                    string stringUserChoice = Console.ReadLine();
                    Console.WriteLine("Result is {0}", stringUserChoice + "*");
                    break;
                default: Console.WriteLine("Invalid input! Start again.....");
                    break;
            }
        }
    }

