using System;
using System.Threading;
using System.Globalization;
    class MathExpression
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            const int first = 1337;
            const double second = 128.523123123;

            double divident = n * n + 1 / (m * p) + first;
            double divisor = n - (second * p);
            

            double result = divident / divisor + Math.Sin((int)m%180);
            Console.WriteLine("{0:F6}",result);
        }
    }

