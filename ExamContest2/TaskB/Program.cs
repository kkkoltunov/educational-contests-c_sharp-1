using System;

class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] arrayInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        double average = 0;
        int parse;

        for (int i = 0; i < arrayInput.Length; i++)
        {
            if (int.TryParse(arrayInput[i], out parse))
            {
                average += parse;
            }
        }

        average /= arrayInput.Length;
        Console.WriteLine(average.ToString("f3"));
    }
}