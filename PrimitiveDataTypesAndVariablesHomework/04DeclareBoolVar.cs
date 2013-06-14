using System;
/*Declare a boolean variable called isFemale
 * and assign an appropriate value corresponding
 * to your gender.
 
 */
    class DeclareBoolVar
    {
        static void Main(string[] args)
        {
            bool isFemale = false;
            Console.WriteLine("Please write down your gender\\male or female\\: ");
            string gender = Console.ReadLine();

            if (gender=="male")
	        {
                Console.WriteLine("so your gender is male");
	        }
            else
            {
                isFemale = true;
                Console.WriteLine("your gender is female");
            }
        }
    }

