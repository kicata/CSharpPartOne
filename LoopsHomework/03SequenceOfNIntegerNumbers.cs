using System;
//Write a program that reads from the console a sequence of N integer numbers
//and returns the minimal and maximal of them.

class SequenceOfNIntegerNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers you want to input: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        
        Console.WriteLine("Now enter a number and press enter ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr, 0, n);
        Console.WriteLine("The min value of the sequence is " + arr[0]);
        Console.WriteLine("The max value of the sequence is " + arr[n-1]);

    }

}




