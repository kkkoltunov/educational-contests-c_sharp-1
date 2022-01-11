using System;

namespace TaskI
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            double fraq;

            if (!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            fraq = n - (int)n;

            if (fraq == 0.5 || fraq == -0.5)
            {
                if ((int)n % 2 == 0)
                {
                    Console.WriteLine(n + fraq);
                }
                else
                {
                    Console.WriteLine(n - fraq);
                }
            }
            else
            {
                Console.WriteLine(Math.Round(n));
            }
        }
    }
}
