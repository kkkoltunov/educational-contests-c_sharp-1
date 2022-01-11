using System;

namespace TaskB
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Console.WriteLine(a - b);
        }
    }
}
