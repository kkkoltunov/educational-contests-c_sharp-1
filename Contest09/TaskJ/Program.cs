using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        int[] temperature = new int[input.Length];

        for (int i = 0; i < temperature.Length; i++)
        {
            temperature[i] = int.Parse(input[i]);
        }

        for (int i = 0; i < temperature.Length; i++)
        {
            int result = 0;

            for (int j = i + 1; j < temperature.Length; j++)
            {
                if (temperature[j] > temperature[i])
                {
                    result = j - i;
                    break;
                }
            }

            Console.Write($"{result} ");
        }
    }
}