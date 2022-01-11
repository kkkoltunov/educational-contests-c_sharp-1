using System;

partial class Program
{
    private static int[] ParseInput(string input)
    {
        string[] arrayStr = input.Split(' ');

        int[] arrayInt = new int[arrayStr.Length];

        for (int i = 0; i < arrayStr.Length; i++)
        {
            int num = Convert.ToInt32(arrayStr[i]);
            arrayInt[i] = num;
        }

        return arrayInt;
    }

    private static int GetMaxInArray(int[] numberArray)
    {
        int max = int.MinValue;

        for (int i = 0; i < numberArray.Length; i++)
        {
            if (numberArray[i] > max)
            {
                max = numberArray[i];
            }
        }

        return max;
    }
}