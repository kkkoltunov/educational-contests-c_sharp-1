using System;

namespace TaskTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            int.TryParse(Console.ReadLine(), out year);

            year = year % 100;

            Console.WriteLine(year);
        }
        
    }
}
