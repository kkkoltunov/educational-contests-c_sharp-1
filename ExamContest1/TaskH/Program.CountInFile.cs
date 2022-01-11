using System;
using System.IO;

partial class Program
{
    private static readonly string[] Separators = { " ", ". ", ", ", "? ", "! ", ": ", "; " };

    private static void CountInFile(string filePath, out int linesCount, out int wordsCount, out int charsCount)
    {
        // read file.

        string[] text = File.ReadAllLines(filePath);

        // lines count.

        linesCount = text.Length;

        // chars count.

        charsCount = 0;

        for (int i = 0; i < text.Length; i++)
        {
            string temp = text[i];

            charsCount += temp.Length;
        }

        // count words.

        wordsCount = 0;

        for (int i = 0; i < text.Length; i++)
        {
            string temp = text[i];

            string[] tempStr = temp.Split(Separators, StringSplitOptions.None);

            for (int k = 0; k < tempStr.Length; k++)
            {
                wordsCount++;
            }
        }
    }
}