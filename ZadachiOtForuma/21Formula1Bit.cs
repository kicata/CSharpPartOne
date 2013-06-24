using System;

class Formula1Bit
{
    static void Main()
    {
        bool[,] matrix = new bool[8, 8];
        //pulnim masiva
        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                matrix[i,j]=((number>>j)&1)!=0;
            }
        }
        int row = 0;
        int col = 0;

        int pathCount = 0;
        int directionCount = 0;

        bool exitFound = false;

        string direction = "down";
        string lastDirection = "down";

        //infinite loop da cikli postoqnno
        while (true)
        {
            if (matrix[row,col])
            {
                //ako nqma izhod ot 0 samo break
                break;
            }
            //otbelqzva kvadrat4etata prez koito sme minali
            pathCount++;

            //ako sme stignali do kraq  zada izlezem
            if (row==7&&col==7)
            {
                exitFound = true;
                break;
            }
            //smqna na posokite
            if (direction=="down" && (row+1>7 || matrix[row+1,col]))//tova tyk e bool
            {
                direction = "left";
                lastDirection="down";
                directionCount++;
                if (col+1>7|| matrix[row,col+1])
                {  
                    //ako e edinica ili izlizame ot masiva
                    break;
                }
                
            }
            else if (direction == "up" && (row-1 < 0  || matrix[row-1, col]))//tova tyk e bool
            {
                direction = "left";
                lastDirection = "up";
                directionCount++;
                if (col + 1 > 7 || matrix[row, col + 1])
                {
                    //ako e edinica ili izlizame ot masiva
                    break;
                }
                
            }
            else if (direction == "left" && lastDirection=="down" && (col+1>7  || matrix[row,col+1]))//tova tyk e bool
            {
                direction = "up";
                lastDirection = "up";
                directionCount++;
                if (row-1<0 || matrix[row-1, col])
                {
                    //ako e edinica ili izlizame ot masiva
                    break;
                }
                
            }
            else if (direction == "left" && lastDirection=="up" && (col+1>7  || matrix[row,col+1]))//tova tyk e bool
            {
                direction = "down";
                lastDirection = "down";
                directionCount++;
                if (row+1>7 || matrix[row+1, col])
                {
                    //ako e edinica ili izlizame ot masiva
                    break;
                }
                
            }
            //poka4vane na  reda i kolonata v zavisimost ot posokata
            if (direction=="down")
            {
                row++; 
            }
            if (direction == "left")
            {
                col++;
            }
            if (direction == "up")
            {
                row--;
            }
        }
        if (exitFound)
        {
            Console.WriteLine(pathCount + " " + directionCount);
        }
        else
        {
            Console.WriteLine("No "+pathCount);
        }
    }
}

