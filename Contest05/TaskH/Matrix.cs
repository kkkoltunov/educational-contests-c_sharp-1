using System;
using System.IO;

internal class Matrix
{
    int[,] matrix;

    public Matrix(string filename)
    {
        string[] matrixStr = File.ReadAllLines(filename);

        string[] firstStr = matrixStr[0].Split(';');

        matrix = new int[matrixStr.Length, firstStr.Length];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            firstStr = matrixStr[i].Split(';');

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int.TryParse(firstStr[j], out matrix[i, j]);
            }
        }
    }

    public int SumOffEvenElements
    {
        get
        {
            int countEven = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        countEven += matrix[i, j];
                    }
                }
            }

            return countEven;
        }
    }


    public override string ToString()
    {
        string result = "";

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result += $"{matrix[i, j]}\t";
            }
            result += "\n";
        }

        return result;
    }
}