using System;

partial class Program
{
    public static void Main(string[] args)
    {
        int a;
        int b;
        int c;

        bool fail = false;

        if (!int.TryParse(Console.ReadLine(), out a))
        {
            fail = true;
        }
        if (!int.TryParse(Console.ReadLine(), out b))
        {
            fail = true;
        }
        if (!int.TryParse(Console.ReadLine(), out c))
        {
            fail = true;
        }

        if (!(a + b > c && a + c > b && b + c > a))
        {
            fail = true;
        }

        if (fail == false)
        {
            Console.WriteLine(a + b + c);
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}