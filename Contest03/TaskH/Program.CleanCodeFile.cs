using System;
using System.IO;

partial class Program
{
    private static string[] ReadCodeLines(string codePath)
    {
        return File.ReadAllLines(codePath);
    }

    private static string[] CleanCode(string[] codeWithComments)
    {
        // Создание файла для вывода.

        using (File.Create("cleanCode.cs"))
        {

        }

        // Переменная используется для многострочного комментария.

        int transit = 0;

        // Массив для записи данных из первого массива, но без пустых строк.

        string[] result = new string[codeWithComments.Length];

        // Однострочный комментарий.

        string oneComment = "//";

        // Многострочный комментарий.

        string multCommentStart = "/*";

        string multCommentEnd = "*/";

        // Строка, в которую будет записывать строка массива на каждой итерации.

        string temp = "";

        for (int i = 0; i < codeWithComments.Length; i++)
        {
            temp = codeWithComments[i];

            // Проверка для однострочного комментария.

            if (temp.TrimStart().StartsWith(oneComment))
            {
                codeWithComments[i] = " ";
            }

            // Проверка для многострочного комментария в одной строке.

            if ((temp.TrimStart().StartsWith(multCommentStart)) && (temp.Trim().EndsWith(multCommentEnd)))
            {
                codeWithComments[i] = " ";
            }

            // Проверка для многострочного комментария в разных строках.

            else if ((temp.TrimStart().StartsWith(multCommentStart)) && transit == 0)
            {
                transit = 1;
            }

            if (temp.Trim().EndsWith(multCommentEnd))
            {
                codeWithComments[i] = " ";
                transit = 0;
            }

            if (transit == 1)
            {
                codeWithComments[i] = " ";
            }
        }

        // Создание нового массива без пустых строк.

        result = Array.FindAll(codeWithComments, x => !string.IsNullOrEmpty(x.Trim()));

        return result;
    }

    private static void WriteCode(string codeFilePath, string[] codeLines)
    {
        File.WriteAllLines(codeFilePath, codeLines);
    }
}