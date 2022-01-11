using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

partial class Program
{
    static bool TryParseVectorFromFile(string filename, out int[] vector)
    {
        bool flag = true;

        string vectorStr = File.ReadAllText(filename);

        string[] vectorStrArray = File.ReadAllLines(filename);

        if (vectorStrArray.Length != 1)
        {
            flag = false;
        }

        string[] vectorStrSplit = vectorStr.Split(' ');

        vector = new int[vectorStrSplit.Length];

        for (int i = 0; i < vectorStrSplit.Length; i++)
        {
            if (!int.TryParse(vectorStrSplit[i], out vector[i]))
            {
                flag = false;
            }
        }

        return flag;
    }

    static int[,] MakeMatrixFromVector(int[] vector)
    {
        int[,] arrayMatrixFirst = new int[vector.Length, 1];
        int[,] arrayMatrixSecond = new int[1, vector.Length];

        for (int i = 0; i < arrayMatrixFirst.GetLength(0); i++)
        {
            for (int j = 0; j < arrayMatrixFirst.GetLength(1); j++)
            {
                arrayMatrixFirst[i, j] = vector[i];
            }
        }
        for (int i = 0; i < arrayMatrixSecond.GetLength(0); i++)
        {
            for (int j = 0; j < arrayMatrixSecond.GetLength(1); j++)
            {
                arrayMatrixSecond[i, j] = vector[j];
            }
        }

        int[,] arrayMatrixResult = new int[arrayMatrixFirst.GetLength(0), arrayMatrixSecond.GetLength(1)];

        for (int i = 0; i < arrayMatrixFirst.GetLength(0); i++)
        {
            for (int j = 0; j < arrayMatrixSecond.GetLength(1); j++)
            {
                for (int k = 0; k < arrayMatrixSecond.GetLength(0); k++)
                {
                    arrayMatrixResult[i, j] += arrayMatrixFirst[i, k] * arrayMatrixSecond[k, j];
                }
            }
        }

        return arrayMatrixResult;
    }

    static void WriteMatrixToFile(int[,] matrix, string filename)
    {
        string temp = "";

        string[] matrixResultArray = new string[matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp = "";

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp += matrix[i, j].ToString() + " ";
            }

            matrixResultArray[i] = temp;
        }

        File.WriteAllLines(filename, matrixResultArray);
    }
}
