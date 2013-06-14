using System;
/*Write a program that gets a number n and after that gets more n numbers
 * and calculates and prints their sum. 
*/
class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to sum : ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number you want to sum : ");
            int num = int.Parse(Console.ReadLine());

            sum += num;
            Console.WriteLine("The sum is {0}", sum);

        }

        Console.WriteLine("The sum of all numbers is {0}", sum);
    }
}
