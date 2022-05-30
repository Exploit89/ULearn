using System;

namespace FloatComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1.0 / 10;
            double sum = 0;
            for (int i = 0; i < 10; i++)
                sum += x;
            Console.WriteLine(Math.Abs(sum - 1) < 1e-9);
        }
    }
}
