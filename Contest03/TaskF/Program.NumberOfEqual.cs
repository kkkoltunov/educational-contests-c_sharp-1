using System;

partial class Program
{
    private static int[] ParseInput(string input)
    {
        // Конвертация строки в целочисленный массив.

        string[] arrayStr = input.Split(' ');

        int[] arrayInt = new int[arrayStr.Length];

        for (int i = 0; i < arrayStr.Length; i++)
        {
            int num = Convert.ToInt32(arrayStr[i]);
            arrayInt[i] = num;
        }

        return arrayInt;
    }

    private static int GetNumberOfEqualElements(int[] first, int[] second)
    {
        int equal = 0;

        // Сортировка массива по неубыванию.

        Array.Sort(first);
        Array.Sort(second);

        // Поиск совпадающих элементов.

        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < second.Length; j++)
            {
                if (first[i] == second[j])
                {
                    equal++;
                }
            }
        }
        return equal;
    }
}