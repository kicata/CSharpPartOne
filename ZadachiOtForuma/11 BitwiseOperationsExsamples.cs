using System;



    class BitwiseOperations

    {
        static void Main()
        {
            // kak da printirame chislo kato dvoi4no
            int number = -778;
            Console.WriteLine("number {0} as binary-> {1}",number,Convert.ToString(number,2));
            // s dobavka za vsi4kite nuli za tipa int
            Console.WriteLine("number {0} as binary-> {1}", number, Convert.ToString(number, 2).PadLeft(32,'0'));

            //*******************************************************************************************************
            //*Write a boolean expression that returns if the bit at position p
            //* (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.
            //*/
            Console.WriteLine("Please write an integer number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write the position which you desire to check: ");
            int p = int.Parse(Console.ReadLine());


            int mask = 1 << p;
            int numAndMask = num & mask;
            int bit = numAndMask >> p;
            bool bitPol = true;
            if (bit != 0)
            {
                Console.WriteLine("the bit " + p + " (counting from 0) of a typed in integer " + num + " is 1");
                Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
                Console.WriteLine(bitPol);
            }
            else
            {
                Console.WriteLine("the bit " + p + " (counting from 0) of a typed in integer " + num + " is 0");
                Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
                bitPol = false;
                Console.WriteLine(bitPol);
            }
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Write an expression that extracts from a given integer i 
            //* the value of a given bit number b. Example: i=5; b=2  value=1
            //* */
            Console.WriteLine("Please write an integer number: ");
             num = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write the desired bit number: ");
            int bitNumber = int.Parse(Console.ReadLine());

             mask = 1 << bitNumber;
             numAndMask = num & mask;
            int bitValue = numAndMask >> bitNumber;

            Console.WriteLine("The value of the bit in position " + bitNumber + " of number " + num + " is " + bitValue);
            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            //Set The BitAt position to:

            Console.WriteLine("Please write an integer number: ");
             num = int.Parse(Console.ReadLine());

            Console.WriteLine("The binery representation of the given number " + num + " is: ");
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));

            Console.WriteLine("Please write the desired bit position to change: ");
            int bitPosition = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write the desired bit value \\0 or 1\\: ");
             bitValue = int.Parse(Console.ReadLine());

            if (bitValue == 1)
            {
                 mask = 1 << bitPosition;
                int result = num | mask;

                Console.WriteLine("The binery representation of the result " + result + " is: ");

                Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            }
            else
            {
                 mask = ~(1 << bitPosition);
                int result = num & mask;

                Console.WriteLine("The binery representation of the result " + result + " is: ");

                Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            }

        }


    }

