using System;
using System.Collections.Generic;

internal static class Program
{
    private static void Main(string[] args)
    {
        string inputStr = Console.ReadLine();

        string[] inputStrSplit = inputStr.Split(',');

        string temp = "";

        for (int i = 0; i < inputStrSplit.Length; i++)
        {
            for (int j = 0; j < inputStrSplit.Length; j++)
            {
                Console.Write(inputStrSplit[j]);
            }

            Console.WriteLine();

            temp = inputStrSplit[0];

            for (int k = 0; k < inputStrSplit.Length - 1; k++)
            {
                inputStrSplit[k] = inputStrSplit[k + 1];
            }

            inputStrSplit[inputStrSplit.Length - 1] = temp;
        }
    }
}