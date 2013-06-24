using System;
   
class Carpets
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            
            int elementsOnLine = lines;
            int center = elementsOnLine / 2;
            //i e No na reda
            for (int i = 1; i <=lines/2; i++)
            {
                int elmPos = 1;
                while (elmPos<=elementsOnLine)
                {
                    //dots
                    if ((elmPos<=center-i)||(elmPos>=center+i))
                    {
                        Console.Write(".");
                        elmPos++;
                    }
                    else
                    {
                        //left side
                        for (int j = 0; j < i; j++)
                        {
                            if (j%2==0)
                            {
                                Console.Write("/");
                                elmPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elmPos++;
                            }
                        }
                        //rigth side
                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("\\");
                                elmPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elmPos++;
                            }
                        }  
                    }
                } 
                Console.WriteLine();
            }
            //Bottom Part
            for (int i = lines / 2; i>0 ; i--)
            {
                int elmPos = 1;
                while (elmPos <= elementsOnLine)
                {
                    //dots
                    if ((elmPos <= center - i) || (elmPos > center + i))
                    {
                        Console.Write(".");
                        elmPos++;
                    }
                    else
                    {
                        //leftside
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("\\");
                                elmPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elmPos++;
                            }
                        }
                        //right side
                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("/");
                                elmPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elmPos++;
                            }
                        }  
                    }  
                }
                Console.WriteLine();
            }
        }
    }

