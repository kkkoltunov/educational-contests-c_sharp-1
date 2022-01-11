using System;

partial class Program
{
    private static bool ValidateData(int day, int month, int year)
    {
        if (!(year >= MinYear && year <= MaxYear))
        {
            return false;
        }

        if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
        {
            if ((month == 01 || month == 03 || month == 05 || month == 07 || month == 08 || month == 10 || month == 12) && (day >= 1 && day <= 31))
            {
                return true;
            }

            if ((month == 04 || month == 06 || month == 09 || month == 11) && (day >= 1 && day <= 30))
            {
                return true;
            }

            if (month == 02 && (day >= 1 && day <= 29))
            {
                return true;
            }
        }
        else
        {
            if ((month == 01 || month == 03 || month == 05 || month == 07 || month == 08 || month == 10 || month == 12) && (day >= 1 && day <= 31))
            {
                return true;
            }

            if ((month == 04 || month == 06 || month == 09 || month == 11) && (day >= 1 && day <= 30))
            {
                return true;
            }

            if (month == 02 && (day >= 1 && day <= 28))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Получение дня недели
    /// </summary>
    /// <param name="day"></param>
    /// <param name="month"></param>
    /// <param name="year"></param>
    /// <returns>Возвращает число от 1 до 7, где 1 - понедельник, и т.д. </returns>
    private static int GetDayOfWeek(int day, int month, int year)
    {
        int code_month = -1;
        int code_year = -1;
        int code_leapYear = 0;
        int code_century = -2;

        switch (month)
        {
            case 01:
                code_month = 6;
                break;
            case 02:
                code_month = 2;
                break;
            case 03:
                code_month = 2;
                break;
            case 04:
                code_month = 5;
                break;
            case 05:
                code_month = 0;
                break;
            case 06:
                code_month = 3;
                break;
            case 07:
                code_month = 5;
                break;
            case 08:
                code_month = 1;
                break;
            case 09:
                code_month = 4;
                break;
            case 10:
                code_month = 2;
                break;
            case 11:
                code_month = 2;
                break;
            case 12:
                code_month = 4;
                break;
        }

        if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
        {
            if ((month == 01) || (month == 02))
            {
                code_leapYear = -1;
            }
        }

        int x1 = ((year % 100) / 12);
        int x2 = ((year % 100) % 12);
        int x3 = x2 / 4;

        /*Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"x2 = {x2}");
        Console.WriteLine($"x3 = {x3}");*/

        code_year = x1 + x2 + x3;

        if (code_year == 0)
        {
            code_century = -4;
        }

        /*Console.WriteLine("day =" + day);
        Console.WriteLine("month =" + code_month);
        Console.WriteLine("leap year =" + code_leapYear);
        Console.WriteLine("cent =" + code_century);*/

        int sum = 0;

        if (year != 1800)
        {
            sum = (day + code_year + code_month + code_leapYear + code_century) % 7;

            if (sum == 0)
            {
                sum = 7;
            }
        }

        else
        {
            sum = (day + code_year + code_month + code_leapYear + code_century) % 7;

            if (sum == 0)
            {
                sum = 7;
            }

            if (sum == -1)
            {
                sum = 6;
            }

            if (sum == -2)
            {
                sum = 5;
            }

            if (sum == -3)
            {
                sum = 4;
            }
        }

        return sum;
    }

    private static string GetDateOfFriday(int dateOfWeek, int day, int month, int year)
    {
        int delta_dateOfWeek = 5 - dateOfWeek;

        if (delta_dateOfWeek == - 1)
        {
            delta_dateOfWeek = 6;
        }

        if (delta_dateOfWeek == -2)
        {
            delta_dateOfWeek = 5;
        }

        day += delta_dateOfWeek;

        if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) && month == 02)
        {
            if (day > 29)
            {
                day += -29;
                month += 1;
            }

            if (day < 10)
            {
                return $"0{day}.0{month}.{year}";
            }

            else
            {
                return $"{day}.0{month}.{year}";
            }
        }

        else
        {
            if ((month == 01 || month == 03 || month == 05 || month == 07 || month == 08 || month == 10 || month == 12))
            {
                if (day > 31)
                {
                    day += -31;
                    month += 1;

                    if (month > 12)
                    {
                        month = 1;
                        year++;
                    }
                }

                if (day >= 10 && month >= 10)
                {
                    return $"{day}.{month}.{year}";
                }

                if (day >= 10 && month < 10)
                {
                    return $"{day}.0{month}.{year}";
                }

                if (day < 10 && month >= 10)
                {
                    return $"0{day}.{month}.{year}";
                }

                if (day < 10 && month < 10)
                {
                    return $"0{day}.0{month}.{year}";
                }
            }

            if ((month == 04 || month == 06 || month == 09 || month == 11))
            {
                if (day > 30)
                {
                    day += -30;
                    month += 1;
                }

                if (day >= 10 && month >= 10)
                {
                    return $"{day}.{month}.{year}";
                }

                if (day >= 10 && month < 10)
                {
                    return $"{day}.0{month}.{year}";
                }

                if (day < 10 && month >= 10)
                {
                    return $"0{day}.{month}.{year}";
                }

                if (day < 10 && month < 10)
                {
                    return $"0{day}.0{month}.{year}";
                }
            }

            if (month == 02)
            {
                if (day > 28)
                {
                    day += -28;
                    month += 1;
                }

                if (day >= 10 && month >= 10)
                {
                    return $"{day}.{month}.{year}";
                }

                if (day >= 10 && month < 10)
                {
                    return $"{day}.0{month}.{year}";
                }

                if (day < 10 && month >= 10)
                {
                    return $"0{day}.{month}.{year}";
                }

                if (day < 10 && month < 10)
                {
                    return $"0{day}.0{month}.{year}";
                }
            }
        }

        return "fail";
    }


}