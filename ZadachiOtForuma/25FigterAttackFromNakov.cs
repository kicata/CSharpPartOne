﻿using System;

class FigterAttackFromNakov
{
    static void Main()
    {
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());

        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());

        int distance = int.Parse(Console.ReadLine());
        int minX = Math.Min(px1, px2);
        int maxX = Math.Max(px1, px2);

        int minY=Math.Min(py1,py2);
        int maxY = Math.Max(py1, py2);
        fx = fx + distance;
        int damage = 0;
        if ((fx >= minX)&&(fx <= maxX)&&
            (fy>=minY)&&(fy<=maxY))
        {
            damage += 100;
        }
        if ((fx+1 >= minX) && (fx+1 <= maxX) &&
            (fy >= minY) && (fy <= maxY))
        {
            damage += 75;
        }
        if ((fx >= minX) && (fx <= maxX) &&
            (fy-1 >= minY) && (fy-1<= maxY))
        {
            damage += 50;
        }
        if ((fx >= minX) && (fx <= maxX) &&
            (fy + 1 >= minY) && (fy + 1 <= maxY))
        {
            damage += 50;
        }
        Console.WriteLine(damage+"%");
    }
}

