using System;

namespace TaskG
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            if (!double.TryParse(Console.ReadLine(), out n) || n <= -1)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int res = (int)((n * 10) % 10);
            Console.WriteLine(res);
        }
    }
}
