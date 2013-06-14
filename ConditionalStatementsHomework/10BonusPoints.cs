﻿using System;
/*Напишете програма, която прилага бонус точки към дадени точки в
интервала [1..9] чрез прилагане на следните правила:
- Ако точките са между 1 и 3, програмата ги умножава по 10.
- Ако точките са между 4 и 6, ги умножава по 100.
- Ако точките са между 7 и 9, ги умножава по 1000.
- Ако точките са 0 или повече от 9, се отпечатва съобщение за
грешка.
 * */
    class BonusPoints
    {
        static void Main(string[] args)
        {
            Console.Write("Enter points between 1 and 9 : ");
            int points = int.Parse(Console.ReadLine());

            switch (points)
            {
                case 1:
                case 2:
                case 3:
                    points *= 10;
                    Console.WriteLine(points);
                    break;
                case 4:
                case 5:
                case 6:
                    points *= 100;
                    Console.WriteLine(points);
                    break;
                case 7:
                case 8:
                case 9:
                    points *= 1000;
                    Console.WriteLine(points);
                    break;
                default:
                    Console.WriteLine("Error: the points must be between 1-9");
                    break;
            }
        }
    }

