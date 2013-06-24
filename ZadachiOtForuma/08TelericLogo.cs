using System;

class TelericLogo
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = x;
        int z = x / 2 + 1;
        int logoWidth = (2 * z) + (2 * y) - 3;
        int logoHeight = 3 * x - 2;
        int hornsLength = x / 2;
        int middleDots = logoWidth - 2 * z;

        //first Row
        
        Console.Write(new string('.', hornsLength));
        Console.Write('*');
        Console.Write(new string('.', middleDots));
        Console.Write('*');
        Console.Write(new string('.', hornsLength));
        Console.WriteLine();
        
        //between
        int dotNum = 1;
        middleDots -= 2;
        int firstHornDot = x/2-1;
        int dotsAfterHorn = 0;
        for (int i = 1; i < x-1; i++)
        {
            //hornLeft
            if (i < x/2+1)
            {
                Console.Write(new string('.',firstHornDot));
                Console.Write('*');
                Console.Write(new string('.', dotsAfterHorn));
            }
            else
            {
                //after horn
                Console.Write(new string('.', hornsLength));
            }
            
            Console.Write(new string('.', dotNum));
            Console.Write('*');
            Console.Write(new string('.', middleDots));
            Console.Write('*');
            Console.Write(new string('.', dotNum));

            //HornRight
            if (i < x/2+1 )
            {
                Console.Write(new string('.', dotsAfterHorn));
                Console.Write('*');
                Console.Write(new string('.', firstHornDot));
                firstHornDot--;
                dotsAfterHorn++; 
            }
            else
            {
                //after horn
                Console.Write(new string('.', hornsLength));
            }
            Console.WriteLine();
            dotNum++;
            middleDots -= 2;
        }
        //midle Row
        Console.Write(new string('.', hornsLength));
        Console.Write(new string('.', x-1));
        Console.Write('*');
        Console.Write(new string('.', x - 1));
        Console.Write(new string('.', hornsLength));
        Console.WriteLine();

        //Between AGAIN
        middleDots = 1;
        for (int i = 1; i < x - 1; i++)
        {

            Console.Write(new string('.', hornsLength));
            Console.Write(new string('.', dotNum-1));
            Console.Write('*');
            Console.Write(new string('.', middleDots));
            Console.Write('*');
            Console.Write(new string('.', dotNum-1));
            Console.Write(new string('.', hornsLength));
            Console.WriteLine();
            dotNum--;
            middleDots += 2;
        }
        //first Row AGAIN
        Console.Write(new string('.', hornsLength));
        Console.Write('*');
        Console.Write(new string('.', middleDots));
        Console.Write('*');
        Console.Write(new string('.', hornsLength));
        Console.WriteLine();

        //between again down
        middleDots -= 2;
        for (int i = 1; i < x - 1; i++)
        {

            Console.Write(new string('.', hornsLength));
            Console.Write(new string('.', dotNum));
            Console.Write('*');
            Console.Write(new string('.', middleDots));
            Console.Write('*');
            Console.Write(new string('.', dotNum));
            Console.Write(new string('.', hornsLength));
            Console.WriteLine();
            dotNum++;
            middleDots -= 2;
        }
        //midle Row again for the last time
        Console.Write(new string('.', hornsLength));
        Console.Write(new string('.', x - 1));
        Console.Write('*');
        Console.Write(new string('.', x - 1));
        Console.Write(new string('.', hornsLength));
        Console.WriteLine();
    }
}

