using System;

namespace TaskC
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            if (!int.TryParse(Console.ReadLine(), out num) || num < 0)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Console.WriteLine(num % 10);
        }
    }
}
