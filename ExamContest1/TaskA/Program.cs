using System;

class Program
{
    public static void Main(string[] args)
    {
        short a;
        short b;

        bool fail = false;

        if (!short.TryParse(Console.ReadLine(), out a))
        {
            fail = true;
        }

        if (!short.TryParse(Console.ReadLine(), out b))
        {
            fail = true;
        }

        if (fail == false)
        {
            Console.WriteLine(a ^ b);
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}