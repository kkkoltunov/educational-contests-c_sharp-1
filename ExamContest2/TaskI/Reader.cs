using System;
using System.IO;
using System.Collections.Generic;

public static class Reader
{
    public static int[] ReadFile(string fileName)
    {
        string line = File.ReadAllText(fileName);

        string[] lineSplit = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        List<int> result = new List<int>();

        for (int i = 0; i < lineSplit.Length; i++)
        {
            result.Add(ParseWord(lineSplit[i]));
        }

        return result.ToArray();
    }

    private static int ParseWord(string word)
    {
        string number = null;
        bool numNeg = false;

        int result = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == '-' && string.IsNullOrEmpty(number))
            {
                numNeg = !numNeg;
            }
            else if (int.TryParse(word[i].ToString(), out int delete))
            {
                number += word[i];
            }
        }

        if (numNeg)
        {
            result = int.Parse(number) * (-1);
        }
        else
        {
            result = int.Parse(number);
        }
        return result;
    }
}