using System;

partial class Program
{
    private static int GetCountGreaterThanValue(int[] array, double average)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > average)
            {
                count++;
            }
        }

        return count;
    }

    private static double GetAverage(int[] array)
    {
        double average = 0;

        for (int i = 0; i < array.Length; i++)
        {
            average += array[i];
        }

        if (average != 0)
        {
            average /= array.Length;
        }

        return average;
    }
    
    private static bool ValidateNumber(out int n)
    {
        bool temp = true;

        if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            temp = false;
        }

        return temp;
    }
    
    private static bool ReadNumbers(int n, out int[] array)
    {
        bool temp = true;

        array = new int[n];

        for (int i = 0; i < n; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out array[i]) || (array[i] < 0))
            {
                temp = false;
            }
        }

        return temp;
    }
}