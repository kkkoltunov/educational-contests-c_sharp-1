using System;
using System.Collections.Generic;
using System.Text;

partial class Program
{
    static int[][] GetBellTriangle(uint rowCount)
    {
        int[][] triangle = new int[rowCount][];

        for (int i = 0; i < triangle.Length; i++)
        {
            triangle[i] = new int[i + 1];
        }

        triangle[0][0] = 1;

        for (int i = 1; i < triangle.Length; i++)
        {
            triangle[i][0] = triangle[i - 1][triangle[i - 1].Length - 1];

            for (int j = 1; j < triangle[i].Length; j++)
            {
                triangle[i][j] = triangle[i][j - 1] + triangle[i - 1][j - 1];
            }
        }

        return triangle;
    }

    private static void PrintJaggedArray(int[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write($"{array[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}

