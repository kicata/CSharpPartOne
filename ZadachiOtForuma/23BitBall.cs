using System;

    class BitBall
    {
        static void Main()
        {
            int[,] matrix = new int[8, 8];

            //za pyrvite osem
            for (int i = 0; i < 8; i++)
            {
                int number = int.Parse(Console.ReadLine());

                for (int j = 0; j < 8; j++)
                {
                    int bit = (number >> j) & 1;
                    if (bit==1)
                    {
                        matrix[i,j] = bit;
                    }
                }
            }
            //za vtorite osem
            for (int i = 0; i < 8; i++)
            {
                int number = int.Parse(Console.ReadLine());

                for (int j = 0; j < 8; j++)
                {
                    int bit = (number >> j) & 1;

                    if (bit == 1)
                    {
                        if (matrix[i,j]==1)
                        {
                            matrix[i,j] = 0;
                        }
                        else
                        {
                            //za da mogat da se razli4avat igra4ite na dvata otbora

                           matrix[i,j] = 2;

                        }
                        
                    }
                }
            }
            //Lets game begin
            int counter1 = 0;
            int counter2 = 0;
            //up-down attack proveriavame za ataka na otbor 2
            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row,col]==1)
                    {
                        break;
                    }
                    else if (matrix[row,col] == 2)
                    {
                        counter2++;
                        break;
                    }
                }
            }
            //down up attack
            for (int col = 0; col < 8 ; col++)
            {
                for (int row = 7; row >=0 ; row--)
                {
                    if (matrix[row, col] == 1)
                    {
                        counter1++;
                        break;
                    }
                    else if (matrix[row,col] == 2)
                    {
                        
                        break;
                    }
                }
            }
            Console.WriteLine("{0}:{1}",counter1,counter2);
        }
    }

