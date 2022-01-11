using System;

class Program
{
    static void Main(string[] args)
    {
        int n;
        int count = 0;

        if (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        if (Math.Abs(n) % 2 == 1)
        {
            count += n;
        }

        while (n != 0)
        {
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (Math.Abs(n) % 2 == 1)
            {
                count += n;
            }
        }

        Console.WriteLine(count);
    }
}
