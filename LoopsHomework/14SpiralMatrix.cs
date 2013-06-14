using System;
//Write a program that reads a positive integer number N (N < 20) 
//from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.



class SpiralMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int maxRow = n - 1;
        int minRow = 0;
        int maxCol = n - 1;
        int minCol = 0;
        int maxCount = n * n;
        int count = 1;

        while (count < maxCount+1)
        {
            for (int col = minCol; col <= maxCol; col++)
            {
                matrix[minRow, col] = count;
                count++;
            }
            minRow++;
            //top right
            for (int row = minRow; row <= maxRow; row++)
            {
                matrix[row, maxCol] = count;
                count++;
            }
            maxCol--;
            //bottom right
            for (int col = maxCol; col >= minCol; col--)
            {
                matrix[maxRow, col] = count;
                count++;
            }
            maxRow--;
            //bottom left

            for (int row = maxRow; row >= minRow; row--)
            {
                matrix[row, minCol] = count;
                count++;
            }
            minCol++;
            //left top
        }


        //print output
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col].ToString().PadLeft(3));
                //Console.Write(matrix[row, col] + "    ");
            }
            Console.WriteLine();
        }
    }
}



