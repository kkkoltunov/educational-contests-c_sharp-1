using System;

partial class Program
{
    static void Main(string[] args)
    {
        int a, b;

        if(!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        if (!int.TryParse(Console.ReadLine(), out b) || a >= b)
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        for (int i = a; i < b; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
