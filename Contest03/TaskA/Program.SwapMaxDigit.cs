using System;

partial class Program
{
    private static bool TryParseInput(string inputA, string inputB, out int a, out int b)
    {
        bool temp = true;

        if (!int.TryParse(inputA, out a) || a < 0)
        {
            temp = false;
        }
        if (!int.TryParse(inputB, out b) || b < 0)
        {
            temp = false;
        }

        return temp; 
    }

    private static void SwapMaxDigit(ref int a, ref int b)
    {
        int maxA = int.MinValue;
        int maxB = int.MinValue;

        int tempA = a;
        int tempB = b;

        int lenghtA = 0;
        int lenghtB = 0;

        // Вычисление длины числа А.

        while (tempA != 0)
        {
            lenghtA++;
            tempA /= 10;
        }

        // Вычисление длины числа B.

        while (tempB != 0)
        {
            lenghtB++;
            tempB /= 10;
        }

        if (lenghtA == 0)
        {
            lenghtA = 1;
        }

        if (lenghtB == 0)
        {
            lenghtB = 1;
        }

        int[] arrayA = new int[lenghtA];
        int[] arrayB = new int[lenghtB];

        // Создание массива из числа А.

        for (int i = lenghtA - 1; i >= 0; i--)
        {
            arrayA[i] = a % 10;
            a /= 10;
        }

        // Создание массива из числа B.

        for (int i = lenghtB - 1; i >= 0; i--)
        {
            arrayB[i] = b % 10;
            b /= 10;
        }

        // Поиск максимального числа в массивах.

        for (int i = 0; i < lenghtA; i++)
        {
            if (arrayA[i] > maxA)
            {
                maxA = arrayA[i];
            }
        }

        for (int i = 0; i < lenghtB; i++)
        {
            if (arrayB[i] > maxB)
            {
                maxB = arrayB[i];
            }
        }

        if (maxA == int.MinValue)
        {
            maxA = 0;
        }

        if (maxB == int.MinValue)
        {
            maxB = 0;
        }

        // Замена максимальных значений в массивах.

        for (int i = 0; i < lenghtA; i++)
        {
            if (arrayA[i] == maxA)
            {
                arrayA[i] = maxB;
            }
        }

        for (int i = 0; i < lenghtB; i++)
        {
            if (arrayB[i] == maxB)
            {
                arrayB[i] = maxA;
            }
        }

        // Обнуление переменных.

        a = 0;
        b = 0;

        // Переменные для сдвига разрядов.

        int partA = 1;
        int partB = 1;

        // Переворот массива.

        Array.Reverse(arrayA);
        Array.Reverse(arrayB);

        // Запись цифр из массива в число.

        for (int i = 0; i < lenghtA; i++)
        {
            a += (partA * arrayA[i]);
            partA *= 10;
        }

        for (int i = 0; i < lenghtB; i++)
        {
            b += (partB * arrayB[i]);
            partB *= 10;
        }
    }
}