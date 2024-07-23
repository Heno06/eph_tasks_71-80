using System;
using System.Collections.Generic;
using static System.Math;
namespace eph_tasks_71_80
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculations = new List<(Func<double, double>, double, double, double)>
        {
            (x => Tan(2 * x + x * x), 2.4, 7.6, 0.2),
            (x => 1 / Tan(x * x), -5.4, 1.2, 0.4),
            (x => Pow((x + 1), 2), 7.5, 12.5, 0.2),
            (x => Pow(2, x + 4), -3.8, 5.4, 0.3),
            (x => Sin(2 * x) + Cos(x), -PI, PI, PI / 8),
            (x => x > 0 ? Pow(x, 2) + 4 * Pow(x, 8) : 0, -5, 5, 2),
            (x => x > 3 ? Pow(x, 2) + 4 * Pow(x, 8) : 0, -8, 8, 3),
            (x => x > 12 ? 3 * Log(x, 3) : Pow(x, 3), 10, 20, 2),
            (x => x > 1 ? Log(x, 4) : -9, -4, 5, 1)
        };

            foreach (var (func, start, end, step) in calculations)
            {
                Console.WriteLine("X\tY");
                for (double x = start; x <= end; x += step)
                {
                    Console.WriteLine($"{x}\t{func(x)}");
                }
                Console.WriteLine();
            }
        }
    }
}
