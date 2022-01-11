using System;

namespace TaskH
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;

            if (!char.TryParse(Console.ReadLine(), out ch) || ch < 'a' || ch > 'z')
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Console.WriteLine((int)ch - 96);
        }
    }
}
