using System;

namespace TaskF
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            if (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Console.WriteLine(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
    }
}
