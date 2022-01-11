using System;

class Program
{
    static void Main(string[] args)
    {
        uint num;
        uint sum = 0;

        if (!uint.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }

        Console.WriteLine(sum);
    }
}

