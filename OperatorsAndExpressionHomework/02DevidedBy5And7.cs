using System;
//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
class DevidedBy5And7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write an integer number:");
            int num = int.Parse(Console.ReadLine());

            if ((num%5==0)&&(num%7==0))
            {
                Console.WriteLine("The number "+num+" that you just typed in CAN be devided \nby 5 and 7 in the same time");
            }
            else
            {
                Console.WriteLine("The number " + num + " that you just typed in CAN'T be devided \nby 5 and 7 in the same time");
            }
        }
    }

