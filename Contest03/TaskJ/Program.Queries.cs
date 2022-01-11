using System;
using System.Collections.Generic;
using System.IO;

partial class Program
{
    private static bool ValidateQuery(string query, out string[] queryParameters)
    {
        // Смена локали.

        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        // Массив из данных, которые подаются при вводе.

        queryParameters = query.ToLower().Split(' ');

        // Переменные, которые используются при проверке корректности ввода.

        bool flagFirst = false;
        bool flagSecond = false;
        bool flagThird = false;

        bool result = false;

        // Переменная для конвертации string в double.

        double thirdParam = 0;

        // Массивы с возможными введенными данными.

        string[] titleText = { "first_name", "last_name", "group" };
        string[] titleNums = { "rating", "gpa" };

        if (queryParameters.Length == 3)
        {
            // Проверка по "first_name", "last_name", "group".

            for (int i = 0; i < titleText.Length; i++)
            {
                if ((queryParameters[0] == titleText[i]) && (queryParameters[1] == "==" || queryParameters[1] == "<>"))
                {
                    flagFirst = true;
                }
            }

            // Проверка по "rating", "gpa".

            for (int i = 0; i < titleNums.Length; i++)
            {
                if ((queryParameters[0] == titleNums[i]) && (queryParameters[1] == ">=" || queryParameters[1] == "<="))
                {
                    flagSecond = true;
                }
            }

            if (queryParameters[0] == titleNums[0] || queryParameters[0] == titleNums[1])
            {
                if (double.TryParse(queryParameters[2], out thirdParam))
                {
                    flagThird = true;
                }
            }
        }

        // Результат проверки на корректность.

        if ((flagFirst == true) || ((flagSecond == true) && (flagThird == true)))
        {
            result = true;
        }
        else
        {
            File.WriteAllText("queryResult.txt", "Incorrect input");
        }

        return result;
    }

    private static List<string> ProcessQuery(string[] queryParameters, string pathToDatabase)
    {
        // Массив строк, который состоит из строк базы данных.

        string[] data = File.ReadAllLines(pathToDatabase);

        // Переменные для конвертации из string в int.

        int ratingBase = 0;
        int ratingInput = 0;

        // Переменные для конвертации из string в double.

        double gpaBase = 0;
        double gpaInput = 0;

        // Лист, который формируется исходя из базы данных.

        List<string> result = new List<string>();

        for (int i = 1; i < data.Length; i++)
        {
            // Разбиение каждой строки на отдельный фрагменты (по ;).

            string[] temp = data[i].ToLower().Split(';');

            // Проверка по "first_name".

            if (queryParameters[0] == "first_name" && queryParameters[1] == "==")
            {
                if (queryParameters[2] == temp[0])
                {
                    result.Add(data[i]);
                }
            }
            if (queryParameters[0] == "first_name" && queryParameters[1] == "<>")
            {
                if (queryParameters[2] != temp[0])
                {
                    result.Add(data[i]);
                }
            }

            // Проверка по "last_name".

            if (queryParameters[0] == "last_name" && queryParameters[1] == "==")
            {
                if (queryParameters[2] == temp[1])
                {
                    result.Add(data[i]);
                }
            }
            if (queryParameters[0] == "last_name" && queryParameters[1] == "<>")
            {
                if (queryParameters[2] != temp[1])
                {
                    result.Add(data[i]);
                }
            }

            // Проверка по "group".

            if (queryParameters[0] == "group" && queryParameters[1] == "==")
            {
                if (queryParameters[2] == temp[2])
                {
                    result.Add(data[i]);
                }
            }
            if (queryParameters[0] == "group" && queryParameters[1] == "<>")
            {
                if (queryParameters[2] != temp[2])
                {
                    result.Add(data[i]);
                }
            }

            // Проверка по "rating".

            if (queryParameters[0] == "rating" && queryParameters[1] == ">=")
            {
                int.TryParse(queryParameters[2], out ratingInput);
                int.TryParse(temp[3], out ratingBase);

                if (ratingInput <= ratingBase)
                {
                    result.Add(data[i]);
                }
            }
            if (queryParameters[0] == "rating" && queryParameters[1] == "<=")
            {
                int.TryParse(queryParameters[2], out ratingInput);
                int.TryParse(temp[3], out ratingBase);

                if (ratingInput >= ratingBase)
                {
                    result.Add(data[i]);
                }
            }

            // Проверка по "gpa".

            if (queryParameters[0] == "gpa" && queryParameters[1] == ">=")
            {
                double.TryParse(queryParameters[2], out gpaInput);
                double.TryParse(temp[4], out gpaBase);

                if (gpaInput <= gpaBase)
                {
                    result.Add(data[i]);
                }
            }
            if (queryParameters[0] == "gpa" && queryParameters[1] == "<=")
            {
                double.TryParse(queryParameters[2], out gpaInput);
                double.TryParse(temp[4], out gpaBase);

                if (gpaInput >= gpaBase)
                {
                    result.Add(data[i]);
                }
            }
        }

        return result;
    }
}