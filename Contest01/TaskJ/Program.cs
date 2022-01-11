using System;

namespace TaskJ
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            bool circle = (Math.Pow(a, 2) + Math.Pow(b, 2) <= 2) && (Math.Pow(a, 2) + Math.Pow(b, 2) >= 1);

            Console.WriteLine(circle);
        }
    }
}
