using System;

partial class Program
{
    private static bool Validate(string input, out int num)
    {
        bool temp = true;

        if (!int.TryParse(input, out num) || num < 0)
        {
            temp = false;
        }

        return temp;
    }

    private static int RecurrentFunction(int n)
    {
        int peoples = 0;

        // Обрабокта исключений для 0 и 1 года.

        if (n == 0)
        {
            peoples = 3;

            return peoples;
        }

        if (n == 1)
        {
            peoples = 8;

            return peoples;
        }

        // Подсчет для n-ного года.

        int[] array = new int[n];

        array[0] = 8;

        for (int i = 1; i < array.Length; i++)
        {
            array[i] += 2 * (array[i - 1] + 1);
            peoples = array[i];
        }

        return peoples;
    }
}