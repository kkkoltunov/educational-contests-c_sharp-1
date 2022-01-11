using System;

namespace TaskE
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            if (!int.TryParse(Console.ReadLine(), out num) || num <= 999 || num >= 10000)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Console.WriteLine((num / 1000 == num % 10) && ((num / 100) % 10 == (num / 10) % 10));
        }
    }
}
