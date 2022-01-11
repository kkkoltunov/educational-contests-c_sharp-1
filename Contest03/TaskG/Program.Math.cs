using System;

partial class Program
{
    private static double GetMin(double[] array)
    {
        // Поиск минимального элемента.

        double min = int.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        return min;
    }

    private static double GetAverage(double[] array)
    {
        // Подсчет среднего арифметического.

        double average = 0;

        for (int i = 0; i < array.Length; i++)
        {
            average += array[i];
        }

        average /= array.Length;

        return average;
    }

    private static double GetMedian(double[] array)
    {
        double mediana = 0;

        // Сортирока массива по неубыванию.

        Array.Sort(array);

        int middle = array.Length / 2;

        // Подсчет медианы для четного и нечетного количества цифр.

        if (array.Length % 2 == 0)
        {
            mediana = (array[middle - 1] + array[middle]) / 2;
        }

        if (array.Length % 2 == 1)
        {
            if (array.Length == 1)
            {
                mediana = array[0];
            }
            else
            {
                mediana = array[middle];
            }
        }

        return mediana;
    }
    
    private static double[] ReadNumbers(string line)
    {
        // Конвертация строки в вещественный массив.

        string[] arrayStr = line.Split(' ');

        double[] arrayDbl = new double[arrayStr.Length];

        for (int i = 0; i < arrayStr.Length; i++)
        {
            double num = Convert.ToDouble(arrayStr[i]);
            arrayDbl[i] = num;
        }

        return arrayDbl;
    }
    
}