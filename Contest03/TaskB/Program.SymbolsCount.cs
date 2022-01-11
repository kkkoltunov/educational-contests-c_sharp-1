using System;

partial class Program
{
    private static void GetLetterDigitCount(string line, out int digitCount, out int letterCount)
    {
        digitCount = 0;
        letterCount = 0;

        // Подсчет нужных символов и чисел.

        for (int i = 0; i < line.Length; i++)
        { 
            if (((line[i] >= 'a') && (line[i] <= 'z')) || ((line[i] >= 'A' && line[i] <= 'Z')))
            {
                letterCount++;
            }

            if ((line[i] >= '0') && (line[i] <= '9'))
            {
                digitCount++;
            }
        }
    }
}