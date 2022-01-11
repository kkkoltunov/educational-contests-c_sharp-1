using System;
using System.IO;

partial class Program
{
    private static string GetTextFromFile(string inputPath)
    {
        string text = "";

        using (StreamReader sr = new StreamReader(inputPath))
        {
            text = sr.ReadToEnd();
        }

        return text;
    }

    private static int GetSumFromText(string text)
    {
        // Сумма цифр.

        int count = 0;

        // Строка, в которую будет входящая строка без лишних символов.

        string res = "";

        // Цикл, который записывают новую строку без лишних символов.

        for (int i = 0; i < text.Length; i++)
        {
            if ((text[i] == ',') || (text[i] == '.') || (text[i] == '!') || (text[i] == '?') || (text[i] == '\n'))
            {
                res += " ";
            }
            if ((text[i] != ',') && (text[i] != '.') && (text[i] != '!') && (text[i] != '?') && (text[i] != '\n'))
            {
                res += text[i];
            }
        }

        // Массив из всех элементов строки.

        string[] textString = res.Split(' ');

        int n;

        // Подсчет чисел.

        for (int i = 0; i < textString.Length; i++)
        {
            if (int.TryParse(textString[i], out n))
            {
                count += n;
            }
        }

        return count;
    }
}