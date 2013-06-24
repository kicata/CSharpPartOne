using System;



    class SandGlass
    {
        static void Main()
        {
            int n=int.Parse(Console.ReadLine());
            int half=n/2-1;
            int dot=1;
            Console.WriteLine(new string('*',n));
            for (int i = 1; i <= n/2-1; i++)
			{
			 Console.Write(new string('.',dot));
             Console.Write(new string('*',half));
             Console.Write(new string('*',half+1));
             Console.Write(new string('.',dot));
             Console.WriteLine();
                dot++;
                half--;
			}
            half=n/2;
            Console.Write(new string('.',half));
            Console.Write('*');
            Console.Write(new string('.', half));
            Console.WriteLine();

            dot = n / 2 - 1;
            half = 1;
            for (int i = 1; i <= n / 2 - 1; i++)
            {
                Console.Write(new string('.', dot));
                Console.Write(new string('*', half));
                Console.Write(new string('*', half + 1));
                Console.Write(new string('.', dot));
                Console.WriteLine();
                dot--;
                half++;
            }
            Console.WriteLine(new string('*', n));
        }
    }

