using System;
using System.Collections.Generic;
using System.Linq;

namespace AvgFib
{
    class Program
    {
        static void Main(string[] args)
        {
            var next = 0.0m;
            var avg = 0.0m;
            var count = 0.0m;
            var fib = new List<decimal>();
            fib.Add(0);
            fib.Add(1);
            for(var i = 2; next < 200; i++)
            {
                next = fib[(i - 1)] + fib[(i - 2)];
                fib.Add(next);
            }
            foreach(int nbr in fib)
            {
                avg += nbr;
                count++;
            }
            avg = fib.Average();
            Console.WriteLine($"Average of sequence: {avg}");
        }
    }
}