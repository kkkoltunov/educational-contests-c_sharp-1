using System;

namespace TaskD
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

            if (a != b)
            {
                if (a > b)
                {
                    Console.WriteLine("First");
                }
                if (b > a)
                {
                    Console.WriteLine("Second");
                }
            }
            else
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
