using System;
//

class Anachi
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        string nextAsString = "";
        int firstAsInt = 0;
        int secondAsInd = 0;
        string[] arr = { "Not a-nachi", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        
        //here we go from string to int
        for (int i = 0; i < arr.Length; i++)
        {
            if (first == arr[i])
            {
                firstAsInt = i;
            }
            else if (second == arr[i])
            {
                secondAsInd = i;
            }
        }
        int next = firstAsInt + secondAsInd;
        if (next > 26)
        {
            next = next % 26;
        }
        //next back to string
        for (int p = 0; p < arr.Length; p++)
        {
            if (next == p)
            {
                nextAsString = arr[p];
            }
            
        }
        //print first and second row
        if (rows<2)
        {
            Console.WriteLine(first);
        }
        else if (rows<3)
        {
            Console.WriteLine(first);
            Console.Write(second);
            Console.Write(nextAsString);
        }
        else
        {
            Console.WriteLine(first);
            Console.Write(second);
            Console.Write(nextAsString);
            Console.WriteLine();

            for (int j = 3; j <= rows; j++)
            {
                firstAsInt = secondAsInd;
                secondAsInd = next;
                next = firstAsInt + secondAsInd;

                if (next > 26)
                {
                    next = next % 26;
                }
                //return values to string

                for (int i = 0; i < arr.Length; i++)
                {
                    if (next == i)
                    {
                        nextAsString = arr[i];
                    }
                    else if (firstAsInt == i)
                    {
                        first = arr[i];
                    }
                    else if (secondAsInd == i)
                    {
                        second = arr[i];
                    }
                }
                //Print first part of the row
                Console.Write(nextAsString);
                Console.Write(new string(' ', j - 2));

                //Start calculating second part of the row
                firstAsInt = secondAsInd;
                secondAsInd = next;
                next = firstAsInt + secondAsInd;

                if (next > 26)
                {
                    next = next % 26;
                }
                //return values to string

                for (int i = 0; i < arr.Length; i++)
                {
                    if (next == i)
                    {
                        nextAsString = arr[i];
                    }
                    else if (firstAsInt == i)
                    {
                        first = arr[i];
                    }
                    else if (secondAsInd == i)
                    {
                        second = arr[i];
                    }
                }
                //Print second part of the row
                Console.Write(nextAsString);
                Console.WriteLine();
            }
        }
    }
}
  


